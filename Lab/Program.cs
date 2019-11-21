using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            Tree tree = new Tree();
            tree.LoadFromXML("tree.xml");

            Console.WriteLine(NodeCalculator.FindMaxPathSum(tree.Root));

            Console.WriteLine(NodeCalculator.Contains(tree.Root, 19));

            Console.WriteLine(NodeCalculator.FindMaxValue(tree.Root));
            Console.WriteLine(NodeCalculator.FindMinValue(tree.Root));

            tree.SaveXml("tree1.xml");
            tree.Clear();
            tree.SaveXml("tree2.xml");
        }
    }
}
