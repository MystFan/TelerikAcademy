
using System;
namespace Accounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {

        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer.Type == CustomerType.Individuals)
            {
                months -= 3;
                if (months < 0)
                {
                    months = 0;
                }
            }
            else if (this.Customer.Type == CustomerType.Companies)
            {
                months -= 2;
                if (months < 0)
                {
                    months = 0;
                }
            }
            decimal result = (this.InterestRate * (decimal)months);
            return result;
        }
    }
}
