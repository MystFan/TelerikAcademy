namespace StatePattern
{
    using System;

    public class ReadyState : State
    {
        public ReadyState(VendingMachine machine)
            : base(machine)
        {
        }

        public override void InsertCoin(double amount)
        {
            this.VendingMachine.Coins += amount;
        }

        public override void PressButton(string drinkName)
        {
            if (this.VendingMachine.Drinks[drinkName] <= this.VendingMachine.Coins)
            {
                this.VendingMachine.Coins -= this.VendingMachine.Drinks[drinkName];
                this.VendingMachine.CoinsChange = this.VendingMachine.Coins;
                this.VendingMachine.State = new DispenseState(this.VendingMachine);
            }
        }

        public override void Dispense()
        {
            Console.WriteLine("Select drink");
        }
    }
}
