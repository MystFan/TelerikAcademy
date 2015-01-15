using System;
/*
 Problem 19.** Spiral Matrix

    Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

 */

namespace _19.SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer number n (1 = n = 20)");
            Console.Write("n = ");
            string inputN = Console.ReadLine();

            int n;
            bool isNumberN = int.TryParse(inputN, out n);
            bool isValidN = n > 0 && n <= 20;

            if (isNumberN && isValidN)
            {
                int[,] matrix = new int[n, n];
                int[,] checkMatrix = new int[n, n];
                for (int i = 0; i < checkMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < checkMatrix.GetLength(1); j++)
                    {
                        checkMatrix[i, j] = 1;
                    }
                }
                string direction = "right";
                int maxLength = (n * n) - 1;
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

                    if (col == matrix.GetLength(1) - 1 && row == 0)
                    {
                        direction = "down";
                    }
                    if (col == 0 && row == matrix.GetLength(0) - 1)
                    {
                        direction = "up";
                    }
                    if (row == matrix.GetLength(0) - 1 && col == matrix.GetLength(1) - 1)
                    {
                        direction = "left";
                    }
                    else if (direction == "right" && checkMatrix[row, col + 1] == 0)
                    {
                        direction = "down";
                    }
                    else if (direction == "down" && checkMatrix[row + 1, col] == 0)
                    {
                        direction = "left";
                    }
                    else if (direction == "up" && checkMatrix[row - 1, col] == 0)
                    {
                        direction = "right";
                    }
                    else if (direction == "left" && checkMatrix[row, col - 1] == 0)
                    {
                        direction = "up";
                    }
                  
                    maxLength--;
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j].ToString().Length == 3)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        if (matrix[i, j].ToString().Length == 2)
                        {
                            Console.Write(matrix[i, j] + "  ");
                        }
                        if (matrix[i, j].ToString().Length == 1)
                        {
                            Console.Write(matrix[i,j] + "   ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Input string was not in correct format");
            }
        }
    }
}
