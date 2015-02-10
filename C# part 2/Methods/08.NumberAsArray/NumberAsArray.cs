/*
 Problem 8. Number as array

    Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    Each of the numbers that will be added could have up to 10 000 digits.

 */
namespace _08.NumberAsArray
{
    using System;
    using System.Numerics;
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string inputFirstNumber = Console.ReadLine();
            Console.Write("Enter second number: ");
            string inputSecondNumber = Console.ReadLine();

            BigInteger firstNumber;
            BigInteger secondNumber;
            bool isFirstNumber = BigInteger.TryParse(inputFirstNumber, out firstNumber);
            bool isSecondNumber = BigInteger.TryParse(inputSecondNumber, out secondNumber);

            if (isFirstNumber && isSecondNumber)
            {
                NumbersRepresentedAsArraysOfDigits(firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
        private static int[] ConvertToArray(BigInteger num)
        {
            int[] digits = new int[num.ToString().Length];
            string number = num.ToString();
            BigInteger currentNumber = num;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                digits[i] = (int)(currentNumber % 10);
                currentNumber /= 10;
            }
            return digits;
        }
        private static void NumbersRepresentedAsArraysOfDigits(BigInteger numberOne, BigInteger numberTwo)
        {
            int[] arrayNumberOne = ConvertToArray(numberOne);
            int[] arrayNumberTwo = ConvertToArray(numberTwo);
            
            Console.WriteLine("First Number");
            for (int i = 0; i < arrayNumberOne.Length; i++)
            {
                Console.WriteLine("array[{0}]: {1}", i, arrayNumberOne[i]);
            }
            Console.WriteLine("Second number");
            for (int j = 0; j < arrayNumberTwo.Length; j++)
            {
                Console.WriteLine("array[{0}]: {1}", j, arrayNumberTwo[j]);
            }
        }
    }
}
