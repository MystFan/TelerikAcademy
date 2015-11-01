namespace Nodes
{
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        public TreeNode()
        {
            this.Childrens = new List<TreeNode<T>>();
        }

        public TreeNode(T value)
            : this()
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public List<TreeNode<T>> Childrens { get; set; }

        public bool HasParent { get; set; }
    }
}
