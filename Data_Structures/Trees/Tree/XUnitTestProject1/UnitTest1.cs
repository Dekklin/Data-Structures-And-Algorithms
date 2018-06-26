using System;
using Tree;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void BinaryTreeTest()
        {
            BinaryTree BT = new BinaryTree(new Node(5));
            BT.Root.LeftChild = new Node(8);
            BT.Root.RightChild = new Node(3);
            BT.Root.LeftChild.LeftChild = new Node(9);
            BT.Root.RightChild.LeftChild = new Node(10);
            BT.Root.RightChild.RightChild = new Node(11);
            BT.BreadthFirst(BT.Root);
            Assert.Equal(9, BT.Search(BT.Root, 9).Value);
            Assert.Equal(3, BT.Search(BT.Root, 3).Value);
            Assert.Equal(8, BT.Search(BT.Root, 8).Value);

        }
        [Fact]
        public void BSTtest()
        {
            BinarySearchTree BST = new BinarySearchTree(new Node(50));
            BST.AddNode(35, BST.Root);
            BST.AddNode(60, BST.Root);
            BST.AddNode(15, BST.Root);
            Assert.Equal(25, BST.AddNode(25, BST.Root).Value);
            // because it already exists
            Assert.Null(BST.AddNode(60, BST.Root));
            Assert.Equal(75, BST.AddNode(75, BST.Root).Value);

        }
    }
}
