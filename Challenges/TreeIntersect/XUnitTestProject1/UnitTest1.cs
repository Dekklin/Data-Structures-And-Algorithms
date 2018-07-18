using System;
using System.Collections.Generic;
using TreeIntersect;
using Xunit;
using static TreeIntersect.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindMatches()
        {
            BinaryTree BT = new BinaryTree(new Node(5));
            BT.Root.LeftChild = new Node(8);
            BT.Root.RightChild = new Node(3);
            BT.Root.LeftChild.LeftChild = new Node(9);
            BT.Root.RightChild.LeftChild = new Node(10);
            BT.Root.RightChild.RightChild = new Node(11);


            BinaryTree BT2 = new BinaryTree(new Node(8));
            BT2.Root.LeftChild = new Node(13);
            BT2.Root.RightChild = new Node(11);
            BT2.Root.LeftChild.LeftChild = new Node(2);
            BT2.Root.RightChild.LeftChild = new Node(19);
            BT2.Root.RightChild.RightChild = new Node(3);
            List<int> k = new List<int>() { 8, 11, 3 };
            Assert.Equal(k, TreeIntersection(BT, BT2));
        }
        [Fact]
        public void CanFindMoreMatches()
        {
            BinaryTree BT3 = new BinaryTree(new Node(49));
            BT3.Root.LeftChild = new Node(8);
            BT3.Root.RightChild = new Node(3);
            BT3.Root.LeftChild.LeftChild = new Node(9);
            BT3.Root.RightChild.LeftChild = new Node(22);
            BT3.Root.RightChild.RightChild = new Node(11);


            BinaryTree BT4 = new BinaryTree(new Node(8));
            BT4.Root.LeftChild = new Node(19);
            BT4.Root.RightChild = new Node(11);
            BT4.Root.LeftChild.LeftChild = new Node(49);
            BT4.Root.RightChild.LeftChild = new Node(22);
            BT4.Root.RightChild.RightChild = new Node(18);
            List<int> y = new List<int>() { 8, 49, 11, 22 };

            Assert.Equal(y, TreeIntersection(BT3, BT4));

        }
    }
}
