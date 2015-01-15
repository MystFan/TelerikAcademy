using System;

//Problem 15.* Bits Exchange

//    -Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

namespace _15.BitsExchange
{
    class Program
    {
        static void Main()
        {
            Console.Write("Number: ");
            string inputNumber = Console.ReadLine();

            long number;
            bool isNumber = long.TryParse(inputNumber, out number);
            
            if (isNumber)
            {
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

                long firstMask = 7 << 3;
                Console.WriteLine("mask 1");
                Console.WriteLine(Convert.ToString(firstMask, 2).PadLeft(32, '0'));

                long secondMask = 7 << 24;
                Console.WriteLine("mask 2");
                Console.WriteLine(Convert.ToString(secondMask, 2).PadLeft(32, '0'));

                long firstExtractNumber = number & firstMask;
                Console.WriteLine("first extract number");
                Console.WriteLine(Convert.ToString(firstExtractNumber, 2).PadLeft(32, '0'));

                long secondExtractNumber = number & secondMask;
                Console.WriteLine("second extract number");
                Console.WriteLine(Convert.ToString(secondExtractNumber, 2).PadLeft(32, '0'));

                number = number & (~firstExtractNumber);
                number = number & (~secondExtractNumber);
                firstExtractNumber = firstExtractNumber << 21;
                secondExtractNumber = secondExtractNumber >> 21;

                long sumExtractNumbers = firstExtractNumber | secondExtractNumber;
                Console.WriteLine("sum extract numbers");
                Console.WriteLine(Convert.ToString(sumExtractNumbers, 2).PadLeft(32, '0'));

                number = number | sumExtractNumbers;
                Console.WriteLine("New number");
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                Console.WriteLine("Decimal number --> {0}",number);

            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
