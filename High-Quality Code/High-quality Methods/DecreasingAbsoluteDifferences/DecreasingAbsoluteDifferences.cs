namespace DecreasingAbsoluteDifferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    private class DecreasingAbsoluteDifferences
    {
        private static int[] ReadInputSequence()
        {
            string line = Console.ReadLine();
            string[] sequenceOfNumbersAsStrings = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] sequenceOfNumbers = sequenceOfNumbersAsStrings.Select(n => int.Parse(n)).ToArray();
            return sequenceOfNumbers;
        }

        private static void Main()
        {
            List<string> results = new List<string>();
            int sequencesCount = int.Parse(Console.ReadLine());
            bool isDecreasingAbsoluteDifference = true;
            for (int i = 0; i < sequencesCount; i++)
            {
                int[] numbers = ReadInputSequence();
                int[] sequence = GetSequence(numbers);

                for (int k = 0; k < sequence.Length - 1; k++)
                {
                    int firstNumber = sequence[k];
                    int secondNumber = sequence[k + 1];
                    int result = Math.Abs(firstNumber - secondNumber);

                    if (result > 1 || firstNumber < secondNumber)
                    {
                        isDecreasingAbsoluteDifference = false;
                        break;
                    }
                }

                if (isDecreasingAbsoluteDifference)
                {
                    results.Add("True");
                }
                else
                {
                    results.Add("False");
                }

                isDecreasingAbsoluteDifference = true;
            }

            PrintResults(results);
        }

        private static void PrintResults(List<string> results)
        {
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static int[] GetSequence(int[] numbers)
        {
            List<int> sequence = new List<int>();

            for (int j = 0; j < numbers.Length - 1; j++)
            {
                int firstNumber = numbers[j];
                int secondNumber = numbers[j + 1];
                int result = 0;

                if (firstNumber > secondNumber)
                {
                    result = firstNumber - secondNumber;
                }
                else if (secondNumber > firstNumber)
                {
                    result = secondNumber - firstNumber;
                }
                else if (firstNumber == secondNumber)
                {
                    result = firstNumber - secondNumber;
                }

                sequence.Add(Math.Abs(result));
            }

            int[] resultSequence = sequence.ToArray();
            return resultSequence;
        }
    }
}
