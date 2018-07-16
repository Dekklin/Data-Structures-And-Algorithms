using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementGraph
{
    public class Node
    {
        public int Value { get; set; }
        //The children are the nodes that the root node points to
        public List<Node> Child { get; set; }
        //A boolean to keep track of whether we have traversed past the node
        public bool Visited { get; set; } = false;
        public int Weight { get; set; }

        public Node(int value)
        {
            Value = value;
            Child = new List<Node>();
        }
    }
}
