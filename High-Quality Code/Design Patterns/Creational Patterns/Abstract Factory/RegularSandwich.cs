namespace Abstract_Factory
{
    using System;
    using System.Collections.Generic;
    using Abstract_Factory.Contracts;

    public class RegularSandwich : ISandwich
    {
        private List<string> ingredients;
        private string garnish;

        public RegularSandwich(List<string> ingredients, string garnish)
        {
            this.Ingredients = ingredients;
            this.Garnish = garnish;
        }

        public List<string> Ingredients
        {
            get
            {
                return new List<string>(this.ingredients);
            }

            private set
            {
                this.ingredients = value;
            }
        }

        public string Garnish
        {
            get 
            {
                return this.garnish;
            }

            private set
            {
                this.garnish = value;
            }
        }

        public bool HasGarnish()
        {
            if (string.IsNullOrWhiteSpace(this.Garnish))
            {
                return false;
            }

            return true;
        }
    }
}
