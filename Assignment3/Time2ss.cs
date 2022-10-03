using System;

namespace Time2Library
{
    /* Class of Time2ss that derives from Time2
      Adds milliseconds as a new param.
      Everything else is essentially derived from Time2 except for the addTime function and Millisecond paramater*/
    [Serializable]
    public class Time2ss : Time2, IComparable
    {
        private int milliseconds;

        // Constructor that calls base constructor to do part of the work and initiales milliseconds
        public Time2ss(int hour = 0, int minutes = 0, int seconds = 0, int milliseconds = 0) : base(hour, minutes, seconds)
        {
            Milliseconds = milliseconds;
        }
        
        // Construtor that takes Object of Time2ss and passes values to constructor above
        public Time2ss(Time2ss time2Ss) : this(time2Ss.Hour, time2Ss.Minute, time2Ss.Second, time2Ss.Milliseconds)
        {
            
        }

        /* Parameter for Milliseconds that returns milliseconds and checks to see if number passes is within range of 0 to 999*/
        public int Milliseconds
        {
            get => milliseconds;
            set
            {
                if (value < 0 || value > 999)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Minute)} must be 0-999");
                }

                milliseconds = value;
            }
        }

        public string ToUniversalString() => $"{base.ToUniversalString()}:{Milliseconds:D2}";
        public override string ToString() =>
            $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" + $"{Minute:D2}:{Second:D2}:{Milliseconds:D2} {(Hour < 12 ? "AM" : "PM")}";

        /* Function to add time to current object called.
         If millisecond, second, minute or hour goes above their respective threshold, will simply roll over to next highest 
         holder.
         Example if s = 90, then place 30 as seconds and add 1 to minutes
         Calls base function to do part of the work*/
        public void addTime(int h, int m, int s, int ms)
        {
            int tempMS = Milliseconds + ms;
            s += (tempMS / 1000);
            base.addTime(h,m,s);
            Milliseconds = tempMS % 1000;
        }
        
        // Overloaded addTime function that takes in Object of Time2ss as param
        // Exactly same as addTime function above
        // Calls base addtime to do part of the work
        public void addTime(Time2ss time2Ss)
        {
            int tempH = time2Ss.Hour;
            int tempM = time2Ss.Minute;
            int tempS = time2Ss.Second;
            int tempMS = Milliseconds + time2Ss.Milliseconds;
            tempS += (tempMS / 1000);
            base.addTime(tempH, tempM, tempS);
            Milliseconds = tempMS % 1000;
        }

        int IComparable.CompareTo(object obj)
        {
            Time2ss t = (Time2ss)obj;
            return String.Compare(this.ToUniversalString(), t.ToUniversalString());
            //throw new NotImplementedException();
        }
    }
}