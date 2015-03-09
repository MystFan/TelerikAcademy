/*
 Problem 5. Maximal area sum

    Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.

Example:
input 	output
4
2 3 3 4
0 2 3 4
3 7 1 2
4 3 3 2 	17
 */
namespace _05.MaximalAreaSum
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class MaximalAreaSum
    {
        private static int[,] matrix;
        static void Main()
        {
            string input = @"..\..\matrixInput.txt";
            string output = @"..\..\matrixOutput.txt";
            FillMatrix(input);
            CalculateMaxPlatform(output);
        }

        private static void FillMatrix(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<string> list = new List<string>();
            int matrixSize = 0;
            string line = String.Empty;

            using (reader)
            {
                line = reader.ReadLine();
                matrixSize = int.Parse(line);
                while (line != null)
                {
                    line = reader.ReadLine();
                    list.Add(line);
                }
            }

            matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                string[] arr = list[row].Split(' ');
                for (int col = 0; col < arr.Length; col++)
                {
                    matrix[row, col] = int.Parse(arr[col]);
                }
            }
        }

        private static void CalculateMaxPlatform(string path)
        {
            int currentPlatform = 0;
            int maxPlatform = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentPlatform = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (maxPlatform < currentPlatform)
                    {
                        maxPlatform = currentPlatform;
                    }
                    currentPlatform = 0;
                }
            }
            StreamWriter writer = new StreamWriter(path);
            using (writer)
            {
                writer.WriteLine(maxPlatform);
            }
            Console.WriteLine("Now in file \"matrixOutput.txt\" is location result {0}", maxPlatform);
        }
    }
}
