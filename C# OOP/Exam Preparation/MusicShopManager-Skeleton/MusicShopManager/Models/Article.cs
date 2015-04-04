
namespace MusicShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MusicShopManager.Interfaces;
    public abstract class Article : IArticle
    {
        private string make;
        private string model;
        private decimal price;
        public Article(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }
        public string Make
        {
            get 
            {
                return this.make;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Article make string is null");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Article make string is empty string");
                }
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Article model string is null");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Article model string is empty string");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get 
            {
                return this.price;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Article price should be positiv value");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
