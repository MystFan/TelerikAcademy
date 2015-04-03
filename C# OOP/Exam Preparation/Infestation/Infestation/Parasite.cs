
namespace Infestation
{
    using System.Collections.Generic;
    using System.Linq;
    public class Parasite : Unit
    {
        private const int ParasitePower = 1;
        private const int ParasiteAggression = 1;
        private const int ParasiteHealth = 1;
        public Parasite(string id)
            : base(id, UnitClassification.Biological, Parasite.ParasiteHealth, Parasite.ParasitePower, Parasite.ParasiteAggression)
        {

        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }
        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, int.MaxValue, 0, 0);

            foreach (var unit in attackableUnits)
            {
                if (unit.Health < optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }

            return optimalAttackableUnit;
        }
        protected override bool CanAttackUnit(UnitInfo unit)
        {
            bool attackUnit = true;
            if (this.Id == unit.Id)
            {
                attackUnit = false;
            }
            if (unit.UnitClassification != this.UnitClassification)
            {
                attackUnit = false;
            }
            return attackUnit;
        }
    }
}
