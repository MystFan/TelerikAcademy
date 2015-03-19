
namespace Accounts
{
    using System;
    public class Customer
    {
        private string name;
        public Customer(string name, CustomerType customerType)
        {
            this.Name = name;
            this.Type = customerType;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Customer name is too short");
                }
                this.name = value;
            }
        }

        public CustomerType Type { get; private set; }
    }
}
