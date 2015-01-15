using System;
/*
 Problem 16. Decimal to Hexadecimal Number

    -Using loops write a program that converts an integer number to its hexadecimal representation.
    -The input is entered as long. The output should be a variable of type string.
    -Do not use the built-in .NET functionality.

 */

namespace _16.DecimalToHexadecimalNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            string input = Console.ReadLine();

            long decimalNumber;
            bool isValidNumber = long.TryParse(input, out decimalNumber);
            if (isValidNumber)
            {
                long currentNumber = decimalNumber;
                string currentHexNumber = String.Empty;
                long remainder = 0;
                while (currentNumber > 0)
                {
                    remainder = currentNumber % 16;
                    currentNumber /= 16;
                    switch (remainder)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:currentHexNumber += remainder; break;
                        case 10: currentHexNumber += 'A';  break;
                        case 11: currentHexNumber += 'B'; break;
                        case 12: currentHexNumber += 'C'; break;
                        case 13: currentHexNumber += 'D'; break;
                        case 14: currentHexNumber += 'E'; break;
                        case 15: currentHexNumber += 'F'; break;
                        default: currentHexNumber += 0; break;
                    }
                }

                string hexNumber = String.Empty;
                for (int i = currentHexNumber.Length - 1; i >= 0; i--)
                {
                    hexNumber += currentHexNumber[i];
                }
                Console.WriteLine(hexNumber);
            }
            else
            {
                Console.WriteLine("Input string was not in correct format");
            }
        }
    }
}
