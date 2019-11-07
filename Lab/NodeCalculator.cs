using System;
using System.Linq;

namespace Lab1
{
    public static class NodeCalculator
    {
        public static int FindMinPathSum(TreeNode node)
        {
            if (node.Next.Count() == 0)
                return node.Value;
            return node.Value + node.Next.Min(cur => FindMinPathSum(cur));
        }
        public static int FindMaxPathSum(TreeNode node)
        {
            if (node.Next.Count() == 0)
                return node.Value;
            return node.Value + node.Next.Max(cur => FindMaxPathSum(cur));
        }

        public static int CountAll(TreeNode node) => node.Next.Select(cur => CountAll(cur)).Sum() + 1;

        public static bool Contains(TreeNode node, int value) =>
            node.Value == value
            || node.Next.Select(cur => Contains(cur, value)).Contains(true);
    }
}
