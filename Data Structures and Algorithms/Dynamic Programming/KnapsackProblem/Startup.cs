namespace KnapsackProblem
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../in.txt");
            Console.SetIn(reader);

            int maxWeight = int.Parse(Console.ReadLine());

            List<int> weights = new List<int>();
            List<int> values = new List<int>();
            List<Product> products = new List<Product>();

            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] productParts = line.Split(' ');
                weights.Add(int.Parse(productParts[1]));
                values.Add(int.Parse(productParts[2]));
                products.Add(new Product
                {
                    Name = productParts[0],
                    Weight = int.Parse(productParts[1]),
                    Cost = int.Parse(productParts[2])
                });

                line = Console.ReadLine();
            }

            int n = weights.Count;

            int[,] matrix = new int[n + 1, maxWeight];
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                var currentWeigth = weights[i - 1];
                var benefit = values[i - 1];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if(currentWeigth <= j)
                    {
                        if (benefit + matrix[i - 1, j - currentWeigth] > matrix[i - 1, j])
                        {
                            matrix[i, j] = (benefit + matrix[i - 1, j - currentWeigth]);
                        }
                        else
                        {
                            matrix[i, j] = matrix[i - 1, j];
                        }
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j];
                    }
                }
            }

            Console.WriteLine("Optimal Coast: {0}", matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1]);
            List<Product> knapsackProducts = GetKnapsackProducts(matrix, products);
            Console.WriteLine(string.Join("\n", knapsackProducts));
        }

        private static List<Product> GetKnapsackProducts(int[,] matrix, List<Product> products)
        {
            List<Product> result = new List<Product>();

            int rowIndex = matrix.GetLength(0) - 1;
            int colIndex = matrix.GetLength(1) - 1;
            while (rowIndex > 0 && colIndex > 0)
            {
                if(matrix[rowIndex, colIndex] != matrix[rowIndex - 1, colIndex])
                {
                    var product = products[rowIndex - 1];
                    result.Add(product);
                    colIndex = colIndex - product.Weight;
                    rowIndex -= 1;
                }
                else
                {
                    rowIndex -= 1;
                }
            }

            return result;
        }
    }
}
