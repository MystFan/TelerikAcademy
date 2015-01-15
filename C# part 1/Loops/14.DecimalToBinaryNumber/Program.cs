using System;
/*
 Problem 14. Decimal to Binary Number

    -Using loops write a program that converts an integer number to its binary representation.
    -The input is entered as long. The output should be a variable of type string.
    -Do not use the built-in .NET functionality.

 */
namespace _14.DecimalToBinaryNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            string input = Console.ReadLine();

            long decimalNumber;
            bool isNumber = long.TryParse(input, out decimalNumber);
            if (isNumber)
            {
                string currentBinary = String.Empty;
                string binaryNumber = String.Empty;
                long currentDecimal = decimalNumber;
                
                while (currentDecimal > 0)
                {
                    int bit = (int)currentDecimal % 2;
                    currentDecimal /= 2;
                    currentBinary += bit.ToString();
                }
                for (int i = currentBinary.Length - 1; i >= 0; i--)
                {
                    binaryNumber += currentBinary[i];
                }
                Console.WriteLine("{0} --> {1}",decimalNumber, binaryNumber);
            }
            else
            {
                Console.WriteLine("Input string was not in correct format");
            }
        }
    }
}
