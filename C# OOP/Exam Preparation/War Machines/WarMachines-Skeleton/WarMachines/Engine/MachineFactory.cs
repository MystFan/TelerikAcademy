namespace WarMachines.Engine
{
    using System.Collections.Generic;
    using System.Linq;
    using WarMachines.Interfaces;
    using WarMachines.Machines;
    using System;
    public class MachineFactory : IMachineFactory
    {
        private List<IPilot> pilots;
        private List<IMachine> mashines;
        public MachineFactory()
        {
            this.pilots = new List<IPilot>();
            this.mashines = new List<IMachine>();
        }
        public IPilot HirePilot(string name)
        {
            if (!pilots.Any(p => p.Name == name))
            {
                IPilot pilot = new Pilot(name);
                this.pilots.Add(pilot);
                return pilot;
            }
            else
            {
                throw new ArgumentException("Pilot name should be unique");
            }
            
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (!this.mashines.Any(m => m.Name == name))
            {
                ITank tank = new Tank(name, attackPoints, defensePoints);
                this.mashines.Add(tank);
                return tank;
            }
            else
            {
                throw new ArgumentException("Tank name should be unique");
            }
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            if (!this.mashines.Any(m => m.Name == name))
            {
                IFighter fighter = new Fighter(name, attackPoints, defensePoints);
                this.mashines.Add(fighter);
                return fighter;
            }
            else
            {
                throw new ArgumentException("Tank name should be unique");
            }
        }
    }
}
