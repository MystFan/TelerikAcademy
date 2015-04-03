using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : MovingObject, IFighter, IGatherer
    {
        private string name;
        private const int NinjaHitPoints = 1;
        public Ninja(string name, Point position, int owner)
            : base(position, owner)
        {
            this.Name = name;
            this.HitPoints = Ninja.NinjaHitPoints;
            this.DefensePoints = int.MaxValue;
        }
        public int AttackPoints { get; private set; }

        public int DefensePoints { get; private set; }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var attackableTargets = availableTargets.Where(target => target.Owner > 0 && target.Owner != this.Owner);
            var highestHitPoints  = attackableTargets.Max(t => t.HitPoints);
            int index = availableTargets.FindIndex(item => item.HitPoints == highestHitPoints);
            return index;
        }

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
                    throw new ArgumentNullException("Ninja name is null or empty string");
                }
                this.name = value;
            }
        }
        
        public bool TryGather(IResource resource)
        {
            bool isResourseCollected = false;
            switch (resource.Type)
            {
                case ResourceType.Lumber:
                    this.AttackPoints += resource.Quantity;
                    isResourseCollected = true;
                    break;
                case ResourceType.Stone:
                    this.AttackPoints += (resource.Quantity * 2);
                    isResourseCollected = true;
                    break;
                default:
                    return isResourseCollected;
            }
            return isResourseCollected;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Name;
        }
    }
}
