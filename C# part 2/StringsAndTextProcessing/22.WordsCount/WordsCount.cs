/*
 Problem 22. Words count

    Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
 */
namespace _22.WordsCount
{
    using System;
    using System.Collections.Generic;
    class WordsCount
    {
        static void Main()
        {
            string input = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
            PrintDiffrentWords(RepeatWords(input));
        }

        private static Dictionary<string, int> RepeatWords(string text)
        {
            List<string> words = new List<string>();
            Dictionary<string, int> diffrentWords = new Dictionary<string, int>();
            char[] splitChars = new char[] { ',', '.', '-', '(', ')',' '};
            string[] splitText = text.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitText.Length - 1; i++)
            {
                string currentWord = splitText[i];

                if (!words.Contains(currentWord))
                {
                    words.Add(currentWord);
                    diffrentWords.Add(currentWord, 1);
                }
                if (words.Contains(currentWord))
                {
                    diffrentWords[currentWord]++;
                }

            }
            return diffrentWords;
        }

        private static void PrintDiffrentWords(Dictionary<string, int> letters)
        {
            foreach (var letter in letters)
            {
                Console.WriteLine("{0}({1} times)", letter.Key, letter.Value);
            }
        }
    }
}
