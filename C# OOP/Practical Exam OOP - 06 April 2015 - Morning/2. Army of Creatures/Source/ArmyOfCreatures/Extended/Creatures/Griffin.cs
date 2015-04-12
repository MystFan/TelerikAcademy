using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Extended.Specialties;
    public class Griffin : Creature
    {
        private const int BaseAttack = 8;
        private const int BaseDefense = 8;
        private const int BaseHealthPoints = 25;
        private const decimal BaseDamage = 4.5m;
        public Griffin()
            : base(BaseAttack, BaseDefense, BaseHealthPoints, BaseDamage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
            this.AddSpecialty(new AddDefenseWhenSkip(3));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
