using System;

namespace _07_ll_kth_from_end
{
    public class Program
    {
        // main method that triggers on program start, grabs int K from user and initiates the KthElement method with k
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int endPoint = KthElement(k).Value;
            Console.WriteLine(endPoint);
            Console.ReadKey();
        }
        // Creates a linked list then returns the Node thats K spaces from the end
        public static Node KthElement(int k)
        {
            LinkL ll = new LinkL(new Node(10));
            ll.AddNode(new Node(12));
            ll.AddNode(new Node(14));
            ll.AddNode(new Node(16));
            ll.AddNode(new Node(18));
            ll.AddNode(new Node(20));
            ll.Print();
            ll.Current = ll.Head;
            Node Runner = ll.Head;
            int counter = 0;
            while (Runner.Next != null)
            {
                counter++;
                Runner = Runner.Next;
                if (counter > k)
                {
                    ll.Current = ll.Current.Next;
                }
            }
           return ll.Current;

        }
    }
}
