
namespace _06.SumIntegers
{
    using System;
    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter integer values separated by space");
            string numberSequence = Console.ReadLine();
            string[] numbers = numberSequence.Split(' ');
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                string input = numbers[i];
                int number;
                bool isNumber = int.TryParse(input, out number);
                if (isNumber)
                {
                    sum += number;
                }
            }
            Console.WriteLine("Sum {0}",sum);
        }
    }
}
