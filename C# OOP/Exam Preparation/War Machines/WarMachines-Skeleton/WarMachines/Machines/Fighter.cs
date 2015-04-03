using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine,IFighter
    {
        private bool stealthMode;
        public Fighter(string name,double attackPoints,double defencePoints)
            : base(name, attackPoints, defencePoints)
        {
            base.HealthPoints = 200;
            this.StealthMode = true;
        }
        public bool StealthMode
        {
            get 
            {
                return this.stealthMode;
            }
            private set
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (this.StealthMode)
            {
                this.StealthMode = false;
            }
            else
            {
                this.StealthMode = true;
            }
        }
        public override void Attack(string target)
        {
            base.Targets.Add(target);
        }
        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(" *Stealth: " + (this.stealthMode ? "ON" : "OFF"));
            string fighterString = sb.ToString();
            return fighterString;
        }
    }
}
