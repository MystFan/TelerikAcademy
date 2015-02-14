/*
 Problem 11. Format number

    Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
    Format the output aligned right in 15 symbols.
 */
namespace _11.FormatNumber
{
    using System;
using System.Collections;
    class FormatNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                PrintNumber(number);
            }
        }

        private static void PrintNumber(IComparable number)
        {
            string hexFormat = String.Format("Hex Format:{0,15:X}", number);
            string percentage = String.Format("Percentage Format:{0,15:P2}", number);
            string sNotation = String.Format("Scientific Notation Format:{0,15:G2}", number);
            Console.WriteLine(hexFormat);
            Console.WriteLine(percentage);
            Console.WriteLine(sNotation);
        }
    }
}
