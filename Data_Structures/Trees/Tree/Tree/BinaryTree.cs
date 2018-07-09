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
        /// <summary>
        /// Prints out the nodes in order of Root, Left, Right.
        /// </summary>
        /// <param name="node"></param>
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

        /// <summary>
        /// Traverses through the tree nodes from Left, Root, Right
        /// </summary>
        /// <param name="node"></param>
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
        /// <summary>
        /// Traverses through the tree in the order of Left Right Root
        /// </summary>
        /// <param name="node"></param>
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
