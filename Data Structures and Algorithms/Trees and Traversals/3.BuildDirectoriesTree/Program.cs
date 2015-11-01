namespace _3.BuildDirectoriesTree
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Nodes;

    public class Program
    {
        private static long currentFileSizesSum = 0;

        public static void Main()
        {
            try
            {
                string dirPath = "../../../../Trees and Traversals";

                TreeNode<string> root = new TreeNode<string>();
                root.Value = dirPath;
                Folder rootFolder = new Folder();
                rootFolder.Name = dirPath;

                List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));

                var treeFolder = BuildTree(rootFolder);
                SumFileSizes(treeFolder);
                Console.WriteLine(treeFolder.Name);
                Console.WriteLine("Sum of file sizes: {0}", currentFileSizesSum);
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

        private static void SumFileSizes(Folder treeFolder)
        {
            for (int i = 0; i < treeFolder.Files.Length; i++)
            {
                currentFileSizesSum += treeFolder.Files[i].Size;
            }

            foreach (var folder in treeFolder.ChildFolders)
            {
                SumFileSizes(folder);
            }
        }

        public static Folder BuildTree(Folder rootFolder)
        {
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(rootFolder.Name));
            List<string> files = new List<string>(Directory.GetFiles(rootFolder.Name));
            DirectoryInfo currentDirectory = new DirectoryInfo(rootFolder.Name);
            FileInfo[] fileInfos = currentDirectory.GetFiles();

            rootFolder.Files = new File[files.Count];
            for (int i = 0; i < files.Count; i++)
            {
                rootFolder.Files[i] = new File();
                rootFolder.Files[i].Name = files[i];
                rootFolder.Files[i].Size = fileInfos[i].Length;
            }

            rootFolder.ChildFolders = new Folder[dirs.Count];
            for (int i = 0; i < dirs.Count; i++)
            {
                rootFolder.ChildFolders[i] = new Folder();
                rootFolder.ChildFolders[i].Name = dirs[i];
            }

            foreach (var subFolder in rootFolder.ChildFolders)
            {
                BuildTree(subFolder);
            }

            return rootFolder;
        }
    }
}
