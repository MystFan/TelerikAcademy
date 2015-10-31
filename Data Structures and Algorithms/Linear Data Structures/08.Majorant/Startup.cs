namespace _08.Majorant
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var numbers = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            Dictionary<int, int> occursCount = FindOccursCount(numbers);
            int majorantFormulaValue = (numbers.Length / 2) + 1;

            foreach (var item in occursCount)
            {
                if(item.Value == majorantFormulaValue)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }

        private static Dictionary<int, int> FindOccursCount(int[] numbers)
        {
            Dictionary<int, int> occursCount = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!occursCount.ContainsKey(numbers[i]))
                {
                    occursCount[numbers[i]] = 0;
                }

                occursCount[numbers[i]]++;
            }

            return occursCount;
        }
    }
}
