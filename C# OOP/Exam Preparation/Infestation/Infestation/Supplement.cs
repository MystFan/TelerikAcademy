
namespace Infestation
{
    using System;
    public abstract class Supplement : ISupplement
    {
        public Supplement(int healthEffect,int powerEffect,int aggressionEffect)
        {
            this.HealthEffect = healthEffect;
            this.PowerEffect = powerEffect;
            this.AggressionEffect = aggressionEffect;
        }
        public virtual void ReactTo(ISupplement otherSupplement)
        {

        }

        public int PowerEffect { get; protected set; }

        public int HealthEffect { get; protected set; }

        public int AggressionEffect { get; protected set; }
        
    }
}
