/*
 Problem 13. Count words

    Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
    The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
    Handle all possible exceptions in your methods.
 */
namespace _13.CountWords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    class CountWords
    {
        static void Main()
        {
            string wordsPath = @"..\..\words.txt";
            List<string> listWords = ReadLines(wordsPath);
            Dictionary<string, int> result = WordsCount(listWords, @"..\..\test.txt");
            SaveResult(result, @"..\..\result.txt");
        }

        private static Dictionary<string, int> WordsCount(List<string> words, string textPath)
        {
            List<string> lines = ReadLines(textPath);
            string[] symbols = new string[] { " ",".",",","!","?" };
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < lines.Count; i++)
            {
                string[] wordsToCount = lines[i].Split(symbols, StringSplitOptions.RemoveEmptyEntries);
                for (int k = 0; k < words.Count; k++)
                {
                    int count = wordsToCount.Where(w => w.Equals(words[k])).Count();
                    if (wordsToCount.FirstOrDefault(item => item == words[k]) != null)
                    {
                        if (dictionary.Keys.FirstOrDefault(item => item == words[k]) != null)
                        {
                            dictionary[words[k]]++;
                        }
                    }
                    if (dictionary.Keys.FirstOrDefault(item => item == words[k]) == null)
                    {
                        dictionary.Add(words[k], 1);
                    }
                }
            }

            return dictionary;
        }

        private static void SaveResult(Dictionary<string, int> result, string path)
        {
            StreamWriter writer = new StreamWriter(path);
            using (writer)
            {
                foreach (var item in result)
                {
                    writer.WriteLine("{0} ({1} times)", item.Key, item.Value);
                }
            }
        }
        private static List<string> ReadLines(string path)
        {
            List<string> lines = new List<string>();
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    lines.Add(line.Trim());
                    line = reader.ReadLine();
                }
            }
            return lines;
        }
    }
}
