using System.Collections.Generic;
using System.IO;

namespace Lab1
{
    public class TreeNode
    {
        private readonly List<TreeNode> nextNodes;

        public IEnumerable<TreeNode> Next => nextNodes;

        public int Value { get; set; }

        public TreeNode(int value)
        {
            nextNodes = new List<TreeNode>();
            Value = value;
        }

        public TreeNode CreateNext(int value)
        {
            TreeNode node = new TreeNode(value);
            nextNodes.Add(node);
            return node;
        }
    }
}
