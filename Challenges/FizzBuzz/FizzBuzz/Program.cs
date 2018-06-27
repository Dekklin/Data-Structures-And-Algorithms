using System;

namespace FizzBuzzTree
{
    public static class Program
    {
        /// <summary>
        /// Main method gets executed upon start
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hey World");
            
            BinaryTree BT = new BinaryTree(new Node("5"));
            BT.Root.LeftChild = new Node("9");
            BT.Root.RightChild = new Node("4");
            BT.Root.LeftChild.LeftChild = new Node("30");
            BT.Root.RightChild.LeftChild = new Node("10");
            BT.Root.RightChild.RightChild = new Node("19");
            BT.PreOrder(BT.Root);
            Console.WriteLine("Now with fizzbuzz");
            FizzBuzzTree(BT.Root);
            //BT.PreOrder(BT.Root);
            Console.ReadKey();
        }
        /// <summary>
        /// Takes in a root of a binaryTree, checks if the value of the nodes are evenly divided by 15, 3, or 5; if they are replace their value. 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static Node FizzBuzzTree(Node root)
        {
            if (int.Parse(root.Value) % 15 == 0)
            {
                root.Value = "FizzBuzz";
            }
            else if (int.Parse(root.Value) % 3 == 0)
            {
                root.Value = "Fizz";
            }
            else if(int.Parse(root.Value) % 5 == 0)
            {
                root.Value = "Buzz";
            }
            Console.WriteLine(root.Value);
            if(root.LeftChild != null)
            {
               FizzBuzzTree(root.LeftChild);
            }
            if(root.RightChild != null)
            {
               FizzBuzzTree(root.RightChild);
            }
                return root;
        }
    }
}
