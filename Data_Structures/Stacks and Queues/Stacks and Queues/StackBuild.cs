using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues
{
    public class StackBuild
    {
        public Node Top { get; set; }
        // constructor for Stacks
        public StackBuild(Node node)
        {
            node.Next = Top;
            Top = node;
        }
        // pushes node onto stack
        public Node Push(Node node)
        {
            node.Next = Top;
            Top = node;
            return Top;
        }
        // pops the top node off the stack
        public Node Pop()
        {
            Node node = Top;
            Top = Top.Next;
            node.Next = null;
            return node;
        }
        // returns the value at the top of the stack
        public Node Peek()
        {
            return Top;
        }
        // prints all the nodes in the stack
        public void Print()
        {
            
            Node Current = Top;
            while (Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
        }

    }
}
