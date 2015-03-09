/*
 Problem 2. Concatenate text files

    Write a program that concatenates two text files into another text file.
 */
namespace _02.ConcatenateTextFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class ConcatenateTextFiles
    {
        static void Main()
        {
            string firstFilePath = @"..\..\firstFile.txt";
            string secondFilePath = @"..\..\secondFile.txt";
            string resultFilePath = @"..\..\concatFile.txt";
            ConcatTextFiles(firstFilePath, secondFilePath, resultFilePath);
        }

        private static void ConcatTextFiles(string filePathOne, string filePathTwo, string destinationPath)
        {
            StreamReader firstFile = new StreamReader(filePathOne);
            StreamReader secondFile = new StreamReader(filePathTwo);
            StreamWriter newFile = new StreamWriter(destinationPath);
            string lineFirstFile = String.Empty;
            string lineSecondFile = String.Empty;
            string lineNewFile = String.Empty;
            List<string> list = new List<string>();

            using (firstFile)
            {
                lineFirstFile = firstFile.ReadLine();
                while (lineFirstFile != null)
                {
                    list.Add(lineFirstFile);
                    lineFirstFile = firstFile.ReadLine();
                }
            }

            using (secondFile)
            {
                lineSecondFile = secondFile.ReadLine();
                while (lineSecondFile != null)
                {
                    list.Add(lineSecondFile);
                    lineSecondFile = secondFile.ReadLine();
                }
            }

            using (newFile)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    newFile.WriteLine(list[i]);
                }
            }
        }
    }
}
