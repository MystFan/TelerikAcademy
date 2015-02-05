
namespace SandGlass
{
    using System;
    class SandGlass
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('*', N - (2 * i)));
                Console.WriteLine(new string('.', i));
            }

            for (int i = 0; i <= N / 2; i++)
            {
                Console.Write(new string('.', N / 2 - i));
                Console.Write(new string('*', (2 * i) + 1));
                Console.WriteLine(new string('.', N / 2 - i));
            }
        }
    }
}
