using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 11. Bitwise: Extract Bit #3

//    -Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//    -The bits are counted from right to left, starting from bit #0.
//    -The result of the expression should be either 1 or 0.

namespace _11.ExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            string input = Console.ReadLine();

            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                int position = 3;
                int mask = 1 << position;
                Console.WriteLine("Number");
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
                Console.WriteLine("Mask");
                Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));
                int nAndMask = number & mask;
                int bit = nAndMask >> position;
                Console.WriteLine("Bit: {0}", bit);
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }

        }
    }
}
