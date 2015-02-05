
namespace Pillars
{
    using System;
    class Pillars
    {
        private static int[,] matrix;
        static void Main(string[] args)
        {
            matrix = new int[8, 8];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int num = int.Parse(Console.ReadLine());
                string number = Convert.ToString(num, 2).PadLeft(8, '0');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(number[col].ToString());
                }
            }
            bool isPillarFaund = false;
            int left = 0;
            int right = 0;
            int pillarCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1) - 1; col++)
                {
                    left = BitsCount(0, col);
                    right = BitsCount(col + 1, matrix.GetLength(1));
                    if (left == right)
                    {
                        isPillarFaund = true;
                        pillarCol = col;
                        break;
                    }
                }
                if (isPillarFaund)
                {
                    break;
                }
            }

            if (isPillarFaund)
            {
                Console.WriteLine((matrix.GetLength(1) - 1) - pillarCol);
                Console.WriteLine(left);
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static int BitsCount(int startCol, int endCol)
        {
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = startCol; col < endCol; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
