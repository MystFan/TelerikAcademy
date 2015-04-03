using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : MovingObject,IFighter, IGatherer
    {
        private const int GiantOwner = 0;
        private const int GiantHitPoints = 200;
        private const int GiantAttackPoints = 150;
        private const int GiantDefensePoints = 80;
        private string name;
        private bool isStoneCollected;
        public Giant(string name, Point position)
            :base(position, Giant.GiantOwner)
        {
            this.Name = name;
            this.AttackPoints = Giant.GiantAttackPoints;
            this.DefensePoints = Giant.GiantDefensePoints;
            this.HitPoints = Giant.GiantHitPoints;
            this.isStoneCollected = false;
        }


        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner > 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (!this.isStoneCollected)
            {
                if (resource.Type == ResourceType.Stone)
                {
                    this.AttackPoints += 100;
                    return true;//TODO is that way?
                }
            }
            return false;
        }

        public int AttackPoints { get; private set; }

        public int DefensePoints { get; private set; }
       
        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Giant name is null or empty", "value");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Name;
        }
    }
}
