
namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;

    public class Goblin : Creature
    {
        private const int BaseAttack = 4;
        private const int BaseDefense = 2;
        private const int BaseHealthPoints = 5;
        private const decimal BaseDamage = 1.5m;
        public Goblin()
            : base(BaseAttack, BaseDefense, BaseHealthPoints, BaseDamage)
        {

        }
    }
}
