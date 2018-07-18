using TreeIntersect;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersect
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public BinaryTree(Node root)
    {
        Root = root;
    }
        /// <summary>
        /// Sends the values to my AddNumbers Hashset method, Root, Left, Right.
        /// </summary>
        /// <param name="node"></param>
        public void PreOrder (HashSet hs, Node node)
        {
            hs.AddNumbers(node.Value);
            Console.WriteLine(node.Value);
            if(node.LeftChild != null)
            {
                PreOrder(hs, node.LeftChild);
            }
            if(node.RightChild != null)
            {
                PreOrder(hs, node.RightChild);
            }
        }
    }
}
