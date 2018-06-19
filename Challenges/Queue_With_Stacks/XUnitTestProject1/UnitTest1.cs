using System;
using Xunit;
using Queue_With_Stacks;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnQueue()
        {
            StackBuild stack = new StackBuild(new Node(5));
            stack.Push(new Node(6));
            stack.Push(new Node(7));
            stack.Push(new Node(8));

            Assert.Equal(9, stack.EnQueue(9));
            Assert.Equal(10, stack.EnQueue(10));
            Assert.Equal(11, stack.EnQueue(11));

        }
        [Fact]
        public void CanDeQueue()
        {
            StackBuild stack = new StackBuild(new Node(5));
            stack.Push(new Node(6));
            stack.Push(new Node(7));
            stack.Push(new Node(8));
            stack.Push(new Node(9));
            stack.Push(new Node(10));

            Assert.Equal(5, stack.DeQueue());
            Assert.Equal(6, stack.DeQueue());
            Assert.Equal(7, stack.DeQueue());
        }
    }
}
