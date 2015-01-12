using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12. Extract Bit from Integer

//   - Write an expression that extracts from given integer n the value of given bit at index p.

namespace _12.ExtractBitFromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            string inputNumber = Console.ReadLine();
            Console.WriteLine("Position: ");
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
