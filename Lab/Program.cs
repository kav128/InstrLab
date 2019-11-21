using System;
using System.IO;
using System.Xml.Serialization;

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

            Console.WriteLine(NodeCalculator.FindMaxValue(tree.Root));
            Console.WriteLine(NodeCalculator.FindMinValue(tree.Root));

            using (TextWriter stream = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(tree.Root.GetType());
                serializer.Serialize(stream, tree.Root);
                Console.WriteLine(stream.ToString());
            }

            Console.WriteLine(tree.Root.Next.Count);
        }
    }
}
