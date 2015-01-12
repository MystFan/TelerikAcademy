using System;
/*
 Problem 7. Sort 3 Numbers with Nested Ifs

    Write a program that enters 3 real numbers and prints them sorted in descending order.
        Use nested if statements.

Note: Don’t use arrays and the built-in sorting functionality.
 */
namespace _07.Sort3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
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
                if (firstNumber > secondNumber && firstNumber > thirdNumber)
                {
                    if (secondNumber > thirdNumber)
                    {
                        Console.WriteLine("Numbers --> {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
                    }
                    if (thirdNumber > secondNumber)
                    {
                        Console.WriteLine("Numbers --> {0} {1} {2}", firstNumber, thirdNumber, secondNumber);
                    }
                }
                if (secondNumber > firstNumber && secondNumber > thirdNumber)
                {
                    if (firstNumber > thirdNumber)
                    {
                        Console.WriteLine("Numbers --> {0} {1} {2}", secondNumber, firstNumber, thirdNumber);
                    }
                    if (thirdNumber > firstNumber)
                    {
                        Console.WriteLine("Numbers --> {0} {1} {2}", secondNumber, thirdNumber, secondNumber);
                    }
                }
                if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                {
                    if (firstNumber > secondNumber)
                    {
                        Console.WriteLine("Numbers --> {0} {1} {2}", thirdNumber, firstNumber, secondNumber);
                    }
                    if (secondNumber > firstNumber)
                    {
                        Console.WriteLine("Numbers --> {0} {1} {2}", thirdNumber, secondNumber, firstNumber);
                    }
                }
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
