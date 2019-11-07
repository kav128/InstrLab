using System;
using System.IO;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree;
            string json;
            using (StreamReader sr = new StreamReader("tree.json"))
            {
                json = sr.ReadToEnd();
                tree = new Tree(json);
            }

            Console.WriteLine(NodeCalculator.FindMaxPathSum(tree.Root));

            Console.WriteLine(NodeCalculator.Contains(tree.Root, 19));
        }
    }
}
