


namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    public class Shampoo : Product, IShampoo
    {
        private uint millilitres;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price * milliliters, gender)
        {
            this.Milliliters = milliliters;
        }
        public uint Milliliters
        {
            get 
            {
                return this.millilitres;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Shampoo milliliters cannot be negativ value");
                }
                this.millilitres = value;
            }
        }

        public UsageType Usage
        {
            get;
            private set;
        }

        public override string ToString()
        {
            StringBuilder shampooInfo = new StringBuilder();
            string quatity = string.Format("  * Quantity: {0} ml", this.Milliliters);
            string usage = string.Format("  * Usage: {0}", this.Usage.ToString());
            shampooInfo.Append(base.Print());

            shampooInfo.AppendLine(quatity);
            shampooInfo.AppendLine(usage);
            return shampooInfo.ToString();

        }
    }
}
