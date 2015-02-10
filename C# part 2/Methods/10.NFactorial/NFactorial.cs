/*
 Problem 10. N Factorial

    Write a program to calculate n! for each n in the range [1..100].

 */
namespace _10.NFactorial
{
    using System;
    using System.Numerics;
    class NFactorial
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                BigInteger fact = Factorial(i);
                Console.WriteLine("Factorial {0} = {1}",i,fact);
            }
        }

        private static BigInteger Factorial(int num)
        {
            int currentNumber = num;
            BigInteger factorial = 1;
            while (currentNumber > 1)
            {
                factorial *= currentNumber;
                currentNumber--;
            }
            return factorial;
        }
    }
}
