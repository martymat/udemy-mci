using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DataStructures
{
    public class GraphTester
    {
        public static void GenerateAndPrintGraph()
        {
            Graph graph = new Graph();

            // Add vertices
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);

            // Add edges
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            // Print the graph
            graph.PrintGraph();
        }
    }
}
