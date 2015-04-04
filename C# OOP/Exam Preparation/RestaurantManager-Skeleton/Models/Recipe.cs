

namespace RestaurantManager.Models
{
    using System;
    using RestaurantManager.Interfaces;
    public abstract class Recipe :IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;

        public Recipe(string initName, decimal initPrice, int initCalories, int initQuantityPerServing, int initTimeToPrepare)
        {
            this.Name = initName;
            this.Price = initPrice;
            this.Calories = initCalories;
            this.QuantityPerServing = initQuantityPerServing;
            this.TimeToPrepare = initTimeToPrepare;
        }
        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name is required");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Recipe name cannot be empty string");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price must be positive");
                }
                this.price = value;
            }
        }

        public virtual int Calories
        {
            get 
            {
                return this.calories;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The calories must be positive");
                }
                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get 
            {
                return this.quantityPerServing;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The quantity per serving must be positive");
                }
                this.quantityPerServing = value;
            }
        }

        public abstract MetricUnit Unit { get;}

        public virtual int TimeToPrepare
        {
            get 
            {
                return this.timeToPrepare;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The time to prepare must be positive");
                }
                this.timeToPrepare = value;
            }
        }
    }
}
