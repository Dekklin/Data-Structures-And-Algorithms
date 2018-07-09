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
        public void AddEdge(Node parent, Node child)
        {
            parent.Child.Add(child);
        }
        /// <summary>
        /// Returns a list of children of the Node we pass in
        /// </summary>
        /// <param name="parent">The node's children we want to inspect</param>
        /// <returns>List of Nodes</returns>
        public List<Node> GetNeighbor(Node parent)
        {
            List<Node> list = new List<Node>();

            foreach(Node node in parent.Child)
            {
                list.Add(node);
            }
            return list;
        }
        /// <summary>
        /// GetNodes returns a list of all the nodes in the graph through our Breadth Method
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<Node> GetNodes(Node root)
        {
            return Breadth(root);
        }

        /// <summary>
        /// Breadth traverses through the Graph by level to level. Using a Queue it adds the root node, checks its children and adds them to the queue, As we Dequeue the queue, we enqueue it's children
        /// </summary>
        /// <param name="root">The root Node we want to start from</param>
        /// <returns>a List of nodes that are in the Graph</returns>
        public List<Node> Breadth(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.TryPeek(out root))
            {
                Node front = queue.Dequeue();
                order.Add(front);

                foreach(Node child in front.Child)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        queue.Enqueue(child);
                    }
                }
            }
            foreach(Node node in order)
            {
                node.Visited = false;
            }
            return order;
        }
        /// <summary>
        /// Currently not working: Traverses through graph adding nodes the a stack. The stack empties once we add all of the nodes that havent been visited. Then we Pop the stack
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<Node> Depth(Node root)
        {
            Stack<Node> stack = new Stack<Node>();
            List<Node> order = new List<Node>();
            stack.Push(root);
            while (stack.TryPeek(out root))
            {
                Node temp = stack.Peek();
                temp.Visited = true;
                foreach(Node Child in root.Child)
                {
                    if (!Child.Visited)
                    {
                        temp = Child;
                        temp.Visited = true;
                    }
                    else
                    {
                        order.Add(Child);
                        stack.Pop();
                    }
                }
                if(temp.Child.Count == 0)
                {
                    order.Add(temp);
                    stack.Pop();
                }

                
            }
            foreach(Node node in order)
            {
                node.Visited = false;
            }
            return order;
        }
        /// <summary>
        /// Count returns the number of Nodes that are connected to the root Node in the graph
        /// </summary>
        /// <param name="root">The beginning Node we want to start on</param>
        /// <returns>An Int: representing the number of connected Nodes </returns>
        public int Count(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            List<Node> list = new List<Node>();
            int counter = 0;
            queue.Enqueue(root);
            while (queue.TryPeek(out root))
            {
                Node front = queue.Dequeue();
                counter++;
                foreach (Node Child in front.Child)
                {
                    if (!Child.Visited)
                    {
                    Child.Visited = true;
                    list.Add(Child);
                    queue.Enqueue(Child);
                    }
                }
            }
            foreach(Node node in list)
            {
                node.Visited = false;
            }
            return counter;
        }
    }
}