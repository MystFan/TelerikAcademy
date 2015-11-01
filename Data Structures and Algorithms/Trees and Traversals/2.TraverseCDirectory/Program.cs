namespace _2.TraverseCDirectory
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Nodes;

    public class Program
    {
        public static void Main()
        {
            try
            {
                string dirPath = @"C:\WINDOWS"; // "../../../../Trees and Traversals"

                TraverseDirectory(dirPath);
            }
            catch (UnauthorizedAccessException unauthorizedEx)
            {
                Console.WriteLine(unauthorizedEx.Message);
            }
            catch (PathTooLongException pathEx)
            {
                Console.WriteLine(pathEx.Message);
            }
        }

        public static void TraverseDirectory(string path)
        {
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(path));
            List<string> files = new List<string>(Directory.GetFiles(path));

            foreach (var file in files)
            {
                if (file.EndsWith(".exe"))
                {
                    Console.WriteLine(file);
                }
            }

            foreach (var dir in dirs)
            {
                TraverseDirectory(dir);
            }
        }
    }
}
