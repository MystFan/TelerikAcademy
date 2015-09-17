namespace MediatorPattern
{
    using System;
    using System.Collections.Generic;

    public class MoneyTransfersAgency : FinancialInstitution
    {
        private readonly Dictionary<string, IAccount> accounts = new Dictionary<string, IAccount>();

        public override void Register(IAccount account)
        {
            if (account == null)
            {
                throw new ArgumentNullException("Cannot register null account");
            }

            this.accounts.Add(account.Number, account);
            account.Institution = this;
        }

        public override void Transfer(IAccount from, IAccount to, decimal sum)
        {
            if (this.accounts[from.Number] == null || this.accounts[to.Number] == null)
            {
                throw new ArgumentNullException("Some of the accounts not exist");
            }

            if (this.accounts[from.Number].Money < sum)
            {
                throw new ArgumentNullException("Not enough money");
            }

            var receiverAccount = this.accounts[to.Number];

            receiverAccount.ReciveMoney(sum);
        }

        public override void DepositToAll(IAccount account, decimal sum)
        {
            foreach (var acc in this.accounts)
            {
                if (acc.Key != account.Number)
                {
                    account.SendMoney(acc.Value, sum);
                }
            }
        }
    }
}
