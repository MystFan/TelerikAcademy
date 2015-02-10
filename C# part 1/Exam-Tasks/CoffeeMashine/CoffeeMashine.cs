
namespace CoffeeMashine
{
    using System.Threading;
    using System.Threading.Tasks;
    using System;
    using System.Globalization;
    class CoffeeMashine
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

            int coin1 = int.Parse(Console.ReadLine());
            int coin2 = int.Parse(Console.ReadLine());
            int coin3 = int.Parse(Console.ReadLine());
            int coin4 = int.Parse(Console.ReadLine());
            int coin5 = int.Parse(Console.ReadLine());
            double moneyInput = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double n1 = 0.05 * coin1;
            double n2 = 0.10 * coin2;
            double n3 = 0.20 * coin3;
            double n4 = 0.50 * coin4;
            double n5 = 1.00 * coin5;
            double sumCoins = n1 + n2 + n3 + n4 + n5;
            double change;

            if (sumCoins >= moneyInput - price)
            {
                if (moneyInput >= price)
                {
                    change = moneyInput - price;
                    Console.WriteLine("Yes {0:F2}", sumCoins - change);
                }
                else if (moneyInput < price)
                {
                    Console.WriteLine("More {0:F2}", price - moneyInput);
                }
            }
            else
            {
                change = moneyInput - price;
                sumCoins = sumCoins - change;
                Console.WriteLine("No {0:F2}", Math.Abs(sumCoins));
            }
        }
    }
}
