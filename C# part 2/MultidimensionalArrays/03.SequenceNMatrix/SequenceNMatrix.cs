/*
 Problem 3. Sequence n matrix

    We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
    Write a program that finds the longest sequence of equal strings in the matrix.

 */
namespace _03.SequenceNMatrix
{
    using System;
    class SequenceNMatrix
    {
        private static string[,] matrix;
        static void Main()
        {
            matrix = new string[,]
            {
                {"ha", "fifi", "ho", "hi" },
                {"hi", "ha", "hi", "hi" },
                {"xx", "ha", "ha", "xi" },
                {"xx", "ha", "ha", "ha" }
            };

            int currentSequence = 0;
            int longestSequence = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    currentSequence = SequenceCount(row, col);
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                    }
                }
            }

            Console.WriteLine("Longest sequence is {0}", longestSequence);
        }

        private static int SequenceCount(int rowPos, int colPos)
        {
            int length = 0;
            int currentLength = 0;
            int currentRow = rowPos;
            int currentCol = colPos;
            string element = matrix[rowPos, colPos];

            do
            {
                if (element.Equals(matrix[currentRow, currentCol]))
                {
                    currentLength++;
                }
                currentRow--;
            } while (currentRow >= 0);

            if (currentLength > length)
            {
                length = currentLength;
            }
            currentLength = 0;
            currentRow = rowPos;
            currentCol = colPos;
            do
            {
                if (element.Equals(matrix[currentRow, currentCol]))
                {
                    currentLength++;
                }
                currentRow++;
            } while (currentRow <= matrix.GetLength(0) - 1);

            if (currentLength > length)
            {
                length = currentLength;
            }
            currentLength = 0;
            currentRow = rowPos;
            currentCol = colPos;
            do
            {
                if (element.Equals(matrix[currentRow, currentCol]))
                {
                    currentLength++;
                }
                currentCol--;
            } while (currentCol >= 0);

            if (currentLength > length)
            {
                length = currentLength;
            }
            currentLength = 0;
            currentRow = rowPos;
            currentCol = colPos;
            do
            {
                if (element.Equals(matrix[currentRow, currentCol]))
                {
                    currentLength++;
                }
                currentCol++;
            } while (currentCol < matrix.GetLength(1));

            if (currentLength > length)
            {
                length = currentLength;
            }
            currentLength = 0;
            currentRow = rowPos;
            currentCol = colPos;
            do
            {
                if (element.Equals(matrix[currentRow, currentCol]))
                {
                    currentLength++;
                }
                currentCol--;
                currentRow--;
            } while (currentCol >= 0 && currentRow >= 0);

            if (currentLength > length)
            {
                length = currentLength;
            }
            currentLength = 0;
            currentRow = rowPos;
            currentCol = colPos;
            do
            {
                if (element.Equals(matrix[currentRow, currentCol]))
                {
                    currentLength++;
                }
                currentCol++;
                currentRow++;
            } while (currentCol <= matrix.GetLength(1) - 1 && currentRow <= matrix.GetLength(0) - 1);

            if (currentLength > length)
            {
                length = currentLength;
            }
            currentLength = 0;
            currentRow = rowPos;
            currentCol = colPos;
            do
            {
                if (element.Equals(matrix[currentRow, currentCol]))
                {
                    currentLength++;
                }
                currentRow--;
                currentCol++;
            } while (currentRow >= 0 && currentCol <= matrix.GetLength(1) - 1);

            if (currentLength > length)
            {
                length = currentLength;
            }
            currentLength = 0;
            currentRow = rowPos;
            currentCol = colPos;
            do
            {
                if (element.Equals(matrix[currentRow, currentCol]))
                {
                    currentLength++;
                }
                currentCol--;
                currentRow++;
            } while (currentCol >= 0 && currentRow <= matrix.GetLength(0) - 1);

            if (currentLength > length)
            {
                length = currentLength;
            }
            currentLength = 0;
            return length;
        }
    }
}
