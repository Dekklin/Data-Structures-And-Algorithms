using System;
using System.Collections;
using System.Collections.Generic;

namespace FindIslands
{
   public static class Program
    {/// <summary>
    /// The main method gets ran on start up
    /// </summary>
    /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] arr = new int[6, 6]
            { // 1  2  3  4  5  6 
                {0, 1, 0, 0, 0, 0 },
                {1, 0, 1, 0, 0, 0 },
                {0, 1, 0, 0, 0, 0 },
                {0, 0, 0, 0, 1, 1 },
                {0, 0, 0, 1, 0, 1 },
                {0, 0, 0, 1, 1, 0 },
            };
            FindIslands(arr);
            Console.WriteLine(FindIslands(arr));
            Console.ReadKey();
        }
        /// <summary>
        /// FindIslands counts the amount of islands in the graph
        /// </summary>
        /// <param name="matrix">The adjacency matrix that represents a graph</param>
        /// <returns></returns>
        public static int FindIslands(int[,] matrix)
        {
            int counter = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool hasEdges = false;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        hasEdges = true;
                        if (!list.Contains(j))
                        {
                            list.Add(j);
                            counter++;
                        }
                        break;
                    }

                }
                if (!hasEdges)
                {
                    counter++;
                }
                list.Add(i);
            }
            return counter;
        }
    }
}
