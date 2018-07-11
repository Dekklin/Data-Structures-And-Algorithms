using ImplementGraph;
using System;
using System.Collections.Generic;

namespace ImplementWeight
{
    public static class Program
    { /// <summary>
    /// Main program gets instantiated on start up
    /// Here we create our Graph, and give it nodes. Lastly our array of strings for our destinations (State Initials)
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            Node NodeA = new Node("NY");
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

            //Test to see if my Search Works
            Console.WriteLine(graph.Search("AZ").Location);
            // My list of places to go (in order)
            string[] locations = new string[4] { "AZ", "UT", "NY", "AZ" };

            Console.WriteLine(FindEdges(graph, locations));
            Console.ReadKey();
        }
        /// <summary>
        /// Find edges checks if there is a direct connection between each of the states in the locations array
        /// </summary>
        /// <param name="graph">This is the graph we will be traversing to try and fly across</param>
        /// <param name="array">oThe array of locations, index 0 would be the starting location and the last index would be your destination</param>
        /// <returns>A tuple, with a bool value of success, and an int of the cost for the trip</returns>
        public static Tuple<bool, int> FindEdges(Graph graph, string[] array)
        {
            if(array.Length < 2)
            {
                return Tuple.Create(false, 0);
            }
            bool possible = false;
            int cost = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                Node location = graph.Search(array[i]);

                List<Node> list = graph.GetNeighbors(location);
                foreach(Node node in list)
                {
                    if(node.Location == array[i+1])
                    {
                        bool x = location.Edges.TryGetValue(node, out int value);
                        if (x)
                        {
                            cost += value;
                            possible = true;
                            break;
                        }
                        else if (!x)
                        {
                            return Tuple.Create(false, 0);
                        }
                    }
                }
            }
            if (!possible)
            {
                return Tuple.Create(possible, 0);
            }
            return Tuple.Create(possible, cost);

        }
    }
}
