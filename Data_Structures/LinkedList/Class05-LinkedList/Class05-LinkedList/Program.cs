using System;
using System.Collections.Generic;
using System.Text;

namespace Class05_LinkedList
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            TestLL();
            Console.ReadKey();
        }
        static void TestLL()
        {
            LinkList ll = new LinkList(new Node(20));



            ll.AddNode(new Node(15));
            ll.AddLast(new Node(25));
            ll.AddNode(new Node(10));
            ll.AddBefore(new Node(12), new Node(15));
            ll.AddAfter(new Node(17), new Node(15));
            ll.Print();
            // 10 . 15 . 20

            Console.ReadKey();
        }
        
    }
}
