using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Bank
    {
        private IList<Account> accounts;

        public Bank()
        {
            this.Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            if (account == null)
            {
                throw new ArgumentException("Account try to add is null");
            }

            this.accounts.Add(account);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var account in this.accounts)
            {
                account.Accept(visitor);
            }
        }

        public IList<Account> Accounts
        {
            get
            {
                return new List<Account>(this.accounts);
            }

            set
            {
                this.accounts = value;
            }
        }
    }
}
