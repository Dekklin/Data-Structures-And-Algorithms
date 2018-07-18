using TreeIntersect;
using System;
using System.Collections.Generic;

namespace TreeIntersect
{
    public class Program
    {
        static void Main(string[] args)
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
            TreeIntersection(BT, BT2);

        }
        /// <summary>
        /// Adds two trees to a hashset through my custom PreOrder method
        /// </summary>
        /// <param name="BT1">Binary Tree with int's for values</param>
        /// <param name="BT2">Binary Tree #2 with ints as values</param>
        /// <returns>A List of common ints found in both Binary Trees</returns>
        public static List<int> TreeIntersection(BinaryTree BT1, BinaryTree BT2)
        {
            HashSet hs = new HashSet();
            BT1.PreOrder(hs, BT1.Root);
            BT2.PreOrder(hs, BT2.Root);
            foreach(int k in hs.repeats)
            {
                Console.WriteLine(k);
                Console.WriteLine("Should be 3, 8, 11");
            }
            return hs.repeats;
        }
    }
}
