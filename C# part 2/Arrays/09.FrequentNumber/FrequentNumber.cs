/*
 Problem 9. Frequent number

    Write a program that finds the most frequent number in an array.

 */
namespace _09.FrequentNumber
{
    using System;
    class FrequentNumber
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

            int counter = 0;
            int maxCount = 0;
            int number = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                if (maxCount < counter)
                {
                    maxCount = counter;
                    number = numbers[i];
                }
                counter = 0;
            }

            Console.WriteLine("{0}({1} times)",number, maxCount);
        }
    }
}
