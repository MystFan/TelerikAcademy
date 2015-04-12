
namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    public class Toothpaste : Product, IToothpaste
    {
        private string ingredients;
        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.Ingredients = SetIngredients(ingredients);
        }
        public string Ingredients
        {
            get
            {
                return this.ingredients;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Ingredients string cannot be null or empty");
                this.ingredients = value;
            }
        }

        public override string ToString()
        {
            StringBuilder toothpasteInfo = new StringBuilder();
            string ingredientsString = string.Format("  * Ingredients: {0}", this.ingredients);
            toothpasteInfo.Append(base.Print());
            toothpasteInfo.AppendLine(ingredientsString);
            return toothpasteInfo.ToString();
        }
        private string SetIngredients(IList<string> ingredients)
        {
            Validator.CheckIfNull(ingredients, "Collection of ingredients cannot be null");
            string initialIngredients = string.Join(", ", ingredients);
            return initialIngredients;
        }
    }
}
