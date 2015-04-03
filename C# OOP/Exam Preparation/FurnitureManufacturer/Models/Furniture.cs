
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using FurnitureManufacturer.Interfaces;
    public abstract class Furniture : IFurniture
    {
        protected const int ModelNameLenght = 3;
        protected string model;
        protected string material;
        protected decimal price;
        protected decimal height;

        protected Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }
        public string Model
        {
            get 
            {
                return this.model;
            }
            protected set
            {
                if (value.Length < ModelNameLenght)
                {
                    throw new ArgumentException(string.Format("Model string must be at least {0} characters", ModelNameLenght));
                }
                if (value == null)
                {
                    throw new ArgumentNullException("Model string is null");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Model string is empty");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get 
            {
                return this.material; 
            }
            protected set
            {
                this.material = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Furniture price must be greater by 0");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get 
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Furniture height must be greater by 0");
                }
                this.height = value;
            }
        }

    }
}
