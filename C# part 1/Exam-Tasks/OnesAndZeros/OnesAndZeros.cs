
namespace OnesAndZeros
{
    using System;
    class OnesAndZeros
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());

            string binary = Convert.ToString(n, 2).PadLeft(32, '0');
            string number = binary.Substring(16, 16);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if ((i == 0 || i == 4) && number[j] == '0')
                    {
                        Console.Write("###");
                    }
                    else if ((i == 0 || i == 2 || i == 3) && number[j] == '1')
                    {
                        Console.Write(".#.");
                    }
                    else if ((i == 1 || i == 2 || i == 3) && number[j] == '0')
                    {
                        Console.Write("#.#");
                    }
                    else if (i == 1 && number[j] == '1')
                    {
                        Console.Write("##.");
                    }
                    else if (i == 4 && number[j] == '1')
                    {
                        Console.Write("###");
                    }

                    if (j != number.Length - 1)
                    {
                        Console.Write('.');
                    }
                    else if (j == number.Length - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
