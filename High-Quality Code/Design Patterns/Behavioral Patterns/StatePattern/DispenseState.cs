namespace StatePattern
{
    using System;

    public class DispenseState : State
    {
        public DispenseState(VendingMachine machine)
            : base(machine)
        {
        }

        public override void InsertCoin(double amount)
        {
            this.VendingMachine.Coins += amount;
        }

        public override void PressButton(string drinkName)
        {
            Console.WriteLine("Wait");
        }

        public override void Dispense()
        {
            Console.WriteLine("Your drink: \"" + this.VendingMachine.Drink + "\" change: " + this.VendingMachine.CoinsChange);
            this.VendingMachine.State = new StandByState(this.VendingMachine);
        }
    }
}
