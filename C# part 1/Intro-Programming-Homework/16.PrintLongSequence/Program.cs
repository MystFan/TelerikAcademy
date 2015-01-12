using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i * (-1) + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
