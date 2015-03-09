/*
 Problem 3. Line numbers

    Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
 */
namespace _03.LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class LineNumbers
    {
        static void Main()
        {
            string source = @"..\..\someText.txt";
            string destination = @"..\..\numberLines.txt";
            InsertNumberOnTextLine(source, destination);
        }

        private static void InsertNumberOnTextLine(string sourcePath, string destinationPath)
        {
            List<string> list = new List<string>();
            string line = String.Empty;
            int counterLines = 1;
            StreamReader reader = new StreamReader(sourcePath);
            StreamWriter write = new StreamWriter(destinationPath);
            using (reader)
            {
                line = reader.ReadLine();
                while (line != null)
                {
                    list.Add(counterLines.ToString() + ". " + line);
                    line = reader.ReadLine();
                    counterLines++;
                }
            }
            using (write)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    write.WriteLine(list[i]);
                }
            }
        }
    }
}
