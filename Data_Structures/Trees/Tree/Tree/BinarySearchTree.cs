using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }
        public BinarySearchTree(Node root)
        {
            Root = root;
        }
        //not needed but keeping just in case
        public void PreOrder(Node node)
        {
            Console.WriteLine(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }

        //not needed but keeping just in case

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
        //not needed but keeping just in case
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
        /// <summary>
        /// Searches for a Node with the value of "value"
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Search(Node root, int value)
        {
            if(root == null)
            {
                return null;
            }
            if(root.Value == value)
            {
                return root;
            }
            if(value > root.Value)
            {
                return Search(root.RightChild, value);
            }
            if(value < root.Value)
            {
                return Search(root.LeftChild, value);
            }
            return null;
        }
        /// <summary>
        /// Adds a node with the value of k, if k is less than the current node, you traverse to left child, if its greater than the current node, it traverses to right node. If child is null, assign child to equal new node
        /// </summary>
        /// <param name="k"></param>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node AddNode(int k, Node root)
        {
            Node newNode = new Node(k);
            if(root == null)
            {
                root = newNode;
                return newNode;
            }
            if(root.Value == k)
            {
                return null;
            }
            else if(newNode.Value < root.Value)
            {
                if(root.LeftChild == null)
                {
                    root.LeftChild = newNode;
                    return newNode;
                }
                else
                {
                    return AddNode(k, root.LeftChild);
                }
            }
            else if(newNode.Value > root.Value)
            {
                if(root.RightChild == null)
                {
                    root.RightChild = newNode;
                    return newNode;
                }
                else
                {
                    return AddNode(k, root.RightChild);
                }
            }
            else
                return null;
        }

    }
}
