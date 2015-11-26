namespace PeshoFriends
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        static int[] distances;

        static void Main()
        {
            int[] inputParts = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            int N = inputParts[0];
            int M = inputParts[1];
            int HospitalsCount = inputParts[2];

            int[] hospitales = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            List<Node>[] vertices = new List<Node>[N];
            for (int i = 0; i < M; i++)
            {
                int[] vertexParts = Console.ReadLine().Split(' ')
                        .Select(int.Parse).ToArray();

                int v1 = vertexParts[0] - 1;
                int v2 = vertexParts[1] - 1;
                int weight = vertexParts[2];

                if(vertices[v1] == null)
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

            List<int> sums = new List<int>();
            for (int i = 0; i < hospitales.Length; i++)
            {
                Dijkstra(vertices, hospitales[i] - 1);
                for (int j = 0; j < hospitales.Length; j++)
                {
                    distances[hospitales[j] - 1] = 0;
                }

                sums.Add(distances.Sum());
            }

            Console.WriteLine(sums.Min());
        }

        private static void Dijkstra(List<Node>[] vertices, int v)
        {
            int beginVertex = v;
            var visited = new HashSet<int>();
            var priorityQueue = new SortedSet<Node>();

            int[] d = Enumerable.Repeat(int.MaxValue, vertices.Length).ToArray();

            d[beginVertex] = 0;
            priorityQueue.Add(new Node(beginVertex, 0));

            while (priorityQueue.Count > 0)
            {
                var current = priorityQueue.Min;
                priorityQueue.Remove(current);
                visited.Add(current.Vertex);

                foreach (var neighbour in vertices[current.Vertex])
                {
                    var currentD = d[neighbour.Vertex];

                    var newD = d[current.Vertex] + neighbour.Weight;

                    if (newD < currentD)
                    {
                        d[neighbour.Vertex] = newD;
                        priorityQueue.Add(new Node(neighbour.Vertex, newD));
                    }
                }

                while (priorityQueue.Count > 0 && visited.Contains(priorityQueue.Min.Vertex))
                {
                    priorityQueue.Remove(priorityQueue.Min);
                }
            }

            distances = d;
        }
    }

    class Node : IComparable<Node>
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
