namespace LoverOf3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class LoverOf3
    {
        private static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int movesCount = int.Parse(Console.ReadLine());
            string moves = Console.ReadLine();
            int[] codes = ParseMoves(moves);

            BigInteger[,] field = FillField(rows, cols);

            BigInteger result = CalculatePownSum(field, codes);
            Console.WriteLine(result);
        }

        private static BigInteger CalculatePownSum(BigInteger[,] field, int[] codes)
        {
            int coef = Math.Max(field.GetLength(0), field.GetLength(1));
            BigInteger sum = 0;
            int currentRow = field.GetLength(0) - 1;
            int currentCol = 0;
            sum = field[currentRow, currentCol];
            field[currentRow, currentCol] = 0;

            for (int i = 0; i < codes.Length; i++)
            {
                int row = codes[i] / coef;
                int col = codes[i] % coef;

                if (row > currentRow)
                {
                    int times = row - currentRow;
                    for (int j = 0; j < times; j++)
                    {
                        currentRow++;
                        sum += field[currentRow, currentCol];
                        field[currentRow, currentCol] = 0;
                    }
                }
                else if (row < currentRow)
                {
                    int times = currentRow - row;
                    for (int j = 0; j < times; j++)
                    {
                        currentRow--;
                        sum += field[currentRow, currentCol];
                        field[currentRow, currentCol] = 0;
                    }
                }

                if (col > currentCol)
                {
                    int times = col - currentCol;
                    for (int j = 0; j < times; j++)
                    {
                        currentCol++;
                        sum += field[currentRow, currentCol];
                        field[currentRow, currentCol] = 0;
                    }
                }
                else if (col < currentCol)
                {
                    int times = currentCol - col;
                    for (int j = 0; j < times; j++)
                    {
                        currentCol--;
                        sum += field[currentRow, currentCol];
                        field[currentRow, currentCol] = 0;
                    }
                }
            }

            return sum;
        }

        private static int[] ParseMoves(string line)
        {
            int[] result = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(n => int.Parse(n))
                               .ToArray();
            return result;
        }

        private static BigInteger[,] FillField(int rows, int cols)
        {
            BigInteger[,] matrix = new BigInteger[rows, cols];

            int index = 0;
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                matrix[i, 0] = (BigInteger)Math.Pow(2, index);
                index++;
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[matrix.GetLength(0) - 1, i] = (BigInteger)Math.Pow(2, i);
            }

            for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrix[row + 1, col] * 2;
                }
            }

            return matrix;
        }
    }
}
