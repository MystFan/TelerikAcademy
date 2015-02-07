/*
 Problem 11. Binary search

    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

 */
namespace _11.BinarySearch
{
    using System;
    class BinarySearch
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

            Console.Write("Enter element: ");
            int element = int.Parse(Console.ReadLine());

            int minIndex = 0;
            int maxIndex = numbers.Length - 1;
            int position = 0;
            Array.Sort(numbers);
            while (minIndex < maxIndex)
            {
                int middIndex = (minIndex + maxIndex) / 2;

                if (numbers[middIndex] == element)
                {
                    position = middIndex;
                    break;
                }
                else if (numbers[middIndex] < element)
                {
                    minIndex = middIndex + 1;
                }
                else
                {
                    maxIndex = middIndex - 1;
                }
            }

            Console.WriteLine("Sorted Array");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Array[{0}] = {1}",i, numbers[i]);
            }
            Console.WriteLine("Position: {0}", position);
        }
    }
}
