using System;
/*
 Problem 8. Numbers from 1 to n

    -Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
 */

namespace _08.NumbersFrom1ToN
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int n;
            bool isValidNumber = int.TryParse(input, out n);
            if (isValidNumber)
            {
                if (n > 0)
                {
                    Console.WriteLine("N = {0}", n);
                    Console.WriteLine("Numbers");
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("N should be greater than 0");
                }
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }

        }
    }
}
