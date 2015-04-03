using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        private int quantity;
        public Rock(Point position, int hitPoints)
            : base(position)
        {
            this.HitPoints = hitPoints;
            this.Type = ResourceType.Stone;
            this.Quantity = this.HitPoints;
        }
        public int Quantity 
        {
            get
            {
                return this.quantity;
            }
            private set
            {
                if (value > 0)
                {
                    this.quantity = value / 2;
                }
            }
        }

        public ResourceType Type { get; private set; }
    }
}
