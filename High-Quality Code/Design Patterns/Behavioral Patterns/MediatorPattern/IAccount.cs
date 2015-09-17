namespace MediatorPattern
{
    public interface IAccount
    {
        string Name { get; set; }

        string Number { get; set; }

        decimal Money { get; }

        FinancialInstitution Institution { get; set; }

        void SendMoney(IAccount to, decimal sum);

        void SendToAll(decimal sum);

        void ReciveMoney(decimal sum);
    }
}
