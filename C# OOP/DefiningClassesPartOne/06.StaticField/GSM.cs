﻿
namespace _06.StaticField
{
    using System;
    using System.Text;
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        public static string[] IPhone4S = new string[] { "IPhone 4S", "Apple", "700" };

        public GSM(string model, string manufacturer, decimal price = 0, string owner = "None")
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
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
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Owner name can not be null");
                }
                if (value == "")
                {
                    throw new ArgumentException("Owner name can not be empty string");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Owner name should be more than 2 symbols");
                }
                this.owner = value;
            }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Mobile phone info");
            info.AppendLine(" *Model: " + this.Model);
            info.AppendLine(" *Manufacturer: " + this.Manufacturer);
            info.AppendLine(" *Price: " + this.Price);
            if (this.Owner == "")
            {
                info.AppendLine(" *Owner: " + this.Owner);
            }
            else
            {
                info.AppendLine(" *Owner: None");
            }
            return info.ToString();
        }
    }
}
