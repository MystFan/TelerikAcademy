using System;
/*
 Problem 15. Hexadecimal to Decimal Number

   - Using loops write a program that converts a hexadecimal integer number to its decimal form.
   - The input is entered as string. The output should be a variable of type long.
   - Do not use the built-in .NET functionality.
 */

namespace _15.HexadecimalToDecimalNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter hexadecimal integer number: ");
            string hexNumber = Console.ReadLine();

            long decimalNumber = 0;
            int position = hexNumber.Length - 1;
            long powerNumber = 1;
            for (int i = 0; i < hexNumber.Length; i++)
            {
                char symbol = hexNumber[i];
                int digit;
                switch (symbol)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9': digit = int.Parse(symbol.ToString()); break;
                    case 'A': digit = 10; break;
                    case 'B': digit = 11; break;
                    case 'C': digit = 12; break;
                    case 'D': digit = 13; break;
                    case 'E': digit = 14; break;
                    case 'F': digit = 15; break;
                    default: digit = 0; break;
                }
                for (int j = 0; j < position; j++)
                {
                    powerNumber = powerNumber * 16;
                }
                decimalNumber += digit * powerNumber;
                powerNumber = 1;
                position--;
            }
            Console.WriteLine("{0} --> {1}", hexNumber, decimalNumber);
        }
    }
}
