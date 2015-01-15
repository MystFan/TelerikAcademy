using System;
/*
 Problem 2. Numbers Not Divisible by 3 and 7

   - Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
 */
namespace _02.NumbersNotDivisibleBy3And7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter n = ");
            string input = Console.ReadLine();

            int n;
            bool isNumber = int.TryParse(input, out n);
            if (isNumber && n >= 0)
            {
                string output = String.Empty;
                for (int i = 1; i <= n; i++)
                {
                    if (!(i % 3 == 0 || i % 7 == 0))
                    {
                        output += i + " ";
                    }
                }
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Input string was not in correct format");
            }
        }
    }
}
