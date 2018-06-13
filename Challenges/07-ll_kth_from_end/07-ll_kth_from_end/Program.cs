using System;

namespace _07_ll_kth_from_end
{
    public class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int endPoint = KthElement(k).Value;
            Console.WriteLine(endPoint);
            Console.ReadKey();
        }
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
