namespace _1C.FindAllMiddleNodes
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
                var input = Console.ReadLine().Split(' ');

                int parentNodeValue = int.Parse(input[0]);
                int childNodeValue = int.Parse(input[1]);

                nodes[parentNodeValue].Childrens.Add(nodes[childNodeValue]);
                nodes[childNodeValue].HasParent = true;
            }


            // C : find all middle nodes
            List<Node> middleNodes = FindMiddleNodes(nodes);
            var middleNodesValues = middleNodes.Select(n => n.Value);
            Console.WriteLine("Middle nodes values: {0}", string.Join(", ", middleNodesValues));
        }

        private static List<Node> FindMiddleNodes(Node[] nodes)
        {
            List<Node> middleNodes = new List<Node>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Childrens.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }
    }
}
