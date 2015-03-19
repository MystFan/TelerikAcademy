
namespace Accounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {

        }

        public override decimal CalculateInterestAmount(int months)
        {
            decimal result = 1;
            if (months > 0)
            {
                if (this.Customer.Type == CustomerType.Companies)
                {
                    if (months <= 12)
                    {
                        result = (this.InterestRate / 2) * months;
                    }
                    if (months > 12)
                    {
                        result = (this.InterestRate / 2) * 12;
                        result += (this.InterestRate) * (months - 12);
                    }
                }
                else if (this.Customer.Type == CustomerType.Individuals)
                {
                    if (months > 6)
                    {
                        result = (this.InterestRate / 2) * months;
                    }
                }
            }

            return result;
        }
    }
}
