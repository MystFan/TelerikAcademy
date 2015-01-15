using System;
using System.Numerics;
/*
 Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    (2*n)!/(n + 1)!* n!;
    Write a program to calculate the nth Catalan number by given n (1 < n < 100).

 */
namespace _08.CatalanNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter n (n >= 0)");
            Console.Write("n = ");
            string inputN = Console.ReadLine();

            int n;
            bool isNumberN = int.TryParse(inputN, out n);

            if (isNumberN )
            {
                BigInteger firstFactoriel = 1;
                BigInteger secondFactoriel = 1;
                BigInteger thirdFactoriel = 1;
                for (long i = 2 * n; i > 0; i--)
                {
                    firstFactoriel *= i;
                    if (i <= n + 1)
                    {
                        secondFactoriel *= i;
                    }
                    if (i <= n)
                    {
                        thirdFactoriel *= i;
                    }
                }

                BigInteger catalan = firstFactoriel / (secondFactoriel * thirdFactoriel);
                Console.WriteLine(catalan);
            }
            else
            {
                Console.WriteLine("Some input string was not in correct format");
            }
        }
    }
}
