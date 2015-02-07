/*
 Problem 6. Maximal K sum

    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum.

 */

namespace _06.MaximalKSum
{
    using System;
    class MaximalKSum
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter elements count K = ");
            int K = int.Parse(Console.ReadLine());

            int[] numbers = new int[N];

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

            if (K < N)
            {
                Array.Sort(numbers);
                int sum = 0;
                for (int i = numbers.Length - 1; i >= numbers.Length - K; i--)
                {
                    Console.Write(numbers[i] + " ");
                    sum += numbers[i];
                }
                Console.WriteLine();
                Console.WriteLine("sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("N must be greater than K");
            }
        }
    }
}
