using System;

namespace Tree
{
    class Program
    {
        /// <summary>
        /// Starts on execution of program, runs the BuildBT and BuildBST methods
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BuildBT();
            Console.WriteLine("Here is BST now");
            BuildBST();
            Console.ReadKey();
        }


        /// <summary>
        /// BuildBT istantiates a BinaryTree, and adds nodes to it, then logs all of the traverses
        /// </summary>
        public static void BuildBT()
        {
            BinaryTree BT = new BinaryTree(new Node(5));
            BT.Root.LeftChild = new Node(8);
            BT.Root.RightChild = new Node(3);
            BT.Root.LeftChild.LeftChild = new Node(9);
            BT.Root.RightChild.LeftChild = new Node(10);
            BT.Root.RightChild.RightChild = new Node(11);

            // InOrder should be 9-8-5-10-3-11
            BT.InOrder(BT.Root);
            // PreOrder should be 5-8-9-3-10-11
            BT.PreOrder(BT.Root);
            // PostOrder should be 9-8-10-11-3-5
            BT.PostOrder(BT.Root);

            // Breadth should be 5-8-3-9-10-11
            BT.BreadthFirst(BT.Root);
        }

        /// <summary>
        /// Build BST instantiates a new BinarySearchTree, and adds nodes accordingly (in order), then console Logs an AddNode, and two Searches.
        /// </summary>
        public static void BuildBST()
        {
            BinarySearchTree BST = new BinarySearchTree(new Node(100));
            BST.AddNode(75, BST.Root);
            BST.AddNode(90, BST.Root);
            BST.AddNode(120, BST.Root);
            // This method returns the node, so we are going to check the value of the return
            Console.WriteLine(BST.AddNode(150, BST.Root).Value);
            Console.WriteLine("^ his add should be : 150 +++");
            // this method returns null if it doesn't exist, and the node if it does.
            if (BST.Search(BST.Root, 69) == null)
            {
                Console.WriteLine("This Console.WriteLine should appear if searching a non-existing node returns null");
            }
            Console.WriteLine(BST.Search(BST.Root, 90).Value);
            Console.WriteLine("^ This Search should return 90 ++++");
        }
    }
}
