using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public BinaryTree(Node root)
    {
        Root = root;
    }
        // Prints the Tree out from Root, Left, Right
        public void PreOrder (Node node)
        {
            Console.WriteLine(node.Value);
            if(node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }
            if(node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }

        // Prints the Tree out from Left, Root, Right
        public void InOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.WriteLine(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }
        // Prints tree out, left, right, root
        public void PostOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }

            Console.WriteLine(node.Value);

        }
        // This uses a queue to go through the BinaryTree, it adds the nodes to the queue based on level, starting at root(the top) and working its way down
        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.Write(front.Value);
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }
        public Node Search(Node root, int value)
        {
            if (root == null)
            {
                return null;
            }
            if (root.Value == value)
            {
                return root;
            }
            if (root != null)
                Console.WriteLine(root.Value);
            return Search(root.LeftChild, value) ?? Search(root.RightChild, value);
        }
    }
}
