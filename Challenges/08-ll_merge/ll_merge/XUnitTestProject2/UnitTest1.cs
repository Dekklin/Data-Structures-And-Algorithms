using System;
using Xunit;
using ll_merge;
using static ll_merge.Program;
using ll_merge.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void canMerge()
        {
            LinkList ll2 = new LinkList(new Node(10));

            ll2.AddNode(new Node(8));
            ll2.AddNode(new Node(6));
            ll2.AddNode(new Node(4));
            ll2.AddNode(new Node(2));

            LinkList ll1 = new LinkList(new Node(7));

            ll1.AddNode(new Node(5));
            ll1.AddNode(new Node(3));
            ll1.AddNode(new Node(1));
            // the head value
            Assert.Equal(1, Merge(ll1, ll2).Value);

        }
        [Fact]
        public void canMerge2()
        {
            LinkList ll2 = new LinkList(new Node(11));

            ll2.AddNode(new Node(24));
            ll2.AddNode(new Node(52));
            ll2.AddNode(new Node(41));
            ll2.AddNode(new Node(62));

            LinkList ll1 = new LinkList(new Node(77));

            ll1.AddNode(new Node(51));
            ll1.AddNode(new Node(33));
            ll1.AddNode(new Node(15));
            // the head value
            Assert.Equal(15, Merge(ll1, ll2).Value);
        }
        [Fact]
        public void canMerge3()
        {
            LinkList ll2 = new LinkList(new Node(4));

            ll2.AddNode(new Node(7));
            ll2.AddNode(new Node(3));
            ll2.AddNode(new Node(9));
            ll2.AddNode(new Node(12));

            LinkList ll1 = new LinkList(new Node(7));

            ll1.AddNode(new Node(14));
            ll1.AddNode(new Node(25));
            ll1.AddNode(new Node(9));
            // the head value
            Assert.Equal(9, Merge(ll1, ll2).Value);
        }
        }
}
