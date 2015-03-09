/*
 Problem 6. Save sorted names

    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

Example:
input.txt 	output.txt
Ivan          George
Peter         Ivan
Maria         Maria
George 	      Peter
 */
namespace _06.SaveSortedNames
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class SaveSortedNames
    {
        private static List<string> list;
        static void Main()
        {
            string inputPath = @"..\..\inputNames.txt";
            list = ReadNames(inputPath);
            list.Sort();
            string outputPath = @"..\..\outputNames.txt";
            SaveNames(outputPath);
        }
        private static List<string> ReadNames(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<string> names = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    names.Add(line);
                    line = reader.ReadLine();
                }
            }
            return names;
        }
        private static void SaveNames(string path)
        {
            StreamWriter writer = new StreamWriter(path);
            using (writer)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine(list[i]);
                }
            }
        }
    }
}
