namespace CableTVCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static string input = @"0 3 7
0 4 3
0 5 5
1 2 10
1 3 2
1 4 1
2 4 100
2 5 17
3 4 1
4 5 3";

        private static List<Node>[] ReadInput(string input)
        {
            int n = 6;
            var vertices = new List<Node>[n];
            var edges = input.Split('\n');
            foreach (var edge in edges)
            {
                var parts = edge.Split(' ').Select(int.Parse).ToArray();
                var v1 = parts[0];
                var v2 = parts[1];
                var weight = parts[2];

                if (vertices[v1] == null)
                {
                    vertices[v1] = new List<Node>();
                }

                if (vertices[v2] == null)
                {
                    vertices[v2] = new List<Node>();
                }

                vertices[v1].Add(new Node(v2, weight));
                vertices[v2].Add(new Node(v1, weight));
            }

            return vertices;
        }
        public static void Main()
        {
            int n = 6;
            var vertices = new List<Node>[n];
            var edges = input.Split('\n');
            foreach (var edge in edges)
            {
                var parts = edge.Split(' ').Select(int.Parse).ToArray();
                var v1 = parts[0];
                var v2 = parts[1];
                var weight = parts[2];

                if (vertices[v1] == null)
                {
                    vertices[v1] = new List<Node>();
                }

                if (vertices[v2] == null)
                {
                    vertices[v2] = new List<Node>();
                }

                vertices[v1].Add(new Node(v2, weight));
                vertices[v2].Add(new Node(v1, weight));
            }

            int minCost = FindMinimazeCost(vertices);
            Console.WriteLine(minCost);
        }

        private static int FindMinimazeCost(List<Node>[] vertices)
        {
            int v = 0;

            var queue = new SortedSet<Edge>();
            queue.Add(new Edge(-1, v, 0));

            HashSet<Edge> tree = new HashSet<Edge>();
            HashSet<int> visited = new HashSet<int>();

            while (queue.Count > 0)
            {
                var bestEdge = queue.Min;
                queue.Remove(bestEdge);

                if (visited.Contains(bestEdge.V2))
                {
                    continue;
                }

                tree.Add(bestEdge);
                visited.Add(bestEdge.V2);

                foreach (var neighbour in vertices[bestEdge.V2])
                {
                    if (visited.Contains(neighbour.Vertex))
                    {
                        continue;
                    }

                    queue.Add(new Edge(bestEdge.V2, neighbour.Vertex, neighbour.Weight));
                }

            }

            int cost = 0;
            foreach (var edge in tree)
            {
                cost += edge.Weigth;
            }

            return cost;
        }
    }

    internal class Edge : IComparable<Edge>
    {
        public Edge(int v1, int v2, int weight)
        {
            this.V1 = v1;
            this.V2 = v2;
            this.Weigth = weight;
        }

        public int V1 { get; set; }

        public int V2 { get; set; }

        public int Weigth { get; set; }

        public int CompareTo(Edge other)
        {
            if (this.Weigth.CompareTo(other.Weigth) == 0)
            {
                if (this.V1.CompareTo(other.V1) == 0)
                {
                    return this.V2.CompareTo(other.V2);
                }

                return this.V1.CompareTo(other.V1);
            }

            return this.Weigth.CompareTo(other.Weigth);
        }
    }

    internal class Node : IComparable<Node>
    {
        public Node(int vertex, int weight)
        {
            this.Vertex = vertex;
            this.Weight = weight;
        }

        public int Vertex { get; set; }

        public int Weight { get; set; }

        public int CompareTo(Node other)
        {
            if (this.Weight.CompareTo(other.Weight) == 0)
            {
                return this.Vertex.CompareTo(other.Vertex);
            }

            return this.Weight.CompareTo(other.Weight);
        }
    }
}
