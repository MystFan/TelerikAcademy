/*
 Problem 12. Remove words

    Write a program that removes from a text file all words listed in given another text file.
    Handle all possible exceptions in your methods.
 */
namespace _12.RemoveWords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class RemoveWords
    {
        static void Main()
        {
            string forbiddenWordsPath = @"..\..\forbiddenWords.txt";
            string textPath = @"..\..\text.txt";
            RemoveForbiddenWords(forbiddenWordsPath, textPath);
        }

        private static void RemoveForbiddenWords(string wordsPath, string textPath)
        {
            List<string> wordsToRemove = ReadLines(wordsPath);
            List<string> textLines = ReadLines(textPath);
            for (int i = 0; i < textLines.Count; i++)
            {
                string line = textLines[i];
                for (int j = 0; j < wordsToRemove.Count; j++)
                {
                    line = line.Replace(wordsToRemove[j], "");
                }
                textLines[i] = line;
            }
            WriteLines(textLines, textPath);
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

        private static void WriteLines(List<string> lines, string path)
        {
            StreamWriter writer = new StreamWriter(path);
            using (writer)
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }
    }
}
