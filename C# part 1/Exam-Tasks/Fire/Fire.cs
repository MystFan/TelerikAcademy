
namespace Fire
{
    using System;
    class Fire
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int middle = 2;
            for (int i = 0; i < (n / 2); i++)
            {
                Console.Write(new string('.', (n / 2) - 1 - i));
                Console.Write('#');
                if (i != 0)
                {
                    Console.Write(new string('.', middle));
                    middle += 2;
                }
                Console.Write('#');
                Console.WriteLine(new string('.', (n / 2) - 1 - i));
            }
            middle = n - 2;
            for (int i = 0; i < n / 4; i++)
            {
                Console.Write(new string('.', i));
                Console.Write('#');
                Console.Write(new string('.', middle - (2 * i)));
                Console.Write('#');
                Console.WriteLine(new string('.', i));
            }

            Console.WriteLine(new string('-', n));
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('\\', (n / 2) - i));
                Console.Write(new string('/', (n / 2) - i));
                Console.WriteLine(new string('.', i));
            }
        }
    }
}
