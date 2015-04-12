using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Extended.Specialties;
    public class WolfRaider : Creature
    {
        private const int BaseAttack = 8;
        private const int BaseDefense = 5;
        private const int BaseHealthPoints = 10;
        private const decimal BaseDamage = 3.5m;
        public WolfRaider()
            : base(BaseAttack, BaseDefense, BaseHealthPoints, BaseDamage)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}
