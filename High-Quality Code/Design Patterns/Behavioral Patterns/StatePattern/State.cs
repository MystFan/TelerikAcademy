namespace StatePattern
{
    public abstract class State
    {
        protected State(VendingMachine machine)
        {
            this.VendingMachine = machine;
        }

        protected VendingMachine VendingMachine { get; private set; }

        public abstract void InsertCoin(double amount);

        public abstract void PressButton(string drinkName);

        public abstract void Dispense();
    }
}
