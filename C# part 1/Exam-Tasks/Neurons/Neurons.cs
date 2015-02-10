
namespace Neurons
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;
    class Neurons
    {
        private static int[,] matrix;
        static void Main()
        {
            List<long> numbers = new List<long>();

            while (true)
            {
                long number = long.Parse(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                numbers.Add(number);
            }

            matrix = new int[numbers.Count, 32];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string binary = Convert.ToString(numbers[row], 2).PadLeft(32, '0');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(binary[col].ToString());
                }
            }

            bool startNeuron = false;
            bool endNeuron = false;
            int startPos = 0;
            int endPos = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == 1 && matrix[row, col + 1] == 0 && !startNeuron)
                    {
                        startPos = col + 1;
                        startNeuron = true;
                        continue;
                    }
                    if (startNeuron && matrix[row, col] == 1)
                    {
                        endPos = col - 1;
                        endNeuron = true;
                        break;
                    }
                }
                if (startNeuron && endNeuron)
                {
                    ResetRow(row);
                    FillRow(startPos, endPos, row);
                }
                else
                {
                    ResetRow(row);
                }

                startNeuron = false;
                endNeuron = false;
            }
            PrintNumbers();
        }

        private static void PrintNumbers()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sb.Append(matrix[row, col]);
                }
                BigInteger number = Convert.ToInt64(sb.ToString(), 2);
                sb.Clear();
                Console.WriteLine(number);
            }
        }
        private static void FillRow(int start, int end, int rowNumber)
        {
            for (int col = start; col < end + 1; col++)
            {
                matrix[rowNumber, col] = 1;
            }
        }
        private static void ResetRow(int rowPos)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[rowPos, col] == 1)
                {
                    matrix[rowPos, col] = 0;
                }
            }
        }
    }
}
