namespace StatePattern
{
    using System.Collections.Generic;

    public class VendingMachine
    {
        public readonly Dictionary<string, double> Drinks;

        public VendingMachine()
        {
            this.State = new StandByState(this);
            this.Drinks = new Dictionary<string, double>();
        }

        public State State { get; set; }

        public double Coins { get; set; }

        public string Drink { get; set; }

        public double CoinsChange { get; set; }

        public double HotChocolatePrice { get; set; }

        public void AddDrink(string name, double price)
        {
            this.Drinks.Add(name, price);
        }

        public void InsertCoins(double coins)
        {
            this.State.InsertCoin(coins);
            this.Coins = coins;
        }

        public void GetDrink(string name)
        {
            this.Drink = name;
            this.State.PressButton(name);
            this.State.Dispense();
        }

        public double GetMinPrice()
        {
            double minPrice = double.MaxValue;
            foreach (var drink in this.Drinks)
            {
                if (drink.Value < minPrice)
                {
                    minPrice = drink.Value;
                }
            }

            return minPrice;
        }
    }
}
