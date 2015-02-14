/*
 Problem 6. String length

    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
    Print the result string into the console.
 */
namespace _06.StringLength
{
    using System;
    static class StringLength
    {
        static void Main()
        {
            string example = "example".FillRight(20, '*');
            Console.WriteLine(example);
        }

        private static string FillRight(this string str,int length, char symbol)
        {
            string result = str;
            if (str.Length < length)
            {
                for (int i = str.Length; i < length; i++)
                {
                    result += symbol.ToString();
                }
            }
            return result;
        }
    }
}
