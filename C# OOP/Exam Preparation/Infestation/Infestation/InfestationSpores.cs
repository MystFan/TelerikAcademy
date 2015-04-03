using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class InfestationSpores : Supplement
    {
        private const int InfestationSporesAggressionEffect = 20;
        private const int InfestationSporesPowerEffect = -1;
        public InfestationSpores()
            : base(0, InfestationSpores.InfestationSporesPowerEffect, InfestationSpores.InfestationSporesAggressionEffect)
        {

        }

        public override void ReactTo(ISupplement otherSupplement)
        {

        }
    }
}
