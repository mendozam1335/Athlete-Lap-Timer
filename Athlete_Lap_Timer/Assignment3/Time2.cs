using System;
namespace Time2Library
{
    /* Class Time2 that contains hour, minute, second values
     contains function addTime that is able to addtime to an existing object of Time2
     Original class from the book*/
    [Serializable]
    public class Time2
    {
        private int hour;
        private int minute;
        private int second;

        public Time2(int hour = 0, int minute = 0, int second = 0)
        {
            SetTime(hour, minute, second);
        }

        public Time2(Time2 time) : this(time.hour, time.minute, time.second)
        {
        }

        public void SetTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Hour
        {
            get => hour;
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Hour)} must be 0-23");
                }

                hour = value;
            }
        }

        public int Minute
        {
            get => minute;
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Minute)} must be 0-59");
                }

                minute = value;
            }
        }

        public int Second
        {
            get => second;
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Second)} must be 0-59");
                }

                second = value;
            }
        }

        public string ToUniversalString() => $"{Hour:D2}:{Minute:D2}:{Second:D2}";

        public override string ToString() =>
            $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" + $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";

        public void addTime(int h, int m, int s)
        {
            int tempS = Second + s;
            int tempM = (tempS / 60) + Minute + m;
            int tempH = (tempM / 60) + Hour + h;

            Second = tempS % 60;
            Minute = tempM % 60;
            Hour = tempH % 12;
        }

        public void addTime(Time2 time)
        {
            int tempS = Second + time.Second;
            int tempM = (tempS / 60) + Minute + time.Minute;
            int tempH = (tempM / 60) + Hour + time.Hour;

            Second = tempS % 60;
            Minute = tempM % 60;
            Hour = tempH % 12;
        }
    }
}