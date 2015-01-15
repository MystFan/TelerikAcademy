using System;
using System.Globalization;
using System.Threading;

//Problem 9. Sum of n Numbers

//    -Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

namespace _09.SumOfNumbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                                 CultureInfo.InvariantCulture;
            Console.Write("n = ");
            string input = Console.ReadLine();

            double n;
            bool isValidNumber = double.TryParse(input, out n);
            if (isValidNumber)
            {
                if (n > 0)
                {
                    double sum = 0;
                    Console.WriteLine("N = {0}", n);
                    Console.WriteLine("Enter {0} numbers", n);
                    for (int i = 0; i < n; i++)
                    {
                        string inputNumber = Console.ReadLine();
                        double number;
                        bool isNumber = double.TryParse(inputNumber, out number);
                        if (isNumber)
                        {
                            sum += number;
                        }
                    }
                    Console.WriteLine("Sum = {0}", sum);
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
