namespace Tribonacci
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            List<long> numbers = new List<long>();
            numbers.Add(input[0]);
            numbers.Add(input[1]);
            numbers.Add(input[2]);

            long output = 0;
            if (input[3] < 4)
            {
                output = input[input[3] - 1];
            }

            for (int i = 0; i < input[3] - 3; i++)
            {
                output = numbers[i] + numbers[i + 1] + numbers[i + 2];
                numbers.Add(output);
            }

            Console.WriteLine(output);
        }
    }
}
