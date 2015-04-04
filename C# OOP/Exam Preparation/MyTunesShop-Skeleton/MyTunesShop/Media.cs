using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTunesShop
{
    public abstract class Media : IMedia
    {
        private string title;
        private decimal price;

        public Media(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;
        }
        public string Title
        {
            get 
            {
                return this.title;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Media title is null or empty string");
                }
                this.title = value;
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
                    throw new ArgumentException("Media price is less then zaro");
                }
                this.price = value;
            }
        }
    }
}
