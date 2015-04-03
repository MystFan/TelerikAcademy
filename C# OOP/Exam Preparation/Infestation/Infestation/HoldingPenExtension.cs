using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class HoldingPenExtension : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            Unit unit = base.GetUnit(commandWords[2]);
            switch (commandWords[1])
            {
                case "Weapon": AddWeaponSupplement(unit);
                    break;
                case "AggressionCatalyst":
                    unit.AddSupplement(new AggressionCatalyst());
                    break;
                case "HealthCatalyst":
                    unit.AddSupplement(new HealthCatalyst());
                    break;
                case "PowerCatalyst":
                    unit.AddSupplement(new PowerCatalyst());
                    break;
                case "InfestationSpores":
                    unit.AddSupplement(new InfestationSpores());
                    break;
                default:
                    break;
            }
        }
        private void AddWeaponSupplement(Unit unit)
        {
            Weapon weapon = null;
            if (unit is Marine)
            {
                weapon = new Weapon(Weapon.WeaponHealth, Weapon.WeaponPower, Weapon.WeaponAggression);
            }
            else
            {
                weapon = new Weapon();
            }
            unit.AddSupplement(weapon);
        }
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Parasite":
                    Parasite parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                case "Tank":
                    Tank tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Queen":
                    Queen queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                case "Marine":
                    Marine marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                default: base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
            
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    Unit targetUnit = this.GetUnit(interaction.TargetUnit);
                    targetUnit.AddSupplement(new InfestationSpores());
                    break;
                default: base.ProcessSingleInteraction(interaction);
                    break;
            }
        }
    }
}
