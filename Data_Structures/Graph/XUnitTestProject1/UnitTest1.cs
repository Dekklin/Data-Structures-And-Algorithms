using ImplementGraph;
using ImplementGraph;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanTraverseBreadth()
        {
            Graph graph = new Graph();
            Node NodeA = new Node(2);
            Node NodeB = new Node(3);
            Node NodeC = new Node(4);
            Node NodeD = new Node(5);
            Node NodeE = new Node(6);
            Node NodeF = new Node(7);

            graph.Root = NodeA;
            //2 -> 3 -> 6
            //2 -> 4 -> 5 -> 7
            graph.AddEdge(NodeA, NodeB);
            graph.AddEdge(NodeA, NodeC);
            graph.AddEdge(NodeC, NodeD);
            graph.AddEdge(NodeB, NodeE);
            graph.AddEdge(NodeB, NodeF);

            List<Node> test = new List<Node> {NodeA, NodeB, NodeC, NodeE, NodeF, NodeD};
            Assert.Equal(test, graph.Breadth(NodeA));
        }
        [Fact]
        public void CanCountGraph()
        {
            Graph graph = new Graph();
            Node NodeA = new Node(2);
            Node NodeB = new Node(3);
            Node NodeC = new Node(4);
            Node NodeD = new Node(5);
            Node NodeE = new Node(6);
            Node NodeF = new Node(7);

            graph.Root = NodeA;
            //2 -> 3 -> 6
            //2 -> 4 -> 5 -> 7
            graph.AddEdge(NodeA, NodeB);
            graph.AddEdge(NodeA, NodeC);
            graph.AddEdge(NodeC, NodeD);
            graph.AddEdge(NodeB, NodeE);
            graph.AddEdge(NodeB, NodeF);

            Assert.Equal(6, graph.Count(NodeA));
        }
        [Fact]
        public void CanGetNeighbors()
        {
            Graph graph = new Graph();
            Node NodeA = new Node(2);
            Node NodeB = new Node(3);
            Node NodeC = new Node(4);
            Node NodeD = new Node(5);
            Node NodeE = new Node(6);
            Node NodeF = new Node(7);

            graph.Root = NodeA;
            //2 -> 3 -> 6
            //2 -> 4 -> 5 -> 7
            graph.AddEdge(NodeA, NodeB);
            graph.AddEdge(NodeA, NodeC);
            graph.AddEdge(NodeC, NodeD);
            graph.AddEdge(NodeB, NodeE);
            graph.AddEdge(NodeB, NodeF);
            List<Node> test = new List<Node> { NodeE, NodeF};
            Assert.Equal(test, graph.GetNeighbor(NodeB));
        }
        [Fact]
        public void CanAddEdge()
        {
            Graph graph = new Graph();
            Node NodeA = new Node(2);
            Node NodeB = new Node(3);

            graph.AddEdge(NodeA, NodeB);
            Assert.Contains(NodeB, NodeA.Child);
        }
    }
}
