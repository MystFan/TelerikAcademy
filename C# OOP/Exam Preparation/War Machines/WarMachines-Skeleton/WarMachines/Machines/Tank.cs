using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;
namespace WarMachines.Machines
{
    public class Tank : Machine,ITank
    {
        private bool defenseMode;
        public Tank(string name,double attackPoints,double defensePoints)
            : base(name, attackPoints, defensePoints)
        {
            this.defenseMode = true;
            base.HealthPoints = 100;
            base.AttackPoints -= 40;
            base.DefensePoints += 30;
        }
            
        public bool DefenseMode
        {
            get 
            {
                return this.defenseMode;
            }
            set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefenseMode = false;
            }
            else
            {
                this.defenseMode = true;
            }
        }

        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(" *Defense: " + (this.defenseMode ? "ON" : "OFF"));
            string tankString = sb.ToString();
            return tankString;
        }
    }
}
