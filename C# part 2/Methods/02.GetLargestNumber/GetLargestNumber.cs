/*
 Problem 2. Get largest number

    Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

 */
namespace _02.GetLargestNumber
{
    using System;
    class GetLargestNumber
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            string inputFirstNumber = Console.ReadLine();
            Console.Write("Enter second number: ");
            string inputSecondNumber = Console.ReadLine();
            Console.Write("Enter third number: ");
            string inputThirdNumber = Console.ReadLine();
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            bool isFirstNumber = int.TryParse(inputFirstNumber, out firstNumber);
            bool isSecondNumber = int.TryParse(inputSecondNumber, out secondNumber);
            bool isThirdNumber = int.TryParse(inputThirdNumber, out thirdNumber);
            if (isFirstNumber && isSecondNumber && isThirdNumber)
            {
                int maxNumber = GetMax(firstNumber, secondNumber);
                maxNumber = GetMax(maxNumber, thirdNumber);
                Console.WriteLine("Max number --> {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }

        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            int max = firstNumber;
            if (secondNumber > firstNumber)
            {
                max = secondNumber;
            }
            return max;
        }
    }
}
