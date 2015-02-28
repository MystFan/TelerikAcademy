using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        private static char[] separators = new char[] { ' ', ',' };
        static int[] valley;
        static void Main(string[] args)
        {
            valley = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();
            int mapsCount = int.Parse(Console.ReadLine());
            BigInteger coins = 0;
            BigInteger bestCoins = int.MinValue;
            for (int i = 0; i < mapsCount; i++)
            {
                coins += CollectCoins(Console.ReadLine());
                if (bestCoins < coins)
                {
                    bestCoins = coins;
                }
                coins = 0;
            }
            Console.WriteLine(bestCoins);
        }

        private static BigInteger CollectCoins(string input)
        {
            BigInteger sum = 0;
            int[] steps = input.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();
            List<int> positions = new List<int>();
            positions.Add(0);
            int stepsIndex = 0;
            int position = steps[0];
            sum += valley[0];
            while (true)
            {
                if (position > valley.Length - 1 || position < 0 || positions.Contains(position))
                {
                    if (position == valley.Length - 1)
                    {
                        sum += valley[position];
                    }
                    break;
                }
                positions.Add(position);
                sum += valley[position];
                stepsIndex++;
                if (stepsIndex > steps.Length - 1)
                {
                    stepsIndex = 0;
                }
                position += steps[stepsIndex];
            };
            return sum;
        }
    }
}
