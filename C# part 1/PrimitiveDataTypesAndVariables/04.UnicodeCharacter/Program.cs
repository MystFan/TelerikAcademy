using System;
/*
 Problem 4. Unicode Character

    Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.

Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.
 */

namespace _04.UnicodeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            char variable = '\u002A';
            Console.WriteLine(variable);
        }
    }
}
