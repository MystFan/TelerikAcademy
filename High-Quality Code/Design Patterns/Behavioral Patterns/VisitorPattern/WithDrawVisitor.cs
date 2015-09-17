namespace VisitorPattern
{
    using System;

    public class WithDrawVisitor : IVisitor
    {
        private readonly decimal sum;
        public WithDrawVisitor(decimal sum)
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
            AccountValidator.ValidateWithDrawOperation(account, this.sum);

            account.Balance += this.sum;
        }
    }
}
