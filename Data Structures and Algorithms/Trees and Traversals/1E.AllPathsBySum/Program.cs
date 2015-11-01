namespace _1E.AllPathsBySum
{
    using System;
    using System.IO;
    using Nodes;

    public class Program
    {
        private const int S = 8;
        private static int pathsCounter = 0;

        public static void Main()
        {
            StreamReader reader = new StreamReader("../../input.txt");
            Console.SetIn(reader);

            int treeSize = int.Parse(Console.ReadLine());

            Node[] nodes = new Node[treeSize];
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = new Node(i);
            }

            for (int i = 0; i < nodes.Length - 1; i++)
            {
                var input = Console.ReadLine().Split(' ');

                int parentNodeValue = int.Parse(input[0]);
                int childNodeValue = int.Parse(input[1]);

                nodes[parentNodeValue].Childrens.Add(nodes[childNodeValue]);
                nodes[childNodeValue].HasParent = true;
            }

            Node root = FindRoot(nodes);
            ProcessPaths(root, 0);
            Console.WriteLine("Paths with S = {0} --> {1}", S, pathsCounter);
        }

        private static void ProcessPaths(Node currentNode, int currentSum)
        {
            currentSum += currentNode.Value;
            if(currentSum == S)
            {
                pathsCounter++;
            }

            for (int i = 0; i < currentNode.Childrens.Count; i++)
            {
                ProcessPaths(currentNode.Childrens[i], currentSum);
            }
        }

        private static Node FindRoot(Node[] nodes)
        {
            Node root = null;
            foreach (var node in nodes)
            {
                if (!node.HasParent)
                {
                    root = node;
                }
            }

            return root;
        }
    }
}
