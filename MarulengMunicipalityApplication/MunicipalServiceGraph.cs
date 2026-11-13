using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarulengMunicipalityApplication
{
    public class MunicipalServiceGraph
    {
        private Dictionary<string, List<Edge>> adjacencyList;

        private class Edge
        {
            public string Destination;
            public int Weight;

            public Edge(string destination, int weight)
            {
                Destination = destination;
                Weight = weight;
            }
        }

        public MunicipalServiceGraph()
        {
            adjacencyList = new Dictionary<string, List<Edge>>();
        }

        // Adds a municipal area to the graph
        public void AddVertex(string area)
        {
            if (!adjacencyList.ContainsKey(area))
                adjacencyList.Add(area, new List<Edge>());
        }

        // Adds a weighted connection between two areas
        public void AddEdge(string area1, string area2, int distance)
        {
            AddVertex(area1);
            AddVertex(area2);

            adjacencyList[area1].Add(new Edge(area2, distance));
            adjacencyList[area2].Add(new Edge(area1, distance));
        }

        // Breadth-First Search
        public List<string> BreadthFirstSearch(string start)
        {
            List<string> visited = new List<string>();

            if (!adjacencyList.ContainsKey(start))
                return visited;

            Queue<string> queue = new Queue<string>();
            HashSet<string> visitedSet = new HashSet<string>();

            queue.Enqueue(start);
            visitedSet.Add(start);

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                visited.Add(current);

                foreach (Edge edge in adjacencyList[current])
                {
                    if (!visitedSet.Contains(edge.Destination))
                    {
                        visitedSet.Add(edge.Destination);
                        queue.Enqueue(edge.Destination);
                    }
                }
            }

            return visited;
        }

        // Depth-First Search
        public List<string> DepthFirstSearch(string start)
        {
            List<string> visited = new List<string>();
            HashSet<string> visitedSet = new HashSet<string>();

            if (adjacencyList.ContainsKey(start))
                DFSHelper(start, visited, visitedSet);

            return visited;
        }

        private void DFSHelper(
            string current,
            List<string> visited,
            HashSet<string> visitedSet)
        {
            visitedSet.Add(current);
            visited.Add(current);

            foreach (Edge edge in adjacencyList[current])
            {
                if (!visitedSet.Contains(edge.Destination))
                    DFSHelper(edge.Destination, visited, visitedSet);
            }
        }

        // Prim's Minimum Spanning Tree
        public List<string> GetMinimumSpanningTree(string start)
        {
            List<string> result = new List<string>();

            if (!adjacencyList.ContainsKey(start))
                return result;

            HashSet<string> visited = new HashSet<string>();
            visited.Add(start);
            result.Add(start);

            while (visited.Count < adjacencyList.Count)
            {
                string nextArea = null;
                string fromArea = null;
                int smallestWeight = int.MaxValue;

                foreach (string area in visited)
                {
                    foreach (Edge edge in adjacencyList[area])
                    {
                        if (!visited.Contains(edge.Destination) &&
                            edge.Weight < smallestWeight)
                        {
                            smallestWeight = edge.Weight;
                            nextArea = edge.Destination;
                            fromArea = area;
                        }
                    }
                }

                // Stop if the graph is disconnected
                if (nextArea == null)
                    break;

                visited.Add(nextArea);
                result.Add(fromArea + " - " + nextArea +
                    " (" + smallestWeight + ")");
            }

            return result;
        }
    }
}
