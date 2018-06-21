using System;
using Xunit;
using ll_merge.Program;
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

        }
    }
}
