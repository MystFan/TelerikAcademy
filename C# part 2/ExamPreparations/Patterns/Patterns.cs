using System;
using System.Numerics;

namespace Patterns
{
    class Patterns
    {
        private static int[,] matrix;
        private static char[] separators = new char[] { ' ' };
        private const int patternWidth = 5;
        private const int patternHeight = 3;

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            matrix = new int[N, N];
            FillMatrix();
            CountPatterns();
        }

        private static void CountPatterns()
        {
            BigInteger sum = 0;
            BigInteger maxSum = BigInteger.Zero;
            int countPatterns = 0;
            if (matrix.GetLength(0) >= patternWidth && matrix.GetLength(1) >= patternHeight)
            {
                for (int row = 0; row < matrix.GetLength(0) - (patternHeight - 1); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - (patternWidth - 1); col++)
                    {
                        bool isPattern = ((matrix[row, col] == matrix[row, col + 1] - 1) && (matrix[row, col + 1] == matrix[row, col + 2] - 1)
                            && (matrix[row, col + 2] == matrix[row + 1, col + 2] - 1) && (matrix[row + 1, col + 2] == matrix[row + 2, col + 2] - 1)
                        && (matrix[row + 2, col + 3] == matrix[row + 2, col + 4] - 1));
                        if (isPattern)
                        {
                            sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2] + matrix[row + 2, col + 3] + matrix[row + 2, col + 4];
                            if (sum > maxSum)
                            {
                                maxSum = sum;
                            }
                            sum = 0;
                            countPatterns++;
                        }
                    }
                }
            }

            if (countPatterns > 0)
            {
                Console.WriteLine("YES {0}", maxSum);
            }
            else
            {
                int calcSum = CalculateMatrixMainDiagonal();
                Console.WriteLine("NO {0}", calcSum);
            }

        }

        private static int CalculateMatrixMainDiagonal()
        {
            int row = 0;
            int col = 0;
            int sum = 0;
            while (row < matrix.GetLength(0) && col < matrix.GetLength(1))
            {
                sum += matrix[row, col];
                row++;
                col++;
            }
            return sum;
        }

        private static void FillMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] numbers = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[i, col] = int.Parse(numbers[col]);
                }
            }
        }
    }
}
