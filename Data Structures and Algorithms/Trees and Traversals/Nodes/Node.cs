namespace Nodes
{
    using System.Collections.Generic;

    public class Node
    {
        public Node()
        {
            this.Childrens = new List<Node>();
        }

        public Node(int value)
            : this()
        {
            this.Value = value;
        }

        public int Value { get; set; }

        public List<Node> Childrens { get; set; }

        public bool HasParent { get; set; }
    }
}
