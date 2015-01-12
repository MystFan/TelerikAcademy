using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumbersFrom1ToN
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int n;
            bool isValidNumber = int.TryParse(input, out n);
            if (isValidNumber)
            {
                if (n > 0)
                {
                    Console.WriteLine("N = {0}", n);
                    Console.WriteLine("Numbers");
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("N should be greater than 0");
                }
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }

        }
    }
}
