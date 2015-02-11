
namespace _06.BinaryToHexadecimal
{
    using System;
    using Convertor;
    class BinaryToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter binary number: ");
            string input = Console.ReadLine();
            Convertor convertor = new Convertor();
            bool isBinaryNumber = convertor.isBinary(input);
            if (isBinaryNumber)
            {
                string hexadecimalNumber = convertor.BinaryToHexadecimal(input);
                Console.WriteLine("Hexadecimal format -->  {0}",hexadecimalNumber);
            }
            else
            {
                Console.WriteLine("Input number is not in binary format");
            }
        }
    }
}
