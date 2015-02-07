/*
 Problem 12. Index of letters

    Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.

 */
namespace _12.IndexOfLetters
{
    using System;
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = Convert.ToChar(65 + i);
            }

            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i].ToString().ToLower() == alphabet[j].ToString().ToLower())
                    {
                        Console.WriteLine("[{0}] {1}",j + 1, word[i]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
