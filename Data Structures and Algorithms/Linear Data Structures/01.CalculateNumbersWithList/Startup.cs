namespace _01.CalculateNumbersWithList
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("../../numbers.txt");
            Console.SetIn(reader);

            List<int> numbers = new List<int>();
            while (true)
            {
                string numberInput = Console.ReadLine();
                if (numberInput == "" || numberInput == null)
                {
                    break;
                }

                int number = int.Parse(numberInput);
                numbers.Add(number);
            }

            long sumOfNumbers = Sum(numbers);
            Console.WriteLine("Sum: {0}", sumOfNumbers);
            long averageOfNumbers = Average(numbers);
            Console.WriteLine("Average: {0}", averageOfNumbers);
        }

        private static long Average(List<int> numbers)
        {
            long average = Sum(numbers) / numbers.Count;
            return average;
        }

        public static long Sum(List<int> numbers)
        {
            long sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
