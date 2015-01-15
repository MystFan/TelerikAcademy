using System;
using System.Globalization;
using System.Threading;

//Problem 2. Gravitation on the Moon

//  -The gravitational field of the Moon is approximately 17% of that on the Earth.
//   - Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

namespace _02.GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
                                 CultureInfo.InvariantCulture;

            string input = Console.ReadLine();

            double weight;
            bool isNumber = double.TryParse(input, out weight);
            if (isNumber && weight > 1)
            {
                double weightOnMoon = (weight / (double)100) * 17;
                Console.WriteLine(weightOnMoon);
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
