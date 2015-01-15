using System;
/*
 Problem 1. Numbers from 1 to N

    -Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
 */

namespace _01.NumbersFrom1ToN
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
                    output += i + " ";
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
