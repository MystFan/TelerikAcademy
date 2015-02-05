
namespace BinaryDigitsCount
{
    using System;
    class BinaryDigitsCount
    {
        static void Main()
        {
            string b = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            long[] arr = new long[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = long.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                string numToString = Convert.ToString(arr[i], 2);
                for (int j = 0; j < numToString.Length; j++)
                {
                    if (numToString[j].ToString() == b)
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
                counter = 0;
            }
        }
    }
}
