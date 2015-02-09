/*
 Problem 4. Binary search

    Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

 */
namespace _04.BinarySearch
{
    using System;
    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());

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
            }

            Array.Sort(numbers);
            int index = 0;

            int element = Array.BinarySearch(numbers, K);
            if (element < 0)
            {
                index = Array.FindIndex<int>(numbers, item => item == ~element);
                Console.WriteLine("The number to search for ({0}) is not found. The largest number {1} <= K.", K, numbers[index - 1]);
            }
            else
            {
                Console.WriteLine("The number to search for ({0}) is faund --> {1}.", K, element);
            }

        }
    }
}
