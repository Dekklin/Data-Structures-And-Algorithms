using System;
using ll_merge.Classes;

namespace ll_merge
{
    public class Program
    {
        // main method that creates Link Lists and calls the merge method to combine the two
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            LinkList ll2 = new LinkList(new Node(10));

            ll2.AddNode(new Node(8));
            ll2.AddNode(new Node(6));
            ll2.AddNode(new Node(4));
            ll2.AddNode(new Node(2));

            LinkList ll1 = new LinkList(new Node(7));

            ll1.AddNode(new Node(5));
            ll1.AddNode(new Node(3));
            ll1.AddNode(new Node(1));
            //LinkList ll3 = Merge(ll1, ll2);
            ll1.Print();
            ll2.Print();
            Console.WriteLine(Merge(ll1, ll2).Value);
            Console.ReadKey();
        }
/// <summary>
/// Takes in two LinkLists that merges the second list into the first, one node at a time. Acting like a zipper
/// </summary>
/// <param name="ll1"></param>
/// <param name="ll2"></param>
/// <returns>The first link list, which has the contents of both the first and second LL</returns>
        public static Node Merge(LinkList ll1, LinkList ll2)
        {
            ll1.Current = ll1.Head;
            ll2.Current = ll2.Head;

            while (ll1.Current.Next != null || ll2.Current.Next != null)
            {
                if (ll2.Current.Next != null)
                {
                    ll2.Head = ll2.Head.Next;
                    ll2.Current.Next = ll1.Current.Next;
                    ll1.AddAfter(ll2.Current, ll1.Current);
                    ll1.Current = ll1.Current.Next;
                    ll2.Current = ll2.Head;
                }
                if (ll1.Current.Next != null)
                {
                    ll1.Current = ll1.Current.Next;
                }
            }
            while(ll1.Current.Next == null && ll2.Current != null)
            {
                ll2.Head = ll2.Head.Next;
                ll1.AddAfter(ll2.Current, ll1.Current);
                ll1.Current = ll1.Current.Next;
                ll2.Current = ll2.Head;
            }
            return ll1.Head;
        }




        /// <summary>
        /// First attempt in the merge
        /// </summary>
        /// <param name="ll1"></param>
        /// <param name="ll2"></param>
        /// <returns></returns>
        static Node Merge2(LinkList ll1, LinkList ll2)
        {
            ll1.Current = ll1.Head;
            ll2.Current = ll2.Head;
            LinkList linked = new LinkList(ll1.Current);
            linked.Current = linked.Head;
            linked.AddAfter(ll2.Current, linked.Current);
            //linked.Current = linked.Current.Next;
            while (ll1.Current.Next != null || ll2.Current.Next != null)
            {
                if (ll1.Current.Next != null)
                {
                    ll1.Current = ll1.Current.Next;
                    linked.AddAfter(ll1.Current, linked.Current);
                    linked.Current = linked.Current.Next;

                    Console.WriteLine(linked.Current.Value);
                    Console.ReadKey();
                }
                if (ll2.Current.Next != null)
                {
                    ll2.Current = ll2.Current.Next;
                    linked.AddAfter(ll2.Current, linked.Current);
                    linked.Current = linked.Current.Next;

                    Console.WriteLine(linked.Current.Value);
                    Console.ReadKey();
                }
            }
            return linked.Head;
        }
    }
}
