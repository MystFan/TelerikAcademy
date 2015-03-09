/*
 Problem 7. Replace sub-string

    Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
    Ensure it will work with large files (e.g. 100 MB).
 */
namespace _07.ReplaceSubstring
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    class ReplaceSubstring
    {
        static void Main()
        {
            string path = @"..\..\task7.txt";
            ReplaceWord("start", "finish", path);
        }

        private static void ReplaceWord(string oldWord, string newWord, string path)
        {
            StreamReader reader = new StreamReader(path);
            List<string> lines = new List<string>();

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    lines.Add(line);
                    line = reader.ReadLine();
                }
            }

            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].Replace(oldWord, newWord);
            }

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
