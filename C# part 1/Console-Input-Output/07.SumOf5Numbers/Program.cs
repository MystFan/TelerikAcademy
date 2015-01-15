using System;
using System.Globalization;
using System.Threading;

//Problem 7. Sum of 5 Numbers

//    -Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

namespace _07.SumOf5Numbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                                        CultureInfo.InvariantCulture;

            Console.Write("Enter the numbers separated by an empty space: ");
            string inputNumbers = Console.ReadLine();

            string[] numbers = inputNumbers.Split(' ');
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
			{
                double number;
			    bool isNumber = double.TryParse(numbers[i], out number);
                if(isNumber)
                {
                    if (!String.IsNullOrWhiteSpace(numbers[i]))
                    {
                        sum += number;
                    }
                }
			}
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
