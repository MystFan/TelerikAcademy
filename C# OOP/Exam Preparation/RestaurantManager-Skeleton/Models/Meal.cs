

namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using RestaurantManager.Interfaces;
    using System.Text;
    public abstract class Meal : Recipe, IMeal
    {
        public Meal(string initName, decimal initPrice, int initCalories, int initQuantityPerServing, int initTimeToPrepare, bool initIsVegan)
            : base(initName, initPrice, initCalories, initQuantityPerServing, initTimeToPrepare)
        {
            this.IsVegan = initIsVegan;
        }
        public bool IsVegan { get; protected set; }
        public virtual void ToggleVegan()
        {
            if (this.IsVegan)
            {
                this.IsVegan = false;
            }
            else
            {
                this.IsVegan = true;
            }
        }

        public override MetricUnit Unit 
        { 
            get 
            { 
                return MetricUnit.Grams; 
            } 
        }

        public override string ToString()
        {
            StringBuilder mealInfo = new StringBuilder();
            string title = string.Format("{0}==  {1} == ${2:F2}",this.IsVegan ? "[VEGAN] ": "", this.Name, this.Price);
            string serving = string.Format("Per serving: {0} {1}, {2} kcal", this.QuantityPerServing, this is IDrink? "ml" : "g", this.Calories);
            string prepareInfo = string.Format("Ready in {0} minutes", this.TimeToPrepare);
            mealInfo.AppendLine(title);
            mealInfo.AppendLine(serving);
            mealInfo.AppendLine(prepareInfo);
            return mealInfo.ToString();
        }
    }
}
