namespace Salaries
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int employeesCount = int.Parse(Console.ReadLine());

            List<Node>[] edges = new List<Node>[employeesCount];

            int[,] matrix = new int[employeesCount, employeesCount];
            char[,] c = new char[employeesCount, employeesCount];
            int[] sums = new int[employeesCount];

            for (int i = 0; i < c.GetLength(0); i++)
            {
                string line = Console.ReadLine();
                edges[i] = new List<Node>();

                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = line[j];
                    if (line[j] == 'Y')
                    {
                        edges[i].Add(new Node(j, 0));
                    }
                }

                if(edges[i].Count == 0)
                {
                    sums[i] = 1;
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if(c[j, i] == 'Y')
                    {
                        matrix[j, i] = 1;
                    }
                }
            }

            var graph = new Graph(matrix);
            graph.TestDfs();
            var elements = graph.SortedElements;

            for (int i = 0; i < elements.Count; i++)
            {
                var current = edges[elements[i]];
                foreach (var item in current)
                {
                    sums[elements[i]] += sums[item.Vertex];
                }
            }

            Console.WriteLine(sums.Sum());
        }
    }

    internal class Node
    {
        public Node(int vertex, int weight)
        {
            this.Vertex = vertex;
            this.Weight = weight;
        }

        public int Vertex { get; set; }

        public int Weight { get; set; }
    }

    internal class Graph
    {
        private readonly int[,] edges;

        private readonly int count;

        public bool[] VisitedElements;

        public List<int> SortedElements = new List<int>();

        public Graph(int[,] e)
        {
            this.edges = e;
            this.count = e.GetLength(0);
            this.VisitedElements = new bool[this.count];
        }

        public void Dfs(int startIndex)
        {
            this.VisitedElements[startIndex] = true;

            for (int k = 0; k < this.count; k++)
            {
                if ((this.edges[startIndex, k] == 1) && (this.VisitedElements[k] == false))
                {
                    this.Dfs(k);
                }
            }

            this.SortedElements.Add(startIndex);
        }

        public void TestDfs()
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.VisitedElements[i] == false)
                {
                    this.Dfs(i);
                }
            }
        }
    }
}
