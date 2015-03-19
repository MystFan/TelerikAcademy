/*Problem 2. Bank accounts

    A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
    All accounts have customer, balance and interest rate (monthly based).
        Deposit accounts are allowed to deposit and with draw money.
        Loan and mortgage accounts can only deposit money.
    All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
    Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
    Deposit accounts have no interest if their balance is positive and less than 1000.
    Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
    Your task is to write a program to model the bank system by classes and interfaces.
    You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
*/
namespace Accounts
{
    using System;
    public abstract class Account : IDeposit
    {
        protected decimal balance;
        protected decimal interestRate;
        protected Customer customer;

        protected Account(decimal initialBalance, decimal initialInterestRate)
        {
            this.Balance = initialBalance;
            this.InterestRate = initialInterestRate;
            this.Customer = new Customer("No name", CustomerType.None);
        }
        protected Account(decimal initialBalance, decimal initialInterestRate, Customer initialCustomer)
            : this(initialBalance, initialInterestRate)
        {
            this.Customer = initialCustomer;
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Acoount balance is less than zero");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Acoount interest rate is less than zero");
                }
                this.interestRate = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Account customer is null");
                }
                this.customer = value;
            }
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            decimal result = (this.InterestRate * (decimal)months);
            return result;
        }
        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }
    }
}
