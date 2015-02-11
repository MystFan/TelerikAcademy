/*
 Problem 5. Hexadecimal to binary

    Write a program to convert hexadecimal numbers to binary numbers (directly).

 */
namespace _05.HexadecimalToBinary
{
    using System;
    using Convertor;
    class HexadecimalToBinary
    {
        static void Main()
        {
            Convertor convertor = new Convertor();
            Console.WriteLine("Enter hexadecimal number");
            string input = Console.ReadLine();
            bool isHexNumber = convertor.IsHex(input);
            if (isHexNumber)
            {
                string result = convertor.HexdecimalToBinary(input);
                Console.WriteLine("Decimal number -->  {0}", result);
            }
            else
            {
                Console.WriteLine("Input number is not hexadecimal number");
            }
        }
    }
}
