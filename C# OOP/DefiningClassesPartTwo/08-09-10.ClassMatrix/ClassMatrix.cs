/*Problem 8. Matrix

    Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

Problem 9. Matrix indexer

    Implement an indexer this[row, col] to access the inner matrix cells.

Problem 10. Matrix operations

    Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
    Throw an exception when the operation cannot be performed.
    Implement the true operator (check for non-zero elements).*/

namespace _08_09_10.ClassMatrix
{
    class ClassMatrix
    {
        static void Main()
        {
            Matrix one = new Matrix(4, 3);
            for (int i = 0; i < one.RowCount; i++)
            {
                for (int j = 0; j < one.ColCount; j++)
                {
                    one[i, j] = (i + 1) + j;
                }
            }

            Matrix two = new Matrix(3, 4);
            for (int i = 0; i < two.RowCount; i++)
            {
                for (int j = 0; j < two.ColCount; j++)
                {
                    two[i, j] = (i + 1) + j;
                }
            }

            Matrix result = one - two;
            System.Console.WriteLine("subtraction");
            System.Console.WriteLine(result);
            result = one + two;
            System.Console.WriteLine("addition");
            System.Console.WriteLine(result);
            result = one * two;
            System.Console.WriteLine("multiplication");
            System.Console.WriteLine(result);
        }
    }
}
