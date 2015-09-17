namespace VisitorPattern
{
    public class LogVisitor : IVisitor
    {
        public void Visit(Account account)
        {
            System.Console.WriteLine(string.Format("{0}: (number: {1} balance: {2})", account.ownerName, account.number, account.Balance));
        }
    }
}
