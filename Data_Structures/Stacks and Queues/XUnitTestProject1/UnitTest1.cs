using Stacks_and_Queues;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestStackPush()
        {
            StackBuild testStack = new StackBuild(new Node(5));
            Assert.Equal(6, testStack.Push(new Node(6)).Value);
            Assert.Equal(7, testStack.Push(new Node(7)).Value);
            Assert.Equal(8, testStack.Push(new Node(8)).Value);
        }
        [Fact]
        public void TestStackPop()
        {
            StackBuild testStack = new StackBuild(new Node(5));
            testStack.Push(new Node(6));
            testStack.Push(new Node(7));
            testStack.Push(new Node(8));
            Assert.Equal(8, testStack.Pop().Value);
            Assert.Equal(7, testStack.Pop().Value);
        }
        [Fact]
        public void TestStackPeek()
        {
            StackBuild testStack = new StackBuild(new Node(5));
            testStack.Push(new Node(6));
            testStack.Push(new Node(7));
            testStack.Push(new Node(8));
            Assert.Equal(8, testStack.Peek().Value);
        }
        [Fact]
        public void TestQueueCanEnqueue()
        {
            QueueBuild testQueue = new QueueBuild(new Node(5));
            Assert.Equal(6, testQueue.EnQueue(new Node(6)).Value);
            Assert.Equal(7, testQueue.EnQueue(new Node(7)).Value);
            Assert.Equal(8, testQueue.EnQueue(new Node(8)).Value);

        }
        [Fact]
        public void TestQueueCanDeQueue()
        {
            QueueBuild testQueue = new QueueBuild(new Node(5));
            testQueue.EnQueue(new Node(6));
            testQueue.EnQueue(new Node(7));
            Assert.Equal(5, testQueue.DeQueue().Value);
            Assert.Equal(6, testQueue.DeQueue().Value);
        }
        [Fact]
        public void TestQueueCanPeek()
        {
            QueueBuild testQueue = new QueueBuild(new Node(5));
            testQueue.EnQueue(new Node(6));
            testQueue.EnQueue(new Node(7));
            Assert.Equal(5, testQueue.Peek().Value);
        }
    }
}
