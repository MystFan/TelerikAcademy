/*
 Problem 7. One system to any other

    Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */
namespace _07.OneSystemToAnyOther
{
    using Convertor;
    using System;
    class OneSystemToAnyOther
    {
        static void Main()
        {
            Convertor convertor = new Convertor();
            Console.Write("S = ");
            int fromBase = int.Parse(Console.ReadLine());
            Console.Write("D = ");
            int toBase = int.Parse(Console.ReadLine());
            Console.Write("Number: ");
            string number = Console.ReadLine();
            string result = convertor.ConvertFromTo(number, fromBase, toBase);
            Console.WriteLine(result);
        }
    }
}
