/*
 Problem 1. Odd lines

    Write a program that reads a text file and prints on the console its odd lines.
 */
namespace _01.OddLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class OddLines
    {
        static void Main()
        {
            string filePath = @"..\..\OddLines.txt";
            PrintFileOddLines(filePath);
        }

        private static void PrintFileOddLines(string path)
        {
            List<string> list = new List<string>();
            string line = String.Empty;
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                int lineNumber = 1;
                line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        list.Add(line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
