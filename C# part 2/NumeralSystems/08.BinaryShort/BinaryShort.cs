/*
 Problem 8. Binary short

    Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
 */
namespace _08.BinaryShort
{
    using System;
    using Convertor;
    class BinaryShort
    {
        static void Main()
        {
            Console.Write("Enter sign short from -32768 to 32767: ");
            string input = Console.ReadLine();
            short number;
            bool isShort = short.TryParse(input, out number);
            if (isShort)
            {
                Convertor convertor = new Convertor();
                Console.WriteLine(convertor.DecimalToSignBinary(number));
            }
            else
            {
                Console.WriteLine("Input is not in corect format");
            }
        }
    }
}
