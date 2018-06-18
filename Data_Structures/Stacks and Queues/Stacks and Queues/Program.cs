using System;

namespace Stacks_and_Queues
{
    class Program
    {
        //main method that triggers on run, calls test for stack and queue
        static void Main(string[] args)
        {
            Console.WriteLine("Heres a Stack");
            TestStack();
            Console.WriteLine("Heres a Queue now");
            TestQueue();
            Console.ReadKey();
        }
        // Creates a stack and pushes nodes onto it, with a pop and peek
        static void TestStack()
        {
            StackBuild Stack = new StackBuild(new Node(5));
            Stack.Push(new Node(10));
            Stack.Push(new Node(15));
            Stack.Peek();
            Stack.Pop();
            Stack.Peek();
            Stack.Print();
        }
        // Creates a queue and queues nodes into it.
        static void TestQueue()
        {
            QueueBuild Queue = new QueueBuild(new Node(2));
            Queue.EnQueue(new Node(4));
            Queue.EnQueue(new Node(6));
            Queue.Peek();
            Queue.DeQueue();
            Queue.Peek();
            Queue.Print();
        }
    }
}
