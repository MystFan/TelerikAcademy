namespace Problem5
{
    using System;
    class SearchInBits
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string binaryN = Convert.ToString(N, 2).TrimStart('0').PadLeft(4,'0');
            int S = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < S; i++)
            {
                long input = long.Parse(Console.ReadLine());
                string currentNumber = Convert.ToString(input, 2).PadLeft(30,'0');
                int index = -1;
                while (true)
                {
                    index = currentNumber.IndexOf(binaryN, index + 1);
                    if (index < 0)
                    {
                        break;
                    }
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
