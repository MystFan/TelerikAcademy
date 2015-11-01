namespace _1D.FindLongestPath
{
    using System;
    using System.IO;
    using Nodes;

    public class Program
    {
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

            int longestPath = LongestPath(FindRoot(nodes));
            Console.Write("Longest path: {0}", longestPath);
        }

        private static int LongestPath(Node node)
        {
            if(node.Childrens.Count == 0)
            {
                return 0;
            }

            int currentLength = 0;

            for (int i = 0; i < node.Childrens.Count; i++)
            {
                currentLength = Math.Max(currentLength, LongestPath(node.Childrens[i]));
            }

            return currentLength + 1;
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
