using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementGraph
{
    public class Graph
    {
        public Node Root { get; set; }
        /// <summary>
        /// Adds the child node to the list of children of the parent node
        /// </summary>
        /// <param name="child">The Node we want to attach</param>
        /// <param name="parent">The node we want to attach the child to</param>
        public void AddEdge(Node parent, Node child, int cost)
        {
            parent.Edges.Add(child, cost);
            child.Edges.Add(parent, cost);
        }
        /// <summary>
        /// Returns a list of children of the Node we pass in
        /// </summary>
        /// <param name="parent">The node's children we want to inspect</param>
        /// <returns>List of Nodes</returns>
        public List<Node> GetNeighbors(Node parent)
        {
            Dictionary<Node, int> dic = new Dictionary<Node, int>();
            List<Node> list = new List<Node>();

            foreach (KeyValuePair<Node, int> node in parent.Edges)
            {
                list.Add(node.Key);
            }
            return list;
        }
        /// <summary>
        /// Uses breadth traversal to find the the node that has a Location value as our parameter
        /// </summary>
        /// <param name="location">A string with the state initials</param>
        /// <returns>the node with that Location value</returns>
        public Node Search(string location)
        {
            List<Node> order = new List<Node>();
            Node k = new Node(location);

            Queue<Node> queue = new Queue<Node>();
            Node root = Root;
            queue.Enqueue(root);
            while (queue.TryPeek(out root))
            {
                Node front = queue.Dequeue();
                foreach (KeyValuePair<Node, int> child in front.Edges)
                {
                    if(child.Key.Location == location)
                    {
                        return child.Key;
                    }
                }
            }
            return Root;
        }
    }
}