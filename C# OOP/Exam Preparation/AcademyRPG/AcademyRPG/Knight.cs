using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Knight : MovingObject, IFighter
    {
        private const int KnightHitPoints = 100;
        private const int KnightAttackPoints = 100;
        private const int KnightDefensePoints = 100;
        private int attackPoints;
        private int defensePoints;
        private string name;
        public Knight(string name, Point position, int owner)
            : base(position, owner)
        {
            this.Name = name;
            this.HitPoints = Knight.KnightHitPoints;
            this.AttackPoints = Knight.KnightAttackPoints;
            this.DefensePoints = Knight.KnightDefensePoints;
        }
        public int AttackPoints
        {
            get 
            {
                return this.attackPoints; 
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Knight attack points should be positiv integer");
                }
                this.attackPoints = value;
            }
        }

        public int DefensePoints
        {
            get 
            {
                return this.defensePoints; 
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Knight defense points should be positiv integer");
                }
                this.defensePoints = value;
            }
        }

        public virtual int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner > 0 && availableTargets[i].Owner != this.Owner)
                {
                    return i;
                }
            }
            return -1;
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
                    throw new ArgumentException("Knight name is null or empty", "value");
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
