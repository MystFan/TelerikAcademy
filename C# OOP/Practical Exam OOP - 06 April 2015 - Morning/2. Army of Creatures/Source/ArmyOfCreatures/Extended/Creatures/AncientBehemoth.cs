
namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;
    public class AncientBehemoth : Creature
    {
        private const int BaseAttack = 19;
        private const int BaseDefense = 19;
        private const int BaseHealthPoints = 300;
        private const decimal BaseDamage = 40m;

        public AncientBehemoth()
            : base(BaseAttack, BaseDefense, BaseHealthPoints, BaseDamage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
        }
    }
}
