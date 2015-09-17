using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public class Account : IAccount
    {
        private FinancialInstitution institution;

        public Account(string name, string number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name { get; set; }

        public FinancialInstitution Institution
        {
            get { return this.institution; }
            set { this.institution = value; }
        }

        public string Number { get; set; }

        public decimal Money { get; set; }

        public void SendMoney(IAccount to, decimal sum)
        {
            this.Institution.Transfer(this, to, sum);
            this.Money -= sum;
        }

        public void SendToAll(decimal sum)
        {
            this.Institution.DepositToAll(this, sum);
        }

        public void ReciveMoney(decimal sum)
        {
            this.Money += sum;
        }
    }
}
