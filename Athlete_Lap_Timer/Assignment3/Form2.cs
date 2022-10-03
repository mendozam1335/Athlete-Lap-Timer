using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time2Library;

namespace Assignment3
{
    public partial class Form2 : Form
    {
        private StreamWriter fileWriter;
        List<Athlete> athletes = new List<Athlete>();
        public string sortedByName = "";
        public delegate int sorted(string str1, string str2);
        /// <summary>
        /// Pass Athlete from Form 1 and set it to form2 athletes list
        /// </summary>
        /// <param name="a">List of Athletes passed from form1</param>
        public Form2(List<Athlete> a)
        {
            InitializeComponent();
            athletes = a;
        }
        public int SortByName(string name1, string name2)
        {
            return name1.CompareTo(name2);
        }
        /// <summary>
        /// Helper method to displays all laps of an athlete
        /// </summary>
        /// <param name="athlete">Athlete Object passed from call</param>
        public void displayLaps(Athlete athlete)
        {
            athlete.Time.Sort();
            allAthletes.AppendText("Athlete Running: " + athlete + Environment.NewLine);
            foreach (Time2ss time in athlete.Time) {
                allAthletes.AppendText(time.ToUniversalString() + Environment.NewLine);
            }

        }
        /// <summary>
        /// Button event Handler to sort by name and display new results onto allAthletes text box
        /// Sort using a delegate that takes in 2 objects and compares their toString() and returns an int
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortByName_Click(object sender, EventArgs e)
        {
            //sorted byName = SortByName;
            sortedByName = "Sorted By Name";
            Console.Out.WriteLine("SortByName");
            athletes.Sort(delegate (Athlete a, Athlete b)
            {
                return a.ToString().CompareTo(b.ToString());
            });
            allAthletes.Clear();
            foreach(Athlete a in athletes)
            {
                displayLaps(a);
            }
        }
        /// <summary>
        /// Button event Handler to sort athletes by fastest lap
        /// calls on compareTo method in Athletes class
        /// displays new results in allathletes text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortFastestLap_Click(object sender, EventArgs e)
        {
            sortedByName = "Sorted By Fastest Lap";
            Console.Out.WriteLine("sort fastest Lap");
            athletes.Sort();
            allAthletes.Clear();
            foreach(Athlete a in athletes)
            {
                displayLaps(a);
            }
        }
        /// <summary>
        /// button Even Handler to sort based on a lap number entered in lap number text Box
        /// Uses a try catch for the input in number text box to check to see if it is a number
        /// Checks to see if that number is above 0 (starts from 1)
        /// display new sorted list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            Console.Out.WriteLine("Sort by Lap Number");
            try
            {
                int idx = int.Parse(lapNumber.Text) - 1;
                if (idx <= 0) throw new IndexOutOfRangeException();
                sortedByName = $"Sorted by Lap Number {idx + 1}";
                athletes.Sort(delegate (Athlete a, Athlete b)
                 {
                    if (a.Time.Count < idx && b.Time.Count < idx) return 0;
                     else if (a.Time.Count <= idx) return -1;
                     else if (b.Time.Count <= idx) return 1;
                     else return a.Time[idx].ToUniversalString().CompareTo(b.Time[idx].ToUniversalString());
                 });
                allAthletes.Clear();
                foreach(Athlete a in athletes)
                {
                    displayLaps(a);
                 }
            }
            catch
            {
                MessageBox.Show("Must Enter an Integer Above 0", "Error");
            }
        }
        /// <summary>
        /// Opens a save file dialogue to allow user to choose where to save the text file to
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFile_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using(var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                        fileWriter = new StreamWriter(output);
                        SaveFile.Enabled = false;
                        SaveRecord.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        /// <summary>
        /// Allows user to save records by the way they where sorted.
        /// Every time user clicks button, will append to the current text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveRecord_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Athlete a in athletes)
                {
                    fileWriter.WriteLine($"{a}");
                    foreach(Time2ss t in a.Time)
                    {
                        fileWriter.WriteLine($"{t.ToUniversalString()}");
                    }
                }
            }
            catch(IOException)
            {
                MessageBox.Show("Error writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Closes the file stream to save
        /// Exits the Application
        /// Will not save anything to text file if does not hit exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            try
            {
                fileWriter?.Close();
            }
            catch(IOException)
            {
                MessageBox.Show("Cannot close File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }
    }
}
