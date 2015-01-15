using System;
using System.Globalization;
using System.Threading;
//Problem 1. Sum of 3 Numbers

//    -Write a program that reads 3 real numbers from the console and prints their sum.

namespace _01.SumOf3Numbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                                     CultureInfo.InvariantCulture;

            Console.Write("Enter first number: ");
            string inputFirstNumber = Console.ReadLine();
            Console.Write("Enter second number: ");
            string inputSecondNumber = Console.ReadLine();
            Console.Write("Enter third number: ");
            string inputThirdNumber = Console.ReadLine();

            double firstNumber;
            double secondNumber;
            double thirdNumber;
            bool isFirstNumber = double.TryParse(inputFirstNumber, out firstNumber);
            bool isSecondNumber = double.TryParse(inputSecondNumber, out secondNumber);
            bool isThirdNumber = double.TryParse(inputThirdNumber, out thirdNumber);

            if (isFirstNumber && isSecondNumber && isThirdNumber)
            {
                double sum = firstNumber + secondNumber + thirdNumber;
                Console.WriteLine("Sum of numbers: {0}", sum);
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
