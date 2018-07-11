using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementGraph
{
    public class Node
    {
        public string Location { get; set; }
        //The children are the nodes that the root node points to
        public Dictionary<Node,int> Edges { get; set; }
        //A boolean to keep track of whether we have traversed past the node
        public bool Visited { get; set; } = false;

        public Node(string value)
        {
            Location = value;
            Edges = new Dictionary<Node, int>();
        }
    }
}
