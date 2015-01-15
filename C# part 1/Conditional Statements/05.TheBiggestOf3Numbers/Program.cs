using System;
using System.Globalization;
using System.Threading;

/*
 Problem 5. The Biggest of 3 Numbers

    -Write a program that finds the biggest of three numbers.

 */
namespace _05.TheBiggestOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
                                   CultureInfo.InvariantCulture;

            Console.Write("First number: ");
            string inputFirstNumber = Console.ReadLine();
            Console.Write("Second number: ");
            string inputSecondNumber = Console.ReadLine();
            Console.Write("Third number: ");
            string inputThirdNumber = Console.ReadLine();

            double firstNumber;
            double secondNumber;
            double thirdNumber;

            bool isValidFirstNumber = double.TryParse(inputFirstNumber, out firstNumber);
            bool isValidSecondNumber = double.TryParse(inputSecondNumber, out secondNumber);
            bool isValidThirdNumber = double.TryParse(inputThirdNumber, out thirdNumber);


            if (isValidFirstNumber && isValidSecondNumber && isValidThirdNumber)
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
                Console.WriteLine("The biggest number --> {0}", biggestNumber);
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
