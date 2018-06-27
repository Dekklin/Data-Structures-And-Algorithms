using FizzBuzzTree;
using Xunit;
using static FizzBuzzTree.Program;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BinaryTree BT = new BinaryTree(new Node("5"));
            BT.Root.LeftChild = new Node("9");
            BT.Root.RightChild = new Node("4");
            BT.Root.LeftChild.LeftChild = new Node("30");
            BT.Root.RightChild.LeftChild = new Node("10");
            BT.Root.RightChild.RightChild = new Node("19");
            FizzBuzzTree.Program.FizzBuzzTree(BT.Root);


            Assert.Equal("Fizz", BT.Root.LeftChild.Value);
            Assert.Equal("19", BT.Root.RightChild.RightChild.Value);
            Assert.Equal("Buzz", BT.Root.RightChild.LeftChild.Value);
            Assert.Equal("FizzBuzz", BT.Root.LeftChild.LeftChild.Value);
        }
    }
}
