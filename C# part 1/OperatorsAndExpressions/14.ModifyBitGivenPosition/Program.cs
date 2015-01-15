using System;
 
//Problem 14. Modify a Bit at Given Position

 //  - We are given an integer number n, a bit value v (v=0 or 1) and a position p.
 //  - Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

namespace _14.ModifyBitGivenPosition
{
    class Program
    {
        static void Main()
        {
            Console.Write("Number: ");
            string inputNumber = Console.ReadLine();
            Console.Write("Position: ");
            string inputPosition = Console.ReadLine();
            Console.Write("Enter bit 0 or 1: ");
            string inputBit = Console.ReadLine();
            int number;
            int position;
            int bitValue;
            bool isNumber = int.TryParse(inputNumber, out number);
            bool posIsNumber = int.TryParse(inputPosition, out position);
            bool bitValueIsNumber = int.TryParse(inputBit, out bitValue);
            if (isNumber && posIsNumber && bitValueIsNumber)
            {
                int mask;
                int result = 0;
                mask = 1 << position;
                bool isBitOne = ((number & mask) >> position) == 1;
                bool isBitZero = ((number & mask) >> position) == 0;
                if ((bitValue == 0 && !isBitZero) || (bitValue == 1 && !isBitOne))
                {
                    if (isBitOne)
                    {
                        mask = ~(mask);
                        result = number & mask;
                    }
                    if (isBitZero)
                    {
                        result = number | mask;
                    }
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(number);
                }
                
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
