using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : IPilot
    {
        private string name = String.Empty;
        private List<IMachine> mashines;
        public Pilot(string name)
        {
            this.Name = name;
            this.mashines = new List<IMachine>();
        }
        public string Name
        {
            get 
            {
                return this.name; 
            }
            private set
            {
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.mashines.Add(machine);
            this.mashines = this.mashines.OrderBy(p => p.HealthPoints).ThenBy(p => p.Name).ToList();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            string titleReport = string.Empty;
            if (this.mashines.Count == 0)
            {
                titleReport = this.Name + " - no machines";
                sb.Append(titleReport);
            }
            else if (this.mashines.Count > 0)
            {
                titleReport = this.Name + " - " + this.mashines.Count + " " + (this.mashines.Count == 1 ? "mashine" : "mashines");
                sb.AppendLine(titleReport);
            }
           // sb.AppendLine(titleReport);

            for (int i = 0; i < this.mashines.Count; i++)
            {
                if (i != this.mashines.Count - 1)
                {
                    sb.AppendLine(this.mashines[i].ToString());
                }
                else
                {
                    sb.Append(this.mashines[i].ToString());
                }
            }

            string reports = sb.ToString();
            return reports;
        }
    }
}
