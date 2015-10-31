namespace _03.SortNumbersIncreasingOrder
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

            numbers.Sort();
            PrintNumbers(numbers);
        }

        private static void PrintNumbers(List<int> numbers)
        {
            int index = 0;
            while (index < numbers.Count)
            {
                Console.WriteLine(numbers[index]);
                index++;
            }
        }
    }
}
