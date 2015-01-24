namespace QuadronacciRectangle
{
    using System;
    using System.Collections.Generic;
    class QuadronacciRectangle
    {
        static void Main()
        {
            List<long> numbers = new List<long>();
            for (int i = 0; i < 4; i++)
            {
                long number = long.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int seqLength = (rows * cols);

            long[,] matrix = new long[rows, cols];

            for (int i = 4; i < seqLength; i++)
            {
                long sum = numbers[i - 1] + numbers[i - 2] + numbers[i - 3] + numbers[i - 4];
                numbers.Add(sum);
            }

            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[counter];
                    counter++;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
