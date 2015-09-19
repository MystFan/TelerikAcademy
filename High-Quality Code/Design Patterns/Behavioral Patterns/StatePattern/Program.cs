namespace StatePattern
{
    public class Program
    {
        public static void Main()
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddDrink("coffee", 0.50);
            vendingMachine.AddDrink("tea", 0.30);
            vendingMachine.AddDrink("hot-chocolate", 0.80);

            vendingMachine.InsertCoins(0.30);
            vendingMachine.GetDrink("tea");
            vendingMachine.InsertCoins(1.0);
            vendingMachine.GetDrink("hot-chocolate");
        }
    }
}
