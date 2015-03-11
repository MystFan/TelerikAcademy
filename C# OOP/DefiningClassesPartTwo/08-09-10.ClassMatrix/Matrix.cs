using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_09_10.ClassMatrix
{
    public class Matrix
    {
        private int[,] matrix;
        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            matrix = new int[this.Rows, this.Cols];
        }

        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public int RowCount
        {
            get
            {
                return matrix.GetLength(0);
            }
        }

        public int ColCount
        {
            get
            {
                return matrix.GetLength(1);
            }
        }

        public int this[int i, int j]
        {
            get
            {
                return this.matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }

        public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Cols == secondMatrix.Cols && firstMatrix.Rows == secondMatrix.Cols)
            {
                var matrixResult = new Matrix(firstMatrix.Rows, secondMatrix.Cols);
                for (int row = 0; row < matrixResult.RowCount; row++)
                {
                    for (int col = 0; col < matrixResult.ColCount; col++)
                    {
                        matrixResult[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
                    }
                }
                return matrixResult;
            }
            int widthOne = firstMatrix.ColCount;
            int heightOne = firstMatrix.RowCount;
            int widthTwo = secondMatrix.ColCount;
            int heightTwo = secondMatrix.RowCount;

            if (widthOne != heightTwo)
            {
                throw new ArgumentException("Invalid dimensions!");
            }

            var resultMatrix = new Matrix(heightOne, widthTwo);

            for (int row = 0; row < heightOne; row++)
            {
                for (int col = 0; col < widthTwo; col++)
                {
                    resultMatrix[row, col] = 0;
                    for (int i = 0; i < widthOne; i++)
                    {
                        resultMatrix[row, col] =
                            firstMatrix[row, i] + secondMatrix[i, col];
                    }
                }
            }
            return resultMatrix;
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            int widthOne = firstMatrix.ColCount;
            int heightOne = firstMatrix.RowCount;
            int widthTwo = secondMatrix.ColCount;
            int heightTwo = secondMatrix.RowCount;

            if (widthOne != heightTwo)
            {
                throw new ArgumentException("Invalid dimensions!");
            }

            var resultMatrix = new Matrix(heightOne, widthTwo);

            for (int row = 0; row < heightOne; row++)
            {
                for (int col = 0; col < widthTwo; col++)
                {
                    resultMatrix[row, col] = 0;
                    for (int i = 0; i < widthOne; i++)
                    {
                        resultMatrix[row, col] +=
                            firstMatrix[row, i] * secondMatrix[i, col];
                    }
                }
            }
            return resultMatrix;
        }

        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Cols == secondMatrix.Cols && firstMatrix.Rows == secondMatrix.Cols)
            {
                var matrixResult = new Matrix(firstMatrix.Rows, secondMatrix.Cols);
                for (int row = 0; row < matrixResult.RowCount; row++)
                {
                    for (int col = 0; col < matrixResult.ColCount; col++)
                    {
                        matrixResult[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
                    }
                }
                return matrixResult;
            }
            int widthOne = firstMatrix.ColCount;
            int heightOne = firstMatrix.RowCount;
            int widthTwo = secondMatrix.ColCount;
            int heightTwo = secondMatrix.RowCount;

            if (widthOne != heightTwo)
            {
                throw new ArgumentException("Invalid dimensions!");
            }

            var resultMatrix = new Matrix(heightOne, widthTwo);

            for (int row = 0; row < heightOne; row++)
            {
                for (int col = 0; col < widthTwo; col++)
                {
                    resultMatrix[row, col] = 0;
                    for (int i = 0; i < widthOne; i++)
                    {
                        resultMatrix[row, col] =
                            firstMatrix[row, i] + secondMatrix[i, col];
                    }
                }
            }
            return resultMatrix;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                if (i < matrix.GetLength(0) - 1)
                {
                    sb.Append("\n");
                }
            }
            return sb.ToString();
        }
    }
}
