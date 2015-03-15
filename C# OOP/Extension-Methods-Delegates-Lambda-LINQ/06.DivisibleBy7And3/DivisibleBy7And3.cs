/*Problem 6. Divisible by 7 and 3

    Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/

namespace _06.DivisibleBy7And3
{
    using System;
    using System.Linq;
    class DivisibleBy7And3
    {
        static void Main()
        {
            int[] numbers = new int[100];
            GetRandomNumbers(numbers);

            int[] specialNumbers = numbers.Where(n => n % 3 == 0 && n % 7 == 0).ToArray();

            foreach (var number in specialNumbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void GetRandomNumbers(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
        }
    }
}
