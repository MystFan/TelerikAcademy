using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class HealthCatalyst : Supplement
    {
        private const int CatalystPower = 0;
        private const int CatalystAggression = 0;
        private const int CatalystHealth = 3;
        public HealthCatalyst()
            : base(HealthCatalyst.CatalystHealth, HealthCatalyst.CatalystPower, HealthCatalyst.CatalystAggression)
        {

        }

        public override void ReactTo(ISupplement otherSupplement)
        {

        }
    }
}
