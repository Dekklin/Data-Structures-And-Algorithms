using System;

namespace Queue_With_Stacks
{
    public class Program
    {
        /// <summary>
        /// Main Method that executes on startup, simpley calls the method that implements the challenge
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueWithStack();
        }
        /// <summary>
        /// Method that creates a stack, and implements the Enqueue and DeQueue methods which adds a node, and removes the bottom node
        /// </summary>
        public static void QueueWithStack()
        {
            StackBuild stack = new StackBuild(new Node(5));
            stack.Push(new Node(6));
            stack.Push(new Node(7));
            stack.Push(new Node(8));
            stack.Push(new Node(9));
            stack.EnQueue(10);
            stack.DeQueue();
            stack.Print();
            Console.ReadKey();
        }
    }
}
