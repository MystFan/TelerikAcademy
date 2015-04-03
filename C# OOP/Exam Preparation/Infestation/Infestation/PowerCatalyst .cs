
namespace Infestation
{
    public class PowerCatalyst : Supplement
    {
        private const int CatalystPower = 3;
        private const int CatalystAggression = 0;
        private const int CatalystHealth = 0;
        public PowerCatalyst()
            : base(PowerCatalyst.CatalystHealth, PowerCatalyst.CatalystPower, PowerCatalyst.CatalystAggression)
        {

        }

        public override void ReactTo(ISupplement otherSupplement)
        {

        }
    }
}
