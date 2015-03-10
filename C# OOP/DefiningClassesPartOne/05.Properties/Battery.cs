using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Properties
{
    public class Battery
    {
        private string model;
        private short hoursIdle;
        private short hoursTalk;
        private BatteryType type;
        public Battery(string model, BatteryType type)
        {
            this.Model = model;
            this.Type = type;
        }
        public string Model 
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            } 
        }
        public BatteryType Type 
        {
            get
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }
        public short HoursIdle 
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }
        public short HoursTalk 
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
    }

    public enum BatteryType
    {
        Li_lon,
        Li_Poly,
        NiMH,
        NiCd,
        None
    }
}
