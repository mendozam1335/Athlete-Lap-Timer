using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time2Library;

namespace Assignment3
{
    public partial class Form1 : Form
    {
       List<Athlete> athletes = new List<Athlete>();
        Time2ss time = new Time2ss();
        int selectedIdx = 0;
        private BinaryFormatter formatter = new BinaryFormatter();
        private BinaryFormatter reader = new BinaryFormatter();
        private FileStream input;
        private FileStream output;


        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Button event handler that takes text from firstname and lastname text box
        /// and adds to athletes list
        /// Add newly created athlete to Athletename ListBox
        /// clear text from name textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_To_List_Click(object sender, EventArgs e)
        {
            string fname = FirstName.Text;
            string lname = LastName.Text;
            athletes.Add(new Athlete(fname, lname));
            AthleteName.Items.Add(athletes.Last<Athlete>());
            FirstName.Text = "";
            LastName.Text = "";

        }
        /// <summary>
        /// Helper function to display all time2ss laps from selected athlete in ListBox
        /// clear Output text box before displaying
        /// </summary>
        public void displayLaps()
        {
            OutPut.Clear();
            OutPut.AppendText("Athlete Running: " + athletes[selectedIdx] + Environment.NewLine);
            foreach (Time2ss item in athletes[selectedIdx].Time){
                OutPut.AppendText(item.ToUniversalString() + Environment.NewLine);
            }
        }
        /// <summary>
        /// Helper function used soley by Button1_click to display athletes sorted by fastest lap 
        /// in form 2 
        /// Exactly the same as displayLaps() except targeting form 2 text box
        /// </summary>
        /// <param name="a"></param>
        /// <param name="form2"></param>
        public void displayLaps(Athlete a, Form2 form2)
        {
            //form2.allAthletes.Clear();
            a.Time.Sort();
            form2.allAthletes.AppendText("Athlete Running: " + a + Environment.NewLine);
            foreach (Time2ss item in a.Time)
            {
                form2.allAthletes.AppendText(item.ToUniversalString() + Environment.NewLine);
            }
        }
        /// <summary>
        /// List box even handler upon cliking new index
        /// set the global selectedIdx to one clicked on list box
        /// set the name text boxes to name clicked on list box for easier reading
        /// display laps of that user clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AthleteName_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIdx = AthleteName.SelectedIndex;
            FirstName.Text = athletes[selectedIdx].FirstName;
            LastName.Text = athletes[selectedIdx].LastName;
            displayLaps();
        }
        /// <summary>
        /// every tick, call Time2ss addtime and add 10 milliseconds every 10 milliscedons 
        /// used 10 to add every 10 for better results since causes errors with timing if tried to go any faster
        /// update timer display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.addTime(0, 0, 0, 10);
            StopWatchTimer.Text = time.ToUniversalString();

        }
        /// <summary>
        /// Start button event handler. Starts up the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            //time = new Time2ss();
            timer1.Enabled = true;
        }
        /// <summary>
        /// Take current time2ss object and add it to current selected athlete time list
        /// display new time added onto output text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lap_Click(object sender, EventArgs e)
        {
            athletes[selectedIdx].addLap(time);
            displayLaps();
            //OutPut.AppendText( athletes[selectedIdx].GetLastLap().ToUniversalString() + Environment.NewLine);
        }
        /// <summary>
        /// Disable timer
        /// Take final time displayed and add it onto current athlete time list
        /// display new time added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            athletes[selectedIdx].addLap(time);
            displayLaps();
            
        }
        /// <summary>
        /// resets the timer object by setting time to a new time2ss object
        /// since set to new time2ss object will be set to 0:0:0:0
        /// display this new defualt time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Click(object sender, EventArgs e)
        {
            time = new Time2ss();
            StopWatchTimer.Text = time.ToUniversalString();
        }
        /// <summary>
        /// Records Button Event Handler.
        /// Creates a new Form 2 and passes form 1 athelte object onto Form2
        /// display laps in form 2 
        /// show form 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(athletes);
            athletes.Sort();
            foreach (Athlete a in athletes)
            {           
                displayLaps(a, f2);
            }
            f2.Show();

        }
        /// <summary>
        /// Will Serialize and save List of Athletes into the serialize file
        /// Must first have chosen a place to save objects to
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                formatter.Serialize(output, athletes);
            }
            catch (SerializationException)
            {
                MessageBox.Show("Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Open a save file dialogue to allow user to chose where to save the serializable objects to
        /// suffix should be a .txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFile_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using(SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;

                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName)){
                    MessageBox.Show("Invalid file Name", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                        SaveFile.Enabled = false;
                        OpenFile.Enabled = true;

                    }catch (IOException)
                    {
                        MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        /// <summary>
        /// Opens a choose file dialogue to choose the file to open
        /// if File is a serializable file with athletes list in them, then will open just fine otherwise will throw an error
        /// Upon succes, set the athletes to deserializable file and call displaysavedfile to display new athletes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog filechooser = new OpenFileDialog())
            {
                result = filechooser.ShowDialog();
                fileName = filechooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    Open.Enabled = false;
                    try
                    {
                        athletes = (List<Athlete>)reader.Deserialize(input);
                        displaySavedFile();
                    }
                    catch (SerializationException)
                    {
                        input?.Close();
                        OpenFile.Enabled = true;

                        MessageBox.Show("No Data in File", "File.Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }

            }
        }
        /// <summary>
        /// reset all text boxes to allow for smooth aggregation of new athletes from serialziable file
        /// </summary>
        public void reset()
        {
            AthleteName.ClearSelected();
            StopWatchTimer.Text = "00:00:00:000";
            OutPut.Clear();

        }
        /// <summary>
        /// display new athletes names in list box
        /// </summary>
        public void displaySavedFile()
        {
            foreach(Athlete a in athletes)
            {
                AthleteName.Items.Add(a);
            }

        }
        /// <summary>
        /// Ensure that all streams opened are closed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            try
            {
                output?.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot Close File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }
    }
}
