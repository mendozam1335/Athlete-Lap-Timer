using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time2Library;

namespace Assignment3
{
    [Serializable]
    public class Athlete : IComparable
    {
        private string firstName;
        private string lastName;
        private List<Time2ss> time;
        private Time2ss fastestLap;
        

        public Athlete(string fName = "", string lName = "")
        {
            FirstName = fName;
            LastName = lName;
            Time = new List<Time2ss>();
            fastestLap = new Time2ss();
        }
        /* Attributes for name and time do not need to be checked since name can literally be any string and Time is already checked inside the class time2ss
         FastestLap also does not need to be checked as it will defualt to 0:0:0:00 if no lap is taken yet*/
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public List<Time2ss> Time { get => time; set => time = value; }
        public Time2ss FastestLap
        {
            get => fastestLap;
            set
            {
                Time.Sort();
                fastestLap = time[0];
            }
        }
        /// <summary>This method will return the first name plus the last name
        /// </summaryThis>
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        /// <summary>
        /// This method will take an integer and return the Time2ss object 
        /// </summary>
        /// <param name="idx"> Integer</param>
        /// <returns> Time2ss object at index idx</returns>
        public Time2ss GetLap(int idx)
        {
            return Time[idx];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The last lap appended onto time</returns>
        public Time2ss GetLastLap()
        {
            return Time.Last();
        }
        /// <summary>
        /// Take a Time2ss object and append to Time
        /// set the FastestLap using Paramater 
        /// </summary>
        /// <param name="t">Time2ss object</param>
        public void addLap(Time2ss t)
        {

            Time.Add(new Time2ss(t.Hour, t.Minute, t.Second, t.Milliseconds));
            FastestLap = GetLastLap();
        }

        public int sortByName(string name1, string name2)
        {
            return name1.CompareTo(name2);
        }
        /// <summary>
        /// overide ComparTo to conform to Icomparable
        /// will compare the athletes fastest lap by converting fastest lap to a string
        /// </summary>
        /// <param name="obj">Object must be an Athlete object</param>
        /// <returns>An Int based on comparison</returns>
        int IComparable.CompareTo(object obj)
        {
            Athlete t = (Athlete)obj;
            return String.Compare(this.FastestLap.ToUniversalString(), t.FastestLap.ToUniversalString());
            //throw new NotImplementedException();
        }
    }
}
