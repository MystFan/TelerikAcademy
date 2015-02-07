/*
 Problem 4. Maximal sequence

    Write a program that finds the maximal sequence of equal elements in an array.

 */
namespace _04.MaximalSequence
{
    using System;

    class MaximalSequence
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] sequence = new int[length];
            Console.WriteLine("Enter integer values");
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                string input = Console.ReadLine();
                int number;
                bool isNumber = int.TryParse(input, out number);
                if (isNumber)
                {
                    sequence[i] = number;
                }
                else
                {
                    Console.WriteLine("Input string was not in a correct format");
                }
            }

            int startElement = 0;
            int sequenceCount = 1;
            int bestStart = 0;
            int bestSequence = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] != sequence[i + 1])
                {
                    startElement = sequence[i + 1];
                    sequenceCount = 1;
                }
                if (sequence[i] == sequence[i + 1])
                {
                    sequenceCount++;
                    if (bestSequence < sequenceCount)
                    {
                        bestSequence = sequenceCount;
                        bestStart = sequence[i + 1];
                    }
                }
            }

            int[] newSequence = new int[bestSequence];
            for (int i = 0; i < newSequence.Length; i++)
            {
                newSequence[i] = bestStart;
            }
            Console.WriteLine("Maximal sequence");
            for (int i = 0; i < newSequence.Length; i++)
            {
                Console.Write("{0} ", newSequence[i]);
            }
            Console.WriteLine();
        }
    }
}
