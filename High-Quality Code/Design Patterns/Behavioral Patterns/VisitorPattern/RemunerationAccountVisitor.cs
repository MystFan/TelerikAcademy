namespace VisitorPattern
{
    using System; 

    public class RemunerationAccountVisitor : IVisitor
    {
        public void Visit(Account account)
        {
            AccountValidator.ValidateNumber(account.number);

            var interest = 6;
            account.Balance += ((account.Balance / 100) * interest);
        }
    }
}
