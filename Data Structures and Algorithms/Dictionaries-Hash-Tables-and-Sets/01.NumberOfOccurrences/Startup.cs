namespace _01.NumberOfOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            double[] numbers = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            Dictionary<double, int> occurrences = new Dictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!occurrences.ContainsKey(numbers[i]))
                {
                    occurrences[numbers[i]] = 0;
                }

                occurrences[numbers[i]]++;
            }

            IEnumerable<KeyValuePair<double, int>> result = occurrences.OrderBy(n => n.Key);
            foreach (var item in result)
            {
                Console.WriteLine("{0} --> {1} times", item.Key, item.Value);
            }
        }
    }
}
