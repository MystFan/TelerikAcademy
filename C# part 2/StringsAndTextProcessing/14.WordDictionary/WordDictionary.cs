/*
 Problem 14. Word dictionary

    A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.

Sample dictionary:
  input 	        output
.NET 	    platform for applications from Microsoft
CLR 	    managed execution environment for .NET
namespace 	hierarchical organization of classes
 */
namespace _14.WordDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class WordDictionary
    {
        static List<string> listWords = new List<string>();
        static List<string> listExplanation = new List<string>();
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter dictionary row by row in format \"word-explanation\".After that push key \"End\" from keyboard");
            while (true)
            {
                string dictionary = Console.ReadLine();
                sb.Append(dictionary);
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.End)
                {
                    break;
                }
            }
            SplitDictionary(sb.ToString());
            Console.Clear();
            Console.WriteLine("Enter word for search");
            string word = Console.ReadLine();
            Console.WriteLine(SearchExplanation(word));
        }

        private static void SplitDictionary(string dictionary)
        {
            string[] split = dictionary.Split('-');
            for (int i = 0; i < split.Length - 1; i = i + 1)
            {
                listWords.Add(split[i].Trim());
            }
            for (int i = 1; i < split.Length; i = i + 1)
            {
                listExplanation.Add(split[i].Trim());
            }
        }

        private static string SearchExplanation(string word)
        {
            int position = -1;
            for (int i = 0; i < listWords.Count; i++)
            {
                if (word == listWords[i])
                {
                    position = i;
                    break;
                }
            }
            if (position >= 0)
            {
                return listWords[position] + " - " + listExplanation[position];
            }
            else
            {
                return "Haven't this word";
            }

        }
    }
}
