using System;
namespace Digits
{
    class Digits
    {
        private static int[,] matrix;
        private static char[] separators = new char[] { ' ' };
        private static int sum;
        private const int patternWidth = 2;
        private const int patternHeight = 4;
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            matrix = new int[N, N];
            FillMatrix();
            SearchPattern();
            Console.WriteLine(sum);
        }

        private static void SearchPattern()
        {
            for (int row = 0; row < matrix.GetLength(0) - patternHeight; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - patternWidth; col++)
                {
                    if (matrix[row, col + 2] == 1 && matrix[row + 1, col + 2] == 1 && matrix[row + 1, col + 1] == 1
                        && matrix[row + 2, col] == 1 && matrix[row + 2, col + 2] == 1 && matrix[row + 3, col + 2] == 1
                        && matrix[row + 4, col + 2] == 1)
                    {
                        sum++;
                    }
                    if (matrix[row, col + 1] == 2 && matrix[row + 1, col] == 2 && matrix[row + 1, col + 2] == 2 && matrix[row + 2, col + 2] == 2
                        && matrix[row + 3, col + 1] == 2 && matrix[row + 4, col] == 2 && matrix[row + 4, col + 1] == 2 && matrix[row + 4, col + 2] == 2)
                    {
                        sum += 2;
                    }
                    if (matrix[row, col] == 3 && matrix[row, col + 1] == 3 && matrix[row, col + 2] == 3 && matrix[row + 1, col + 2] == 3
                        && matrix[row + 2, col + 1] == 3 && matrix[row + 2, col + 2] == 3 && matrix[row + 3, col + 2] == 3
                        && matrix[row + 4, col] == 3 && matrix[row + 4, col + 1] == 3 && matrix[row + 4, col + 2] == 3)
                    {
                        sum += 3;
                    }
                    if (matrix[row, col] == 4 && matrix[row, col + 2] == 4 && matrix[row + 1, col] == 4 && matrix[row + 1, col + 2] == 4
                        && matrix[row + 2, col] == 4 && matrix[row + 2, col + 1] == 4 && matrix[row + 2, col + 2] == 4
                        && matrix[row + 3, col + 2] == 4 && matrix[row + 4, col + 2] == 4)
                    {
                        sum += 4;
                    }
                    if (matrix[row, col] == 5 && matrix[row, col + 1] == 5 && matrix[row, col + 2] == 5 && matrix[row + 1, col] == 5
                             && matrix[row + 2, col] == 5 && matrix[row + 2, col + 1] == 5 && matrix[row + 2, col + 2] == 5 && matrix[row + 3, col + 2] == 5
                             && matrix[row + 4, col] == 5 && matrix[row + 4, col + 1] == 5 && matrix[row + 4, col + 2] == 5)
                    {
                        sum += 5;
                    }
                    if (matrix[row, col] == 6 && matrix[row, col + 1] == 6 && matrix[row, col + 2] == 6 && matrix[row + 1, col] == 6
                        && matrix[row + 2, col] == 6 && matrix[row + 2, col + 1] == 6 && matrix[row + 2, col + 2] == 6 && matrix[row + 3, col + 2] == 6
                        && matrix[row + 3, col] == 6 && matrix[row + 4, col] == 6 && matrix[row + 4, col + 1] == 6 && matrix[row + 4, col + 2] == 6)
                    {
                        sum += 6;
                    }
                    if (matrix[row, col] == 7 && matrix[row, col + 1] == 7 && matrix[row, col + 2] == 7 && matrix[row + 1, col + 2] == 7
                       && matrix[row + 2, col + 1] == 7 && matrix[row + 3, col + 1] == 7 && matrix[row + 4, col + 1] == 7)
                    {
                        sum += 7;
                    }
                    if (matrix[row, col] == 8 && matrix[row, col + 1] == 8 && matrix[row, col + 2] == 8 && matrix[row + 1, col] == 8
                       && matrix[row + 1, col + 2] == 8 && matrix[row + 2, col + 1] == 8 && matrix[row + 3, col] == 8
                       && matrix[row + 3, col + 2] == 8 && matrix[row + 4, col] == 8 && matrix[row + 4, col + 1] == 8 && matrix[row + 4, col + 2] == 8)
                    {
                        sum += 8; ;
                    }
                    if (matrix[row, col] == 9 && matrix[row, col + 1] == 9 && matrix[row, col + 2] == 9 && matrix[row + 1, col] == 9
                        && matrix[row + 1, col + 2] == 9 && matrix[row + 2, col + 1] == 9 && matrix[row + 2, col + 2] == 9 && matrix[row + 3, col + 2] == 9
                        && matrix[row + 4, col] == 9 && matrix[row + 4, col + 1] == 9 && matrix[row + 4, col + 2] == 9)
                    {
                        sum += 9;
                    }
                }
            }
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
