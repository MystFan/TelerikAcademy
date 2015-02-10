
namespace DiamondTrolls
{
    using System;
    class DiamondTrolls
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char star = '*';
            char blank = '.';

            int width = 2 * n + 1;
            Console.Write(new String(blank, (n / 2) + 1));
            Console.Write(new String(star, n));
            Console.WriteLine(new String(blank, (n / 2) + 1));
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new String(blank, (n / 2) - i));
                Console.Write(new String(star, 1));
                Console.Write(new String(blank, (n / 2) + i));
                Console.Write(new String(star, 1));
                Console.Write(new String(blank, (n / 2) + i));
                Console.Write(new String(star, 1));
                Console.WriteLine(new String(blank, (n / 2) - i));
            }
            Console.WriteLine(new String(star, width));

            for (int j = n - 1; j > 0; j--)
            {
                Console.Write(new String(blank, n - j));
                Console.Write(new String(star, 1));
                Console.Write(new String(blank, j - 1));
                Console.Write(new String(star, 1));
                Console.Write(new String(blank, j - 1));
                Console.Write(new String(star, 1));
                Console.WriteLine(new String(blank, n - j));
            }

            Console.Write(new String(blank, n));
            Console.Write(new String(star, 1));
            Console.WriteLine(new String(blank, n));
        }
    }
}
