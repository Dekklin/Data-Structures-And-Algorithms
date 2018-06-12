using Class05_LinkedList;
using System;
using Xunit;


namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
            LinkList ll = new LinkList(new Node(5));
            Node node1 = new Node(12);
            Node node2 = new Node(17);
            ll.AddNode(node1);
            ll.AddNode(node2);
            Assert.Equal(ll.Head.Value, node2.Value);

            // 5 > 12 > 17
        }
        [Theory]
        [InlineData(12, 12)]
        [InlineData(22, 22)]
        public void CanFindNodeThatExists(int value, int expected)
        {
            LinkList ll = new LinkList(new Node(15));
            Node node1 = new Node(4);
            Node node2 = new Node(12);
            Node node3 = new Node(22);
            ll.AddNode(node1);
            ll.AddNode(node2);
            ll.AddNode(node3);
            Node found = ll.Find(value);
            Assert.Equal(expected, found.Value);
        }
        [Theory]
        [InlineData(42)]
        [InlineData(555)]
        public void ReturnsNullForNonExistentNode(int value)
        {
            // Arrange
            LinkList ll = new LinkList(new Node(4));
            Node node1 = new Node(8);
            Node node2 = new Node(15);
            Node node3 = new Node(24);
            Node node4 = new Node(36);

            // Add
            ll.AddNode(node1);
            ll.AddNode(node2);
            ll.AddNode(node3);
            ll.AddNode(node4);

            // Act
            Node found = ll.Find(value);

            // Assert
            Assert.Null(found);
        }
    }
}
