/*
 Problem 7. Selection sort

    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

 */
namespace _07.SelectionSort
{
    using System;
    class SelectionSort
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

            int currentNumber = 0;
            int minNumber = int.MaxValue;
            int position = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    currentNumber = numbers[j];
                    if (currentNumber < minNumber)
                    {
                        minNumber = currentNumber;
                        position = j;
                    }
                }
                numbers[position] = numbers[i];
                numbers[i] = minNumber;
                minNumber = int.MaxValue;
            }
            Console.WriteLine("Sort array");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
