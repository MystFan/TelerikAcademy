/*
 Problem 2. Reverse string

    Write a program that reads a string, reverses it and prints the result at the console.
 */
namespace _02.ReverseString
{
    using System;
    class ReverseSring
    {
        static void Main()
        {
            Console.WriteLine("Enter string to reverse: ");
            string input = Console.ReadLine();
            string output = Reverse(input);
            Console.WriteLine("Reversed string");
            Console.WriteLine(output);
        }

        public static string Reverse(string str)
        {
            string revers = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revers = revers + str[i];
            }
            return revers;
        }
    }
}
