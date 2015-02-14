/*
 Problem 1. Square root

    Write a program that reads an integer number and calculates and prints its square root.
        If the number is invalid or negative, print Invalid number.
        In all cases finally print Good bye.
    Use try-catch-finally block.

 */
namespace _01.SquareRoot
{
    using System;
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter integer number: ");
                string input = Console.ReadLine();
                double result = CalculateSqrt(input);
                Console.WriteLine("Result: {0}", result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        private static double CalculateSqrt(string num)
        {
            double result = 0;
            int number;
            bool isNumber = int.TryParse(num, out number);
            if(isNumber && number > 0)
            {
                result = Math.Sqrt(number);
            }
            else
            {
                throw new ArgumentException("Invalid number");
            }
            return result;
        }
    }
}
