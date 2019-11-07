using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace UnitTestLab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRootValue()
        {
            TreeNode node = TreeNode.FromJsonFile("test1.json");
            Assert.AreEqual(15, node.Value);
        }

        [TestMethod]
        public void TestContains1()
        {
            TreeNode node = TreeNode.FromJsonFile("test1.json");
            bool result = NodeCalculator.Contains(node, 5);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestContains2()
        {
            TreeNode node = TreeNode.FromJsonFile("test1.json");
            bool result = NodeCalculator.Contains(node, 15);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMinPath()
        {
            TreeNode node = TreeNode.FromJsonFile("test2.json");
            int result = NodeCalculator.FindMinPathSum(node);
            Assert.AreEqual(35, result);
        }

        [TestMethod]
        public void TestMaxPath()
        {
            TreeNode node = TreeNode.FromJsonFile("test2.json");
            int result = NodeCalculator.FindMaxPathSum(node);
            Assert.AreEqual(193, result);
        }

        [TestMethod]
        public void TestCount1()
        {
            TreeNode node = TreeNode.FromJsonFile("test1.json");
            int result = NodeCalculator.CountAll(node);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestCount2()
        {
            TreeNode node = TreeNode.FromJsonFile("test2.json");
            int result = NodeCalculator.CountAll(node);
            Assert.AreEqual(8, result);
        }
    }
}
