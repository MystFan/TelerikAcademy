/*
 Problem 24. Order words

    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

 */
namespace _24.OrderWords
{
    using System;
    using System.Globalization;
    class OrderWords
    {
        static void Main()
        {
            string listOfWords = "Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order";
            PrintWords(AlphabeticalOrder(listOfWords));
        }

        private static string[] AlphabeticalOrder(string text)
        {
            string[] words = text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words, (x, y) => String.Compare(x,y,true));
            return words;
        }

        private static void PrintWords(string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }
    }
}
