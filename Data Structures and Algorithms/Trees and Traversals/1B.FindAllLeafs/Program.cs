namespace _1B.FindAllLeafs
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
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
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int parentNodeValue = int.Parse(input[0]);
                int childNodeValue = int.Parse(input[1]);

                nodes[parentNodeValue].Childrens.Add(nodes[childNodeValue]);
                nodes[childNodeValue].HasParent = true;
            }

            List<Node> leafs = FindLeafNodes(nodes);
            var leafValues = leafs.Select(n => n.Value);
            Console.WriteLine("Leaf nodes values: {0}", string.Join(", ", leafValues));
        }

        private static List<Node> FindLeafNodes(Node[] nodes)
        {
            List<Node> leafs = new List<Node>();

            foreach (var node in nodes)
            {
                if (node.Childrens.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }
    }
}
