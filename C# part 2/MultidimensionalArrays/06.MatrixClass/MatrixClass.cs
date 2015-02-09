/*
Problem 6.* Matrix class

    Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

*/
namespace _06.MatrixClass
{
    using System;

    class MatrixClass
    {
        static void Main()
        {
            try
            {
                Random rand = new Random();
                Matrix firstMatrix = new Matrix(4, 5);
                Console.WriteLine("First matrix");
                for (int i = 0; i < firstMatrix.RowSize; i++)
                {
                    for (int j = 0; j < firstMatrix.ColSize; j++)
                    {
                        firstMatrix[i, j] = rand.Next(1, 50);
                    }
                }
                Console.WriteLine(firstMatrix.ToString());

                Matrix secondMatrix = new Matrix(4, 5);
                Console.WriteLine("Second matrix");
                for (int i = 0; i < secondMatrix.RowSize; i++)
                {
                    for (int j = 0; j < secondMatrix.ColSize; j++)
                    {
                        secondMatrix[i, j] = i + j;
                    }
                }
                Console.WriteLine(secondMatrix.ToString());

                Matrix result = firstMatrix * secondMatrix;
                Console.WriteLine("Multiplying");
                Console.WriteLine(result.ToString());

                Console.WriteLine("Subtracting");
                result = firstMatrix - secondMatrix;
                Console.WriteLine(result.ToString());

                Console.WriteLine("Adding");
                result = firstMatrix + secondMatrix;
                Console.WriteLine(result.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
