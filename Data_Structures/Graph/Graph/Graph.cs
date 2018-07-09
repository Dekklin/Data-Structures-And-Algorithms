using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementGraph
{
    public class Graph
    {
        public Node Root { get; set; }

        public void AddEdge(Node parent, Node child)
        {
            parent.Child.Add(child);
        }

        public List<Node> GetNeighbor(Node parent)
        {
            List<Node> list = new List<Node>();

            foreach(Node node in parent.Child)
            {
                list.Add(node);
            }
            return list;
        }

        public List<Node> GetNodes(Node root)
        {
            return Breadth(root);
        }


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
