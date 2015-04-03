
namespace Infestation
{
    public class Weapon : Supplement
    {
        public const int WeaponPower = 10;
        public const int WeaponAggression = 3;
        public const int WeaponHealth = 0;
        public Weapon(int healthEffect = 0, int powerEffect = 0, int aggressionEffect = 0)
            : base(healthEffect, powerEffect, aggressionEffect)
        {

        }

        public override void ReactTo(ISupplement otherSupplement)
        {

        }
    }
}
