using System;
using Tree;
using Xunit;
using static FindMaxValueInTree.Program;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BinaryTree BT = new BinaryTree(new Node(5));

            BT.Root.LeftChild = new Node(9);
            BT.Root.RightChild = new Node(4);
            BT.Root.LeftChild.LeftChild = new Node(30);
            BT.Root.RightChild.LeftChild = new Node(24);
            BT.Root.RightChild.RightChild = new Node(17);
            BT.Root.RightChild.RightChild.RightChild = new Node(69);

            Assert.Equal(69, FindMax(BT.Root));

            BT.Root.LeftChild = new Node(9);
            BT.Root.RightChild = new Node(4);
            BT.Root.LeftChild.LeftChild = new Node(100);
            BT.Root.RightChild.LeftChild = new Node(24);
            BT.Root.RightChild.RightChild = new Node(17);
            BT.Root.RightChild.RightChild.RightChild = new Node(69);

            Assert.Equal(100, FindMax(BT.Root));

            BT.Root.LeftChild = new Node(9);
            BT.Root.RightChild = new Node(9001);
            BT.Root.LeftChild.LeftChild = new Node(30);
            BT.Root.RightChild.LeftChild = new Node(24);
            BT.Root.RightChild.RightChild = new Node(17);
            BT.Root.RightChild.RightChild.RightChild = new Node(69);

            Assert.Equal(9001, FindMax(BT.Root));

        }
    }
}
