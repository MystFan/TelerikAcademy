using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class AggressionCatalyst : Supplement
    {
        private const int CatalystPower = 0;
        private const int CatalystAggression = 3;
        private const int CatalystHealth = 0;
        public AggressionCatalyst()
            : base(AggressionCatalyst.CatalystHealth, AggressionCatalyst.CatalystPower, AggressionCatalyst.CatalystAggression)
        {

        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            //if (otherSupplement is AggressionCatalyst)//.GetType().Name == "Weapon")
            //{
            //    AggressionCatalyst supplement = otherSupplement as AggressionCatalyst;
            //    supplement.AggressionEffect += CatalystAggression;
            //}
        }
    }
}
