using System;
using System.Numerics;
/*
 Problem 7. Calculate N! / (K! * (N-K)!)

    In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

 */
namespace _07.CalculateExpression
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter n and k (1 < k < n < 100)");
            Console.Write("n = ");
            string inputN = Console.ReadLine();
            Console.Write("k = ");
            string inputK = Console.ReadLine();

            int n;
            int k;
            bool isNumberN = int.TryParse(inputN, out n);
            bool isNumberK = int.TryParse(inputK, out k);

            if (isNumberN && isNumberK)
            {
                if ((k > 1 && k < 100) && (n > 1 && n < 100))
                {
                    if (k < n)
                    {
                        BigInteger factorielN = 1;
                        BigInteger factorielK = 1;
                        BigInteger factoriel = 1;
                        for (int i = n; i > 0; i--)
                        {
                            factorielN *= i;
                        }
                        for (int j = k; j > 0; j--)
                        {
                            if(j <= n - k)
                            {
                                factoriel *= j;
                            }
                            factorielK *= j;
                        }

                        BigInteger expression = factorielN / (factorielK * factoriel);
                        Console.WriteLine(expression);
                    }
                    else
                    {
                        Console.WriteLine("K must be less than N");
                    }
                }
                else
                {
                    Console.WriteLine("N or K is out of range");
                }
            }
            else
            {
                Console.WriteLine("Some input string was not in correct format");
            }
        }
    }
}
