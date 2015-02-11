/*
 Problem 1. Decimal to binary

    Write a program to convert decimal numbers to their binary representation.

 */
namespace _01.DecimalToBinary
{
    using Convertor;
    using System;
    
    class DecimalToBinary
    {
        static void Main()
        {
            Convertor convertor = new Convertor();
            Console.Write("Enter Decimal Number:");
            string input = Console.ReadLine();
            long decimalNumber;
            bool isNumber = long.TryParse(input, out decimalNumber);
            if (isNumber)
            {
                Console.WriteLine("Number in Binary Conversion: {0}", convertor.DecimalToBinary(decimalNumber));
            }
        }
    }
}
