using System;
using System.Globalization;
using System.Threading;
/*
 Problem 6. The Biggest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.

 */
namespace _06.TheBiggestOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                                       CultureInfo.InvariantCulture;

            Console.Write("First number: ");
            string inputFirstNumber = Console.ReadLine();
            Console.Write("Second number: ");
            string inputSecondNumber = Console.ReadLine();
            Console.Write("Third number: ");
            string inputThirdNumber = Console.ReadLine();
            Console.Write("Four number: ");
            string inputFourNumber = Console.ReadLine();
            Console.Write("Five number: ");
            string inputFiveNumber = Console.ReadLine();

            double firstNumber;
            double secondNumber;
            double thirdNumber;
            double fourNumber;
            double fiveNumber;

            bool isValidFirstNumber = double.TryParse(inputFirstNumber, out firstNumber);
            bool isValidSecondNumber = double.TryParse(inputSecondNumber, out secondNumber);
            bool isValidThirdNumber = double.TryParse(inputThirdNumber, out thirdNumber);
            bool isValidFourNumber = double.TryParse(inputFourNumber, out fourNumber);
            bool isValidFiveNumber = double.TryParse(inputFiveNumber, out fiveNumber);

            if (isValidFirstNumber && isValidSecondNumber && isValidThirdNumber && isValidFourNumber && isValidFiveNumber)
            {
                double biggestNumber = firstNumber;
                if (secondNumber > biggestNumber)
                {
                    biggestNumber = secondNumber;
                }
                if (thirdNumber > biggestNumber)
                {
                    biggestNumber = thirdNumber;
                }
                if (fourNumber > biggestNumber)
                {
                    biggestNumber = fourNumber;
                }
                if (fiveNumber > biggestNumber)
                {
                    biggestNumber = fiveNumber;
                }
                Console.WriteLine("The biggest number --> {0}", biggestNumber);
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
