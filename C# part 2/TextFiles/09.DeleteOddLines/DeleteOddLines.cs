/*
 Problem 9. Delete odd lines

    Write a program that deletes from given text file all odd lines.
    The result should be in the same file.
 */
namespace _09.DeleteOddLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class DeleteOddLines
    {
        static void Main()
        {
            DeleteLines(@"..\..\task9.txt",LineOptions.Even);
        }

        private static void DeleteLines(string path,LineOptions option)
        {
            List<string> lines = new List<string>();
            List<string> linesToSave = new List<string>();
            StreamReader reader = new StreamReader(path);
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
                if (option == LineOptions.Odd)
                {
                    if (i % 2 != 0)
                    {
                        linesToSave.Add(lines[i]);
                    }
                }
                else if(option == LineOptions.Even)
                {
                    if (i % 2 == 0)
                    {
                        linesToSave.Add(lines[i]);
                    }
                }
            }
            StreamWriter writer = new StreamWriter(path);
            using (writer)
            {
                for (int i = 0; i < linesToSave.Count; i++)
                {
                    writer.WriteLine(linesToSave[i]);
                }
            }
        }
    }
}
