
namespace TribonacciTriangle
{
    using System;
    using System.Collections.Generic;
    class TribonacciTriangle
    {
        static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            int linesCount = int.Parse(Console.ReadLine());

            int seqLenth = 0;
            for (int i = 0; i < linesCount; i++)
            {
                seqLenth++;
                seqLenth += i;
            }

            List<long> numbers = new List<long>();
            numbers.Add(firstNumber);
            numbers.Add(secondNumber);
            numbers.Add(thirdNumber);

            long sumMembers = 0;
            for (int i = 0; i < seqLenth - 3; i++)
            {
                sumMembers += (numbers[numbers.Count - 3] + numbers[numbers.Count - 2] + numbers[numbers.Count - 1]);
                numbers.Add(sumMembers);
                sumMembers = 0;
            }

            int index = 0;
            int counter = 0;
            for (int i = 1; i <= linesCount; i++)
            {
                for (int j = index; j < i + index; j++)
                {
                    Console.Write(numbers[j] + " ");
                    counter++;
                }
                index = counter;
                Console.WriteLine();
            }
        }
    }
}
