/*
 Problem 3. Decimal to hexadecimal

    Write a program to convert decimal numbers to their hexadecimal representation.

 */
namespace _03.DecimalToHexadecimal
{
    using System;
    using Convertor;
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Convertor convertor = new Convertor();
            Console.Write("Enter Decimal Number:");
            string input = Console.ReadLine();
            long number;
            bool isNumber = long.TryParse(input, out number);
            if (isNumber)
            {
                Console.Write("Hex -->   ");
                Console.WriteLine(convertor.DecimalToHexadecimal(number));
            }
        }
    }
}
