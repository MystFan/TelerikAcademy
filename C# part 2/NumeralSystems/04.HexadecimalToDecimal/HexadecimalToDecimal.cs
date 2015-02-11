/*
 Problem 4. Hexadecimal to decimal

    Write a program to convert hexadecimal numbers to their decimal representation.

 */
namespace _04.HexadecimalToDecimal
{
    using System;
    using Convertor;
    class HexadecimalToDecimal
    {
        static void Main()
        {
            Convertor convertor = new Convertor();
            Console.WriteLine("Enter hexadecimal number");
            string input = Console.ReadLine();
            bool isHexNumber = convertor.IsHex(input);
            if (isHexNumber)
            {
                long result = convertor.HexadecimalToDecimal(input);
                Console.WriteLine("Decimal number -->  {0}",result);
            }
            else
            {
                Console.WriteLine("Input number is not hexadecimal number");
            }
        }
    }
}
