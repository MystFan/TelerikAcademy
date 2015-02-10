
namespace Eggcelent
{
    using System;
    class Eggcelent
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char blank = '.';
            char shell = '*';
            char core = '@';
            int height = n - 2;
            int count = 0;
            if (n > 5)
            {
                height = n / 2;
                count = n - (2 + height);
            }
            Console.Write(new String(blank, n + 1));
            Console.Write(new String(shell, n - 1));
            Console.WriteLine(new String(blank, n + 1));
            for (int i = 0; i < height; i++)
            {
                Console.Write(new String(blank, n - (1 + (2 * i))));
                Console.Write(shell);
                Console.Write(new String(blank, (n + 1) + (4 * i)));
                Console.Write(shell);
                Console.WriteLine(new String(blank, n - (1 + (2 * i))));
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(blank);
                Console.Write(shell);
                Console.Write(new String(blank, ((3 * n) + 1) - 4));
                Console.Write(shell);
                Console.WriteLine(blank);
            }
            Console.Write(blank);
            Console.Write(shell);
            for (int i = 1; i <= 3 * (n - 1); i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(core);
                }
                if (i % 2 == 0)
                {
                    Console.Write(blank);
                }
            }
            Console.Write(shell);
            Console.WriteLine(blank);
            Console.Write(blank);
            Console.Write(shell);
            for (int i = 1; i <= 3 * (n - 1); i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(blank);
                }
                if (i % 2 == 0)
                {
                    Console.Write(core);
                }
            }
            Console.Write(shell);
            Console.WriteLine(blank);
            for (int i = 0; i < count; i++)
            {
                Console.Write(blank);
                Console.Write(shell);
                Console.Write(new String(blank, ((3 * n) + 1) - 4));
                Console.Write(shell);
                Console.WriteLine(blank);
            }
            for (int i = height - 1; i >= 0; i--)
            {
                Console.Write(new String(blank, n - (1 + (2 * i))));
                Console.Write(shell);
                Console.Write(new String(blank, (n + 1) + (4 * i)));
                Console.Write(shell);
                Console.WriteLine(new String(blank, n - (1 + (2 * i))));
            }
            Console.Write(new String(blank, n + 1));
            Console.Write(new String(shell, n - 1));
            Console.WriteLine(new String(blank, n + 1));
        }
    }
}
