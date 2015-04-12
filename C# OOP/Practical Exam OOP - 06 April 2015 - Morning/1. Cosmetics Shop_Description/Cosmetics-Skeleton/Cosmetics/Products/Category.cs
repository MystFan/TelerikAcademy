


namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    public class Category : ICategory
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 15;

        private string name;
        private ICollection<IProduct> cosmetics;

        public Category(string name)
        {
            this.Name = name;
            this.cosmetics = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Category name cannot be null or empty");
                Validator.CheckIfStringLengthIsValid(value, Category.MaxNameLength, Category.MinNameLength,
                    string.Format("Category name must be between {0} and {1} symbols long!", Category.MinNameLength, Category.MaxNameLength));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, "Cosmetics you try to add cannot be null");
            this.cosmetics.Add(cosmetics);
            this.cosmetics = this.cosmetics.OrderBy(c => c.Brand).ThenByDescending(c => c.Price).ToList();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, "Cosmetics you try to remove cannot be null");
            if (this.cosmetics.Any(p => p == cosmetics))
            {
                this.cosmetics.Remove(cosmetics);
            }
            else
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
        }

        public string Print()
        {
            StringBuilder categoryInfo = new StringBuilder();
            string result = String.Empty;
            string title = string.Format("{0} category - {1} {2} in total", this.Name, this.cosmetics.Count, this.cosmetics.Count == 1 ? "product" : "products");
            if (this.cosmetics.Count > 0)
            {
                categoryInfo.AppendLine(title);
                var products = this.cosmetics.ToList();
                for (int i = 0; i < products.Count; i++)
                {
                    categoryInfo.Append(products[i]);
                }
                result = categoryInfo.ToString().Substring(0, categoryInfo.Length - 2);
            }
            else
            {
                categoryInfo.Append(title);
                result = categoryInfo.ToString();
            }
            return result;
        }
    }
}
