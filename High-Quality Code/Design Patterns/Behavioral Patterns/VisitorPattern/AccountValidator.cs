namespace VisitorPattern
{
    using System;

    public class AccountValidator
    {
        public static void ValidateNumber(string number)
        {
            if (number.Length != 7)
            {
                throw new ArgumentException("Invalid account number");
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    throw new ArgumentException("Invalid account number");
                }
            }
        }

        public static void ValidateWithDrawOperation(Account account, decimal sum)
        {
            if (account.IsSavingAccount)
            {
                throw new ArgumentException("Cannot withdraw from saving account");
            }

            if (account.Balance - sum < 0)
            {
                throw new ArgumentException("Account does not have enough money");
            }


        }
    }
}
