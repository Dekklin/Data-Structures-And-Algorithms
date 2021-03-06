﻿using System;
using System.Collections.Generic;

namespace ImplementGraph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph graph = new Graph();
            Node NodeA = new Node(2);
            //NodeA.Child.Add(new Node(3));
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
            Console.WriteLine("---Breadth");
            //Breadth returns a list of nodes which we attach to a variable and print the list to see the traversal order
            List<Node> example = graph.Breadth(NodeA);
            foreach(Node node in example)
            {
                Console.WriteLine(node.Value);
            }
            Console.WriteLine("---Depth");
            //I'm getting stuck on one edge case
            Console.WriteLine("TBC");


            //List<Node> example2 = graph.Depth(NodeA);
            //foreach(Node node in example2)
            //{
            //    Console.WriteLine(node.Value);
            //}
            //Console.WriteLine(graph.GetNeighbor(NodeA));


            Console.WriteLine("---GetNeighbor");
            //GetNeighbor returns a list of nodes which we attach to a variable and print the list to see the children of the root node we pass in.
            List<Node> example2 = graph.GetNeighbor(NodeA);
            foreach(Node node in example2)
            {
                Console.WriteLine(node.Value);
            }
            Console.WriteLine("---GetNodes");
            //Get Nodes returns a list of nodes which we attach to a variable and print the list to see what nodes are in the graph
            List<Node> example3 = graph.GetNodes(NodeA);
            foreach(Node node in example3)
            {
                Console.WriteLine(node.Value);
            }
            Console.WriteLine(graph.GetNodes(NodeA));
            Console.WriteLine("---Count");
            Console.WriteLine(graph.Count(NodeA));
            Console.ReadKey();
        }

    }
}
