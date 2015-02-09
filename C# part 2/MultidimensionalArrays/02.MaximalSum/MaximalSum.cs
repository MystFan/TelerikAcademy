/*
 Problem 2. Maximal sum

    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

 */
namespace _02.MaximalSum
{
    using System;
    class MaximalSum
    {
        private static int[,] matrix;
        static void Main()
        {
            Console.Write("Enter width of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter height of the matrix: ");
            int m = int.Parse(Console.ReadLine());
            matrix  = new int[n, m];
            int maxPlatform = 0;
            int currentPlatform = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 1; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 1; col < matrix.GetLength(1) - 1; col++)
                {
                    currentPlatform = CalculatePlatform(row, col);
                    if (currentPlatform > maxPlatform)
                    {
                        maxPlatform = currentPlatform;
                    }
                }
                currentPlatform = 0;
            }
            Console.WriteLine("maximal sum of the elements in squere platform 3 X 3 is: {0}", maxPlatform);
        }

        private static int CalculatePlatform(int rowPos, int colPos)
        {
            int sum = 0;
            int startRow = rowPos - 1;
            int startCol = colPos - 1;
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    sum += matrix[row, col];
                }
            }
            return sum;
        }
    }
}
