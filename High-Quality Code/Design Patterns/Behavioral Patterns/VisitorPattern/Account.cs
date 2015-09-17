namespace VisitorPattern
{
    using System;

    public class Account
    {
        public readonly string number;
        public readonly string ownerName;
        private decimal balance;

        public Account(string number, string name, decimal balance, bool isSavingAccount = false)
        {
            this.number = number;
            this.ownerName = name;
            this.balance = balance;
            this.IsSavingAccount = isSavingAccount;
        }

        public bool IsSavingAccount { get; set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
