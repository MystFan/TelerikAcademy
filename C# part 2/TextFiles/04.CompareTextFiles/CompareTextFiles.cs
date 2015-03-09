/*
 Problem 4. Compare text files

    Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
    Assume the files have equal number of lines.
 */
namespace _04.CompareTextFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class CompareTextFiles
    {
        static void Main()
        {
            string firstPath = @"..\..\firstText.txt";
            string secondPath = @"..\..\secondText.txt";
            PrintEqualLinesCount(firstPath, secondPath);
        }

        private static List<string> ExtractFileLines(string path)
        {
            List<string> lines = new List<string>();
            StreamReader reader = new StreamReader(path);
            string line = String.Empty;
            using (reader)
            {
                line = reader.ReadLine();
                while (line != null)
                {
                    lines.Add(line);
                    line = reader.ReadLine();
                }
            }
            return lines;
        }
        private static void PrintEqualLinesCount(string pathOne, string pathTwo)
        {
            List<string> firstFileLines = ExtractFileLines(pathOne);
            List<string> secondFileLines = ExtractFileLines(pathTwo);

            int equalLines = 0;
            int differentLines = 0;
            if (firstFileLines.Count == secondFileLines.Count)
            {
                for (int i = 0; i < firstFileLines.Count; i++)
                {
                    if (firstFileLines[i] == secondFileLines[i])
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }
                }
            }

            if (firstFileLines.Count > secondFileLines.Count)
            {
                for (int i = 0; i < secondFileLines.Count; i++)
                {
                    if (firstFileLines[i] == secondFileLines[i])
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }
                }
                // diffrentLines = diffrentLines + (list1.Count - list2.Count);
            }
            if (firstFileLines.Count < secondFileLines.Count)
            {
                for (int i = 0; i < firstFileLines.Count; i++)
                {
                    if (firstFileLines[i] == secondFileLines[i])
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }
                }
                // diffrentLines = diffrentLines + (list2.Count - list1.Count);
            }
            Console.WriteLine("{0} equal lines", equalLines);
            Console.WriteLine("{0} different lines", differentLines);
        }
    }
}
