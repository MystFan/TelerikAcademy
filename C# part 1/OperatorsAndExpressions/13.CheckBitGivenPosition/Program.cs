using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 13. Check a Bit at Given Position

//    -Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

namespace _13.CheckBitGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            string inputNumber = Console.ReadLine();
            Console.Write("Position: ");
            string inputPosition = Console.ReadLine();
            int number;
            int position;
            bool isNumber = int.TryParse(inputNumber, out number);
            bool posIsNumber = int.TryParse(inputPosition, out position);
            if (isNumber && posIsNumber)
            {
                int mask = 1 << position;
                Console.WriteLine("Number");
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
                Console.WriteLine("Mask");
                Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));
                bool isBitOne = (number & mask) >> position == 1;
                Console.WriteLine("Bit is 1 --> {0}", isBitOne);
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
