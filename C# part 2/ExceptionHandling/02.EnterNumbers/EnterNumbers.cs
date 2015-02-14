/*
 Problem 2. Enter numbers

    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
        If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

 */
namespace _02.EnterNumbers
{
    using System;
    using System.Collections.Generic;
    class EnterNumbers
    {
        static void Main()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    ReadNumber(1, 100);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter number: ");
            string input = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                if (number > start && number < end)
                {
                    Console.WriteLine("Valid number {0}",number);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                throw new ArgumentException("Input string is not in corect format");
            }
        }
    }
}
