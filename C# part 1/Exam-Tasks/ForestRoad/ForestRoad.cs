
namespace ForestRoad
{
    using System;
    class ForestRoad
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char blank = '.';
            char road = '*';

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(blank, i));
                Console.Write(road);
                Console.WriteLine(new string(blank, n - i - 1));
            }
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(blank, n - i - 1));
                Console.Write(road);
                Console.WriteLine(new string(blank, i));
            }
        }
    }
}
