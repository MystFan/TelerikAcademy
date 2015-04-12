
namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Extended.Specialties;
    public class CyclopsKing : Creature
    {
        private const int BaseAttack = 17;
        private const int BaseDefense = 13;
        private const int BaseHealthPoints = 70;
        private const decimal BaseDamage = 18m;
        public CyclopsKing()
            : base(BaseAttack, BaseDefense, BaseHealthPoints, BaseDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
