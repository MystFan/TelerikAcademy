/*
 Problem 11. Prefix "test"

    Write a program that deletes from a text file all words that start with the prefix test.
    Words contain only the symbols 0…9, a…z, A…Z, _.
 */
namespace _11.PrefixTest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    class PrefixTest
    {
        static void Main()
        {
            string path = @"..\..\task11.txt";
            DeleteWordsFromTextFile(path, "test");
        }

        private static void DeleteWordsFromTextFile(string path, string prefix)
        {
            StreamReader reader = new StreamReader(path);
            string[] symbols = new string[] { " " };
            List<string> listLines = new List<string>();
            StringBuilder sb = new StringBuilder();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] words = line.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!words[i].StartsWith(prefix))
                        {
                            sb.Append(words[i] + " ");
                        }
                    }
                    listLines.Add(sb.ToString());
                    sb.Clear();
                    line = reader.ReadLine();
                }

            }
            StreamWriter writer = new StreamWriter(path);
            using (writer)
            {
                for (int i = 0; i < listLines.Count; i++)
                {
                    writer.WriteLine(listLines[i]);
                }
            }
        }
    }
}
