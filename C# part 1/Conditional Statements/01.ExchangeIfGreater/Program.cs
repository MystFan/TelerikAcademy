using System;

//Problem 1. Exchange If Greater

//    -Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

namespace _01.ExchangeIfGreater
{
    class Program
    {
        static void Main()
        {
            Console.Write("First number: ");
            string inputFirstNumber = Console.ReadLine();
            Console.Write("Second number: ");
            string inputSecondNumber = Console.ReadLine();

            int firstNumber;
            int secondNumber;
            bool isValidFirstNumber = int.TryParse(inputFirstNumber, out firstNumber);
            bool isValidSecondNumber = int.TryParse(inputSecondNumber, out secondNumber);

            if (isValidFirstNumber && isValidSecondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    int currentNumber = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = currentNumber;
                }
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
