using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_With_Stacks

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
        /// <summary>
        ///Adds a node to the top of the stack
        /// </summary>
        /// <param name="x">New node instantiated with that value</param>
        /// <returns>The Value of the new Node Created</returns>
        public int EnQueue(int x)
        {
            Push(new Node(x));
            return Top.Value;
        }
        /// <summary>
        /// Removes the bottom node in a stack, as if it were a queue
        /// </summary>
        /// <returns>The value of the Node at the bottom</returns>
        public int DeQueue()
        {
            StackBuild temp = new StackBuild(Pop());
            while(Top.Next != null)
            {
                temp.Push(Pop());
            }
            int hold = Pop().Value;
            while(temp.Top.Next != null)
            {
                Push(temp.Pop());
            }
            return hold;
        }

    }
}
