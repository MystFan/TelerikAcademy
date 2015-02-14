/*
 Problem 3. Read file contents

    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    Find in MSDN how to use System.IO.File.ReadAllText(…).
    Be sure to catch all possible exceptions and print user-friendly error messages.
 */
namespace _03.ReadFileContents
{
    using System;
    using System.IO;
    using System.Text;
    class ReadFileContents
    {
        static void Main()
        {
            try
            {
                string path = "..\\..\\test.txt";
                string content = ReadFileContent(path);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string ReadFileContent(string path)
        {
            string result = String.Empty;
            if (File.Exists(path))
            {
                result = File.ReadAllText(path,Encoding.UTF8);
            }
            return result;
        }
    }
}
