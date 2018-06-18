using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues
{
    public class QueueBuild
    {
        public Node Rear { get; set; }
        public Node Front { get; set; }

        // queue constructor
        public QueueBuild(Node node)
        {
            Front = node;
            Rear = node;
        }
        // Adds a node to the queue
        public Node EnQueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
            return Rear;
        }
        // removes the next in line Node from the queue
        public Node DeQueue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
        // returns the next in line node from the queue
        public Node Peek()
        {
            return Front;
        }
        // prints all the nodes in the queue
        public void Print()
        {
            Node Current = Front;
            while (Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
        }
    }
}
