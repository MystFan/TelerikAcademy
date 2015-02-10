
namespace ukFlag
{
    using System;
    class ukFlag
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char blank = '.';
            char flagLeft = '\\';
            char flagRight = '/';
            char flagMiddle = '|';
            char middleFlag = '-';
            char centerFlag = '*';
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(blank, i));
                Console.Write(flagLeft);
                Console.Write(new string(blank, (n / 2) - (i + 1)));
                Console.Write(flagMiddle);
                Console.Write(new string(blank, (n / 2) - (i + 1)));
                Console.Write(flagRight);
                Console.WriteLine(new string(blank, i));
            }
            Console.Write(new string(middleFlag, n / 2));
            Console.Write(centerFlag);
            Console.WriteLine(new string(middleFlag, n / 2));
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(blank, (n / 2) - (i + 1)));
                Console.Write(flagRight);
                Console.Write(new string(blank, i));
                Console.Write(flagMiddle);
                Console.Write(new string(blank, i));
                Console.Write(flagLeft);
                Console.WriteLine(new string(blank, (n / 2) - (i + 1)));
            }
        }
    }
}
