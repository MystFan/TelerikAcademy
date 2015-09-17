namespace MediatorPattern
{
    using System;

    class Program
    {
        static void Main()
        {
            MoneyTransfersAgency agency = new MoneyTransfersAgency();

            Account firstAccount = new Account("Jhon Account", "000123");
            agency.Register(firstAccount);

            Account secondAccount = new Account("Merry Acount", "000122");
            agency.Register(secondAccount);

            Account thirdAccount = new Account("Pesho Account", "000120");
            agency.Register(thirdAccount);

            firstAccount.Money = 1000m;
            secondAccount.Money = 1200m;
            thirdAccount.Money = 2000m;

            firstAccount.SendToAll(10m);
            firstAccount.SendMoney(secondAccount, 100);
            secondAccount.SendMoney(thirdAccount, 50);

            Console.WriteLine(firstAccount.Name + ": " + firstAccount.Money);
            Console.WriteLine(secondAccount.Name + ": " + secondAccount.Money);
            Console.WriteLine(thirdAccount.Name + ": " + thirdAccount.Money);
        }
    }
}
