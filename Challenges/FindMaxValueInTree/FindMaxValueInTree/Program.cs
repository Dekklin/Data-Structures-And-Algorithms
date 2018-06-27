using System;
using Tree;

namespace FindMaxValueInTree
{
    static public class Program
    {
        /// <summary>
        /// Main method gets executed upon start, instantiates a Binary Tree to pass into FindMax method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BinaryTree BT = new BinaryTree(new Node(5));
            BT.Root.LeftChild = new Node(9);
            BT.Root.RightChild = new Node(4);
            BT.Root.LeftChild.LeftChild = new Node(30);
            BT.Root.RightChild.LeftChild = new Node(24);
            BT.Root.RightChild.RightChild = new Node(17);
            BT.Root.RightChild.RightChild.RightChild = new Node(69);
            Console.WriteLine(FindMax(BT.Root));
            Console.ReadKey();
        }
        /// <summary>
        /// FindMax finds the maximum value in a Binary Tree, and returns that integer
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int FindMax(Node root)
        {
            int max = root.Value;

            if (root.LeftChild != null)
            {
                if (FindMax(root.LeftChild) > max)
                {
                    max = FindMax(root.LeftChild);
                }
            }
            if(root.RightChild != null)
            {
                if (FindMax(root.RightChild) > max)
                {
                    max = FindMax(root.RightChild);
                }
            }
            if (root.Value > max)
            {
                max = root.Value;
            }
            return max;
        }
    }
}
