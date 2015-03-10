using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calls
{
    public class Call
    {
        private string date;
        private string time;
        private string dialledPhoneNumber;
        private int duration;

        public Call(DateTime data, string dialledPhoneNumber, int duration)
        {
            this.Date = data.Date.Day.ToString() + " " + data.Month + " " + data.Year;
            this.Time = data.Hour.ToString() + " " + data.Minute + " " + data.Second;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }
        public string Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            private set
            {
                this.time = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            private set
            {
                this.dialledPhoneNumber = value;
            }
        }

        public int Duration 
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            } 
        }
    }
}
