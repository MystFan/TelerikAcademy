using System;
/*
 Problem 8. Isosceles Triangle

    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
 */
namespace _08.IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine('\u00A9'.ToString().PadLeft(4,' '));
            Console.WriteLine();
            Console.Write('\u00A9'.ToString().PadLeft(3, ' '));
            Console.Write(' ');
            Console.WriteLine('\u00A9');
            Console.WriteLine();
            Console.Write('\u00A9'.ToString().PadLeft(2, ' '));
            Console.Write("   ");
            Console.WriteLine('\u00A9');
            Console.WriteLine();
            for (int i = 1; i < 8; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write('\u00A9');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}
