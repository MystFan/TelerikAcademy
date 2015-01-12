using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 1. Odd or Even Integers

//   - Write an expression that checks if given integer is odd or even.

namespace _01.OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Number {0} is even --> {1}", number);
                }
                if (number % 2 != 0)
                {
                    Console.WriteLine("Number {0} is odd", number);
                }
            }
        }
    }
}
