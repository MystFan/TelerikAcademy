/*
 Problem 5. Maximal increasing sequence

    Write a program that finds the maximal increasing sequence in an array.

 */
namespace _05.MaximalIcreasingSquence
{
    using System;
    class MaximalIcreasingSquence
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
            int sequenceCount = 0;
            int bestSequence = 0;
            int veryBestSequence = 1;
            int firstStart = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if ( sequence[i + 1] == sequence[i] + 1) 
                {
                    startElement = sequence[i];
                    sequenceCount++;
                    if (bestSequence < sequenceCount)
                    {
                        bestSequence = sequenceCount;
                    }
                    if (veryBestSequence <= bestSequence)
                    {
                        veryBestSequence = bestSequence;
                    }
                    if (sequenceCount <= 1)
                    {
                        firstStart = i;
                    }
                }
                else
                {
                    startElement = 0;
                    sequenceCount = 0;
                }
            }

            Console.WriteLine("Maximal increasing sequence");
            for (int i = 0; i < veryBestSequence + 1; i++)
            {
                Console.Write("{0} ", sequence[i + firstStart]);
            }
            Console.WriteLine();
        }
    }
}
