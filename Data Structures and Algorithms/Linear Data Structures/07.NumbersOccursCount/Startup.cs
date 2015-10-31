namespace _07.NumbersOccursCount
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

            int[] numbers = new int[9];
            int index = 0;

            while (true)
            {
                string numberInput = Console.ReadLine();
                if (numberInput == "" || numberInput == null)
                {
                    break;
                }

                int number = int.Parse(numberInput);
                numbers[index] = number;
                index++;
            }

            Array.Sort(numbers);
            PrintOccursCount(numbers);
        }

        private static void PrintOccursCount(int[] numbers)
        {
            int counter = 1;
            List<int> list = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (list.Contains(numbers[i]))
                {
                    continue;
                }

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            counter++;
                        }
                    }
                }

                list.Add(numbers[i]);
                Console.WriteLine("{0} --> {1} times", numbers[i], counter);
                counter = 1;
            }
        }
    }
}
