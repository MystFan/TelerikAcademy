using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;
namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {
        protected string name;
        protected IPilot pilot;
        protected double healthPoints;
        protected double defensePoints;
        protected double attackPoints;
        protected IList<string> targets;
        protected Machine(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.Targets = new List<string>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Machine name is mandatory");
                }
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Pilot can not be null");
                }
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get 
            {
                return this.attackPoints;
            }
            protected set
            { 
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get 
            {
                return this.defensePoints;
            }
            protected set 
            { 
                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get 
            {
                return this.targets; 
            }
            protected set
            {
                this.targets = value;
            }
        }

        public virtual void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("- " + this.Name);
            sb.AppendLine(" *Type: " + this.GetType().Name);
            sb.AppendLine(" *Health: " + this.HealthPoints);
            sb.AppendLine(" *Attack: " + this.AttackPoints);
            sb.AppendLine(" *Defense: " + this.DefensePoints);
            sb.AppendLine(" *Targets: " + (this.targets.Count > 0 ? string.Join(",", this.targets) : "None"));

            string machineString = sb.ToString();
            return machineString;
        }
    }
}
