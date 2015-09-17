namespace VisitorPattern
{
    using System;

    public class DepositVisitor : IVisitor
    {
        private readonly decimal sum;
        public DepositVisitor(decimal sum)
        {
            this.sum = sum;
        }

        public void Visit(Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException("Account cannot be null");
            }

            AccountValidator.ValidateNumber(account.number);

            account.Balance += this.sum;
        }
    }
}
