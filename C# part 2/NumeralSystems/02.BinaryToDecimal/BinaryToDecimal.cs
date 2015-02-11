
namespace _02.BinaryToDecimal
{
    using System;
    using Convertor;
    class BinaryToDecimal
    {
        static void Main()
        {
            Convertor convertor = new Convertor();
            Console.Write("Enter Binary Number:");
            string binary = Console.ReadLine();
            Console.WriteLine("Binary To Decimal: {0}", convertor.BinaryToDecimal(binary));
        }
    }
}
