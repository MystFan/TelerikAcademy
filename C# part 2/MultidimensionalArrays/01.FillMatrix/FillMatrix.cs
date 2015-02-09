/*
 Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:

 */
namespace _01.FillMatrix
{
    using System;
    class FillMatrix
    {
        private static int[,] matrix;
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];

            Console.WriteLine("matrix A");
            FillMatrixA();
            PrintMatrix();
            Console.WriteLine("matrix B");
            FillMatrixB();
            PrintMatrix();
            Console.WriteLine("matrix C");
            FillMatrixC();
            PrintMatrix();
            Console.WriteLine("matrix D");
            FillMatrixD();
            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            int lastNumber = matrix.GetLength(0) * matrix.GetLength(1);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string space = String.Empty;
                    if (matrix[row, col].ToString().Length == lastNumber.ToString().Length)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    else
                    {
                        space = new string(' ', (lastNumber.ToString().Length + 1) - matrix[row, col].ToString().Length);
                        Console.Write(matrix[row, col] + space);
                    }
                }
                Console.WriteLine();
            }
        }
        private static void FillMatrixA()
        {
            int counter = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
        }

        private static void FillMatrixB()
        {
            int counter = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix.GetLength(1) % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                    if (counter % 2 == 0)
                    {
                        col++;
                        for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                        {
                            matrix[row, col] = counter;
                            counter++;
                        }
                    }
                }
                if (matrix.GetLength(1) % 2 != 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                    if (counter < (matrix.GetLength(0) * matrix.GetLength(0)))
                    {
                        col++;
                        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                        {
                            matrix[row, col] = counter;
                            counter++;
                        }
                    }
                }
            }
        }
        private static void FillMatrixC()
        {
            int counter = 1;
            int lastNumber = matrix.GetLength(0) * matrix.GetLength(1);
            int row = matrix.GetLength(0) - 1;
            int col = 0;
            matrix[row, col] = counter;
            int currentRow = 0;
            int currentCol = 0;
            int bottom = 1;
            while (true)
            {
                if (counter == lastNumber)
                {
                    break;
                }
                if (row == 0)
                {
                    col++;
                    bottom++;
                }
                if (row > 0)
                {
                    row--;
                }
                counter++;
                matrix[row, col] = counter;
                currentCol = col;
                currentRow = row;
                while (currentRow < matrix.GetLength(0) - bottom)
                {
                    currentCol++;
                    currentRow++;
                    counter++;
                    matrix[currentRow, currentCol] = counter;
                }
            }
        }
        private static void FillMatrixD()
        {
            int[,] checkMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
            for (int i = 0; i < checkMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < checkMatrix.GetLength(1); j++)
                {
                    checkMatrix[i, j] = 1;
                }
            }
            string direction = "down";
            int maxLength = (matrix.GetLength(0) * matrix.GetLength(1)) - 1;
            int row = 0;
            int col = 0;
            int counter = 1;
            matrix[row, col] = counter;
            checkMatrix[row, col] = 0;

            while (maxLength > 0)
            {

                if (direction == "right" && col < matrix.GetLength(1) - 1)
                {
                    col++;
                }
                if (direction == "down" && row < matrix.GetLength(0) - 1)
                {
                    row++;
                }
                if (direction == "left" && col > 0)
                {
                    col--;
                }
                if (direction == "up" && row > 0)
                {
                    row--;
                }
                checkMatrix[row, col] = 0;

                counter++;
                matrix[row, col] = counter;

                if (row == matrix.GetLength(0) - 1 && col == 0)
                {
                    direction = "right";
                }
                if (col == matrix.GetLength(1) - 1 && row == matrix.GetLength(0) - 1)
                {
                    direction = "up";
                }
                if (row == 0 && col == matrix.GetLength(1) - 1)
                {
                    direction = "left";
                }
                else if (direction == "right" && checkMatrix[row, col + 1] == 0)
                {
                    direction = "up";
                }
                else if (direction == "down" && checkMatrix[row + 1, col] == 0)
                {
                    direction = "right";
                }
                else if (direction == "up" && checkMatrix[row - 1, col] == 0)
                {
                    direction = "left";
                }
                else if (direction == "left" && checkMatrix[row, col - 1] == 0)
                {
                    direction = "down";
                }

                maxLength--;
            }
        }
    }
}
