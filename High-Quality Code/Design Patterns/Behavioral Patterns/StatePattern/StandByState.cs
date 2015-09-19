namespace StatePattern
{
    using System;

    public class StandByState : State
    {
        public StandByState(VendingMachine machine)
            : base(machine)
        {
        }

        public override void InsertCoin(double amount)
        {
            if (amount >= this.VendingMachine.GetMinPrice())
            {
                this.VendingMachine.State = new ReadyState(this.VendingMachine);
            }
        }

        public override void PressButton(string drinkName)
        {
            Console.WriteLine("For {0} insert {1} coins", drinkName, this.VendingMachine.Drinks[drinkName]);
        }

        public override void Dispense()
        {
            Console.WriteLine("Insert coins");
        }
    }
}
