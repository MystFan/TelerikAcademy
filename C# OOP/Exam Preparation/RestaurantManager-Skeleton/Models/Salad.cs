
namespace RestaurantManager.Models
{
    using System;
    using RestaurantManager.Interfaces;
    using System.Text;
    public class Salad : Meal, ISalad
    {
        private const bool SaladIsVegan = true;
        public Salad(string initName, decimal initPrice, int initCalories, int initQuantityPerServing, int initTimeToPrepare, bool initContainsPasta)
            : base(initName, initPrice, initCalories, initQuantityPerServing, initTimeToPrepare, Salad.SaladIsVegan)
        {
            this.ContainsPasta = initContainsPasta;
        }

        public override void ToggleVegan()
        {
            base.IsVegan = true;
        }
        public bool ContainsPasta { get; private set; }

        public override string ToString()
        {
            StringBuilder saladInfo = new StringBuilder();
            saladInfo.Append(base.ToString());
            saladInfo.AppendLine(string.Format("Contains pasta: {0}", this.ContainsPasta ? "yes" : "no"));
            return saladInfo.ToString();
        }
    }
}
