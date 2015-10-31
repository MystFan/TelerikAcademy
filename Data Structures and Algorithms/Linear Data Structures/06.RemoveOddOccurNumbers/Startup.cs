namespace _06.RemoveOddOccurNumbers
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

            List<int> evenOccurNumbers = RemoveOddOccurNums(numbers);
            Console.WriteLine(string.Join(", ", evenOccurNumbers));
        }

        private static List<int> RemoveOddOccurNums(List<int> numbers)
        {
            List<int> result = new List<int>();
            int occursCount = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if(i != j)
                    {
                        if(numbers[i] == numbers[j])
                        {
                            occursCount++;
                        }
                    }
                }

                if(occursCount % 2 == 0)
                {
                    result.Add(numbers[i]);
                }

                occursCount = 1;
            }

            return result;
        }
    }
}
