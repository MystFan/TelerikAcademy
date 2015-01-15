using System;
using System.Numerics;
/*
 Problem 18.* Trailing Zeroes in N!

    -Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    -Your program should work well for very big numbers, e.g. n=100000.
 */
namespace _18.TrailingZeroesInN_
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            string inputN = Console.ReadLine();

            int n;
            bool isNumberN = int.TryParse(inputN, out n);

            if (isNumberN)
            {
                BigInteger factoriel = 1;

                for (int i = n; i > 0; i--)
                {
                    factoriel *= i;
                }

                BigInteger currentNumber = factoriel;
                int counter = 0;
                while (currentNumber % 10 == 0)
                {
                    currentNumber /= 10;
                    counter++;
                }
                Console.WriteLine("{0} zeros", counter);
            }
            else
            {
                Console.WriteLine("Input string was not in correct format");
            }
        }
    }
}
