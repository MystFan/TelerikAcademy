using System;
using System.Collections.Generic;
/*
Problem 17.* Calculate GCD

    -Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    -Use the Euclidean algorithm (find it in Internet).
 */
namespace _17.CalculateGCD
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
                int minNumber = firstNumber;
                int maxNumber = secondNumber;
                if (secondNumber < firstNumber)
                {
                    minNumber = secondNumber;
                    maxNumber = firstNumber;
                }
                if (firstNumber != 0 && secondNumber != 0)
                {
                    if (minNumber < 0)
                    {
                        minNumber *= (-1);
                    }
                    if (maxNumber < 0)
                    {
                        maxNumber *= (-1);
                    }
                    List<int> minNumberDivisors = new List<int>();

                    for (int i = 1; i <= minNumber; i++)
                    {
                        if (minNumber % i == 0)
                        {
                            minNumberDivisors.Add(i);
                        }
                    }

                    int gcd = 0;
                    for (int i = minNumberDivisors.Count - 1; i >= 0; i--)
                    {
                        if (maxNumber % minNumberDivisors[i] == 0)
                        {
                            gcd = minNumberDivisors[i];
                            break;
                        }
                    }

                    Console.WriteLine("GCD({0},{1}) = {2}", firstNumber, secondNumber, gcd);
                }
                else
                {
                    Console.WriteLine("One of the numbers is zero");
                }
            }
            else
            {
                Console.WriteLine("Some input string was not in correct format");
            }
        }
    }
}
