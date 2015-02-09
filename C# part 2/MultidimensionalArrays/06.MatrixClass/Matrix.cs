using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MatrixClass
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

        public int Rows { get; set; }
        public int Cols { get; set; }
        public int RowSize
        {
            get
            {
                return matrix.GetLength(0);
            }
        }

        public int ColSize
        {
            get
            {
                return matrix.GetLength(1);
            }
        }

        public int this[int i,int j]
        {
            get
            {
                return this.matrix[i,j];
            }
            set
            {
                matrix[i,j] = value;
            }
        }
        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            int firstMatrixSize = firstMatrix.Cols * firstMatrix.Rows;
            int secondMatrixSize = secondMatrix.Cols * secondMatrix.Rows;
            Matrix resultMatrix = new Matrix(firstMatrix.Rows,firstMatrix.Cols);
            if (firstMatrixSize != secondMatrixSize)
            {
                throw new ArgumentException("Matrices are trying to adding have a different size");
            }
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    resultMatrix[i,j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }
            return resultMatrix;
        }

        public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
        {
            int firstMatrixSize = firstMatrix.Cols * firstMatrix.Rows;
            int secondMatrixSize = secondMatrix.Cols * secondMatrix.Rows;
            Matrix resultMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);
            if (firstMatrixSize != secondMatrixSize)
            {
                throw new ArgumentException("Matrices are trying to adding have a different size");
            }
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    resultMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
                }
            }
            return resultMatrix;
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            int firstMatrixSize = firstMatrix.Cols * firstMatrix.Rows;
            int secondMatrixSize = secondMatrix.Cols * secondMatrix.Rows;
            Matrix resultMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);
            if (firstMatrixSize != secondMatrixSize)
            {
                throw new ArgumentException("Matrices are trying to adding have a different size");
            }
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    resultMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
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
                    sb.Append(matrix[i,j] + " ");
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
