/*
 Problem 8. Maximal sum

    Write a program that finds the sequence of maximal sum in given array.

 */
namespace _08.MaximalSum
{
    using System;
    class MaximalSum
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];

            Console.WriteLine("Enter integer values");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                string input = Console.ReadLine();
                int number;
                bool isNumber = int.TryParse(input, out number);
                if (isNumber)
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Input string was not in a correct format");
                }
            }

            int maxSeq = 0;
            int currentSum = 0;
            int sum = 0;
            int endPosition = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                currentSum += numbers[i];
                if (currentSum > sum)
                {
                    sum = currentSum;
                    maxSeq++;
                }
                else
                {
                    currentSum = 0;
                    endPosition = i - 1;
                    maxSeq = 0;
                }
            }
        }
    }
}
