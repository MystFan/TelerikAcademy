

namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    public abstract class Product : IProduct
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 10;
        private const int MinBrandLength = 2;
        private const int MaxBrandLength = 10;
        private string name;
        private string brand;
        private decimal price;

        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Product name cannot be null or empty string");
                Validator.CheckIfStringLengthIsValid(value, Product.MaxNameLength, Product.MinNameLength,
                    string.Format("Product name must be between {0} and {1} symbols long!", Product.MinNameLength, Product.MaxNameLength));
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Product brand cannot be null or empty");
                Validator.CheckIfStringLengthIsValid(value, Product.MaxBrandLength, Product.MinBrandLength
                    , string.Format("Product brand must be between {0} and {1} symbols long!", Product.MinBrandLength, Product.MaxBrandLength));
                this.brand = value;
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
                    throw new ArgumentOutOfRangeException("Product price cannot be negativ value");
                }
                this.price = value;
            }
        }

        public GenderType Gender { get; private set; }


        public string Print()
        {
            StringBuilder productInfo = new StringBuilder();
            string title = string.Format("- {0} - {1}:", this.Brand, this.Name);
            string price = string.Format("  * Price: ${0:F2}", this.Price);
            string gender = string.Format("  * For gender: {0}", this.Gender.ToString());
            productInfo.AppendLine(title);
            productInfo.AppendLine(price);
            productInfo.AppendLine(gender);
            return productInfo.ToString();
        }
    }
}
