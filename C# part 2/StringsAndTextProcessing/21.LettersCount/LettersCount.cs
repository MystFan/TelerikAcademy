/*
 Problem 21. Letters count

    Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
 */
namespace _21.LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    class LettersCount
    {
        static void Main()
        {
            string input = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
            PrintDiffrentLetters(RepeatLetters(input));
        }

        private static Dictionary<char,int> RepeatLetters(string text)
        {
            List<char> letters = new List<char>();
            Dictionary<char, int> diffrentLetters = new Dictionary<char, int>();

            for (int i = 0; i < text.Length - 1; i++)
            {
                char currentletter = text[i];
                if (char.IsLetter(currentletter))
                {
                    if (!letters.Contains(currentletter))
                    {
                        letters.Add(currentletter);
                        diffrentLetters.Add(currentletter, 1);
                    }
                    if (letters.Contains(currentletter))
                    {
                        diffrentLetters[currentletter]++;
                    }
                }
            }
            return diffrentLetters;
        }

        private static void PrintDiffrentLetters(Dictionary<char, int> letters)
        {
            foreach (var letter in letters)
            {
                Console.WriteLine("{0}({1} times)",letter.Key,letter.Value);
            }
        }
    }
}
