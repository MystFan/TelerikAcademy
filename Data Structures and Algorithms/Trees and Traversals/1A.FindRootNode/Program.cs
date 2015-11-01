namespace _1A.FindRootNode
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

            // A : find root node
            Node root = FindRoot(nodes);
            Console.WriteLine("Root with value: {0}", root.Value);
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
