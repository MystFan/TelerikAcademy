
namespace FirTree
{
    using System;
    class FirTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char blank = '.';
            char leaf = '*';

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(blank, (n - 2) - i));
                Console.Write(new string(leaf, i + i + 1));
                Console.WriteLine(new string(blank, (n - 2) - i));
            }
            Console.Write(new string(blank, n - 2));
            Console.Write(new string(leaf, 1));
            Console.WriteLine(new string(blank, n - 2));
        }
    }
}
