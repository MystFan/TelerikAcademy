/*
 Problem 10. Find sum in array

    Write a program that finds in given array of integers a sequence of given sum S (if present).

 */
namespace _10.FindSumInArray
{
    using System;
    class FindSumInArray
    {
        static void Main()
        {
            Console.Write("Enter sum S = ");
            int S = int.Parse(Console.ReadLine());
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

            int currentSum = 0;
            int startSeq = 0;
            int endSeq = 0;
            int seqCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentSum += numbers[i];
                if (numbers[i] == S)
                {
                    seqCount = 1;
                    startSeq = i;
                    endSeq = i;
                    break;
                }
                if (currentSum < S)
                {
                    seqCount++;
                }
                else if (currentSum > S)
                {
                    startSeq = i;
                    seqCount = 1;
                    currentSum = numbers[i];
                }
                else if (currentSum == S)
                {
                    seqCount++;
                    endSeq = i;
                    break;
                }
            }

            for (int i = startSeq; i <= endSeq; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
