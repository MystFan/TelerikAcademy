/*
 Problem 2. Compare arrays

    Write a program that reads two integer arrays from the console and compares them element by element.

 */
namespace _02.CompareArrays
{
    using System;
    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Enter arrays length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arrayOne = new int[length];
            int[] arrayTwo = new int[length];

            Console.WriteLine("First array");
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write("ArrayOne[{0}] = ", i);
                string input = Console.ReadLine();
                int number;
                bool isNumber = int.TryParse(input, out number);
                if (isNumber)
                {
                    arrayOne[i] = number;
                }
                else
                {
                    Console.WriteLine("Input string was not in a correct format");
                }
            }

            Console.WriteLine("Second array");
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.Write("ArrayTwo[{0}] = ", i);
                string input = Console.ReadLine();
                int number;
                bool isNumber = int.TryParse(input, out number);
                if (isNumber)
                {
                    arrayTwo[i] = number;
                }
                else
                {
                    Console.WriteLine("Input string was not in a correct format");
                }
            }

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine("ArrayOne[{0}] != arrayTwo[{0}]",i);
                }
                else
                {
                    Console.WriteLine("ArrayOne[{0}] == arrayTwo[{0}]", i);
                }
            }
        }
    }
}
