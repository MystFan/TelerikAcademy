
namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using RestaurantManager.Interfaces;
    using System.Text;
    public class Drink : Recipe, IDrink
    {
        private const int LimitTimeToPrepare = 20;
        private const int LimitCalories = 100;
        public Drink(string initName, decimal initPrice, int initCalories, int initQuantityPerServing, int initTimeToPrepare, bool initIsCarbonated)
            : base(initName, initPrice, initCalories, initQuantityPerServing, initTimeToPrepare)
        {
            this.IsCarbonated = initIsCarbonated;
        }

        public override int Calories
        {
            get
            {
                return base.Calories;
            }
            protected set
            {
                if (value > Drink.LimitCalories)
                {
                    throw new ArgumentException("Drink calories cannot be greater by 100");
                }
                base.Calories = value;
            }
        }

        public override int TimeToPrepare
        {
            get
            {
                return base.TimeToPrepare;
            }
            protected set
            {
                if (value > Drink.LimitTimeToPrepare)
                {
                    throw new ArgumentException("Drink time to prepare cannot be greater by 20");
                }
                base.TimeToPrepare = value;
            }
        }
        public bool IsCarbonated { get; private set; }
        
        public override MetricUnit Unit
        {
            get 
            { 
                return MetricUnit.Milliliters;
            }
        }

        public override string ToString()
        {
            StringBuilder drinkInfo = new StringBuilder();
            string title = string.Format("==  {0} == ${1:F2}", this.Name, this.Price);
            string serving = string.Format("Per serving: {0} {1}, {2} kcal", this.QuantityPerServing, "ml", this.Calories);
            string prepareInfo = string.Format("Ready in {0} minutes", this.TimeToPrepare);
            drinkInfo.AppendLine(title);
            drinkInfo.AppendLine(serving);
            drinkInfo.AppendLine(prepareInfo);
            drinkInfo.AppendLine(string.Format("Carbonated: {0}",this.IsCarbonated ? "yes" : "no"));
            return drinkInfo.ToString();
        }
    }
}
