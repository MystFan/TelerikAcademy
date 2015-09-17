namespace MediatorPattern
{
    public abstract class FinancialInstitution
    {
        public abstract void Register(IAccount account);

        public abstract void DepositToAll(IAccount account, decimal sum);

        public abstract void Transfer(IAccount from, IAccount to, decimal sum);
    }
}
