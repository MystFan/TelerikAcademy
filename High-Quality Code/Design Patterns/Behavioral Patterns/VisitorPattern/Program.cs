namespace VisitorPattern
{
    public class Program
    {
        public static void Main()
        {
            Bank bank = new Bank();
            Account jhonAccount = new Account("0000121", "Jhon Doe", 10000m);
            Account fooAccount = new Account("0000169", "Foo", 2000m);

            bank.AddAccount(jhonAccount);
            bank.AddAccount(fooAccount);

            jhonAccount.Accept(new DepositVisitor(400m));

            bank.Accept(new RemunerationAccountVisitor());
            bank.Accept(new WithDrawVisitor(100m));
            bank.Accept(new LogVisitor());
        }
    }
}
