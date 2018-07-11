using ImplementGraph;
using ImplementWeight;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Graph graph = new Graph();
            Node NodeA = new Node("NY");
            //NodeA.Child.Add(new Node(3));
            Node NodeB = new Node("WA");
            Node NodeC = new Node("UT");
            Node NodeD = new Node("FL");
            Node NodeE = new Node("AZ");
            Node NodeF = new Node("MN");
            graph.Root = NodeA;
            graph.AddEdge(NodeA, NodeB, 45);
            graph.AddEdge(NodeA, NodeC, 56);
            graph.AddEdge(NodeC, NodeD, 86);
            graph.AddEdge(NodeB, NodeF, 74);
            graph.AddEdge(NodeE, NodeC, 71);
            graph.AddEdge(NodeD, NodeE, 80);
            graph.AddEdge(NodeE, NodeA, 99);
            string[] locations = new string[3] { "NY", "WA", "MN" };        // should pass
            string[] locations1 = new string[3] { "WA", "MN", "AZ" };       // should fail
            string[] locations2 = new string[4] { "AZ", "UT", "NY", "AZ" }; // should pass
            string[] locations3 = new string[1] { "NY"};                    // should fail
            string[] locations4 = new string[3] { "NY", "MN", "FL" };       // should fail

            Assert.Equal(Tuple.Create(true, 119), Program.FindEdges(graph, locations));
            Assert.Equal(Tuple.Create(true, 173), Program.FindEdges(graph, locations1));
            Assert.Equal(Tuple.Create(true, 226), Program.FindEdges(graph, locations2));
            Assert.Equal(Tuple.Create(false, 0), Program.FindEdges(graph, locations3));
            Assert.Equal(Tuple.Create(false, 0), Program.FindEdges(graph, locations4));

        }
    }
}
