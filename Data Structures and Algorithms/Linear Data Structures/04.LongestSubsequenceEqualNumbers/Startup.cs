namespace _04.LongestSubsequenceEqualNumbers
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

            List<int> equalNumbers = FindLongestSubsequenceOfEqualNumbers(numbers);
            Console.WriteLine(string.Join(", ", equalNumbers));
        }

        public static List<int> FindLongestSubsequenceOfEqualNumbers(List<int> numbers)
        {
            int startIndex = 0;
            int currentStartIndex = 0;
            int currentLength = 1;
            int length = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    currentLength++;
                    if(i == numbers.Count - 1)
                    {
                        if (length < currentLength)
                        {
                            length = currentLength;
                            startIndex = currentStartIndex + 1;
                        }
                    }
                }
                else
                {
                    currentStartIndex = i - currentLength;
                    if (length < currentLength)
                    {
                        length = currentLength;
                        startIndex = currentStartIndex;
                        currentLength = 1;
                    }
                    currentLength = 1;
                }
            }

            List<int> result = new List<int>();
            for (int i = startIndex; i < startIndex + length; i++)
            {
                result.Add(numbers[i]);
            }

            return result;
        }
    }
}
