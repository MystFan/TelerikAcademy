/*
 Problem 10. Unicode characters

    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.
 */
namespace _10.UnicodeCharacters
{
    using System;
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            ConvertToLiteralsSequence(input);
        }

        private static void ConvertToLiteralsSequence(string text)
        {
            string format = String.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                format = String.Format("\\u{0}", ((int)text[i]).ToString("X").PadLeft(4, '0'));
                Console.Write(format);
            }
            Console.WriteLine();
        }
    }
}
