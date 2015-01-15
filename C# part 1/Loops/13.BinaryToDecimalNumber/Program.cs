using System;
/*
 Problem 13. Binary to Decimal Number

    -Using loops write a program that converts a binary integer number to its decimal form.
    -The input is entered as string. The output should be a variable of type long.
    -Do not use the built-in .NET functionality.

 */

namespace _13.BinaryToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number = ");
            string binaryNumber = Console.ReadLine();

            long decimalNumber = 0;
            int position = binaryNumber.Length - 1;
            long powerNumber = 1;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int bit = int.Parse(binaryNumber[i].ToString());
                for (int j = 0; j < position; j++)
                {
                    powerNumber = powerNumber * 2;
                }
                decimalNumber += bit * powerNumber;
                powerNumber = 1;
                position--;
            }
            Console.WriteLine("{0} --> {1}",binaryNumber, decimalNumber);
        }
    }
}
