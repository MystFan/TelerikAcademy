using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Specialties;
    using System.Globalization;
    public class AddAttackWhenSkip : Specialty
    {
        private int attackToAdd;

        public AddAttackWhenSkip(int attackToAdd)
        {
            this.AttackToAdd = attackToAdd;
        }

        public int AttackToAdd 
        {
            get
            {
                return this.attackToAdd;
            }
            private set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("defenseToAdd", "defenseToAdd should be between 1 and 20, inclusive");
                }
                this.attackToAdd = value;
            }
        }
        public override void ApplyOnSkip(Logic.Battles.ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.attackToAdd;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.attackToAdd);
        }
    }
}
