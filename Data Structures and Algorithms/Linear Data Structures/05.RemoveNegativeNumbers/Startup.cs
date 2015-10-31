namespace _05.RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        public static void Main(string[] args)
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

            List<int> positiveNumbers = RemoveNegatives(numbers);
            Console.WriteLine("Positive numbers: {0}", string.Join(", ", positiveNumbers));
        }

        private static List<int> RemoveNegatives(List<int> numbers)
        {
            List<int> positiveNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    positiveNumbers.Add(numbers[i]);
                }
            }

            return positiveNumbers;
        }
    }
}
