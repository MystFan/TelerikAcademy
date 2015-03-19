
namespace Accounts
{
    public class DepositAccount : Account, IDraw
    {
        public DepositAccount(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {

        }

        public decimal DrawMoney(decimal money)
        {
            this.Balance -= money;
            return money;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            decimal result = 1;
            if (this.Balance > 1000)
            {
                result = (this.InterestRate * (decimal)months);
            }
            return result;
        }
    }
}
