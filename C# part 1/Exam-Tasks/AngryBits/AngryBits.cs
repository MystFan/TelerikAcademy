namespace AngryBits
{
    using System;
    class AngryBits
    {
        private static short[,] grid;
        private static int killPigsCount;
        private static int flyCount;
        private static int sum;
        static void Main()
        {
            grid = new short[8, 16];
            FillGrid();
            killPigsCount = 0;
            flyCount = 0;
            sum = 0;
            for (int col = grid.GetLength(1) - 9; col >= 0; col--)
            {
                for (int row = 0; row < grid.GetLength(0); row++)
                {
                    if (grid[row, col] == 1)
                    {
                        BirdFly(row, col);
                        flyCount = 0;
                        killPigsCount = 0;
                    }
                }
            }
            if (WinGame())
            {
                Console.WriteLine(sum + " Yes");
            }
            else
            {
                Console.WriteLine(sum + " No");
            }
        }

        private static void BirdFly(int rowPos, int colPos)
        {
            string direction = String.Empty;
            if (rowPos > 0)
            {
                direction = "up";
            }
            else if (rowPos == 0)
            {
                direction = "down";
            }
            int startRow = rowPos;
            int startCol = colPos;
            grid[rowPos, colPos] = 0;
            while (true)
            {
                if (direction == "up")
                {
                    startRow--;
                    startCol++;
                }
                if (direction == "down")
                {
                    startRow++;
                    startCol++;
                }
                flyCount++;

                if (startCol > 7)
                {
                    if (startRow == 7 && startCol == 8)
                    {
                        if (grid[startRow, startCol] == 1)
                        {
                            KillPigs(startRow - 1, startCol, startRow, startCol + 1);
                            sum += (killPigsCount * flyCount);
                            break;
                        }
                    }
                    else if (startRow == grid.GetLength(0) - 1 && startCol == grid.GetLength(1) - 1)
                    {
                        if (grid[startRow, startCol] == 1)
                        {
                            KillPigs(startRow - 1, startCol - 1, startRow, startCol);
                            sum += (killPigsCount * flyCount);
                            break;
                        }
                    }
                    else if (startRow == 0 && startCol == 8)
                    {
                        if (grid[startRow, startCol] == 1)
                        {
                            KillPigs(startRow, startCol, startRow + 1, startCol + 1);
                            sum += (killPigsCount * flyCount);
                            break;
                        }
                    }
                    else if (startRow == 0 && startCol == grid.GetLength(1) - 1)
                    {
                        if (grid[startRow, startCol] == 1)
                        {
                            KillPigs(startRow, startCol - 1, startRow + 1, startCol);
                            sum += (killPigsCount * flyCount);
                            break;
                        }
                    }
                    else if (startCol > 8 && startCol < grid.GetLength(1) - 1 && startRow > 0 && startRow < grid.GetLength(0) - 1)
                    {
                        if (grid[startRow, startCol] == 1)
                        {
                            KillPigs(startRow - 1, startCol - 1, startRow + 1, startCol + 1);
                            sum += (killPigsCount * flyCount);
                            break;
                        }
                    }
                    else if (startRow == grid.GetLength(0) - 1 && startCol > 7 && startCol < grid.GetLength(1) - 1)
                    {
                        if (grid[startRow, startCol] == 1)
                        {
                            KillPigs(startRow - 1, startCol - 1, startRow, startCol + 1);
                            sum += (killPigsCount * flyCount);
                            break;
                        }
                    }
                    else if (startRow == 0 && startCol > 8 && startCol < grid.GetLength(1) - 1)
                    {
                        if (grid[startRow, startCol] == 1)
                        {
                            KillPigs(startRow, startCol - 1, startRow + 1, startCol + 1);
                            sum += (killPigsCount * flyCount);
                            break;
                        }
                    }
                    else if (startCol == 8 && startRow > 0 && startRow < grid.GetLength(0) - 1)
                    {
                        if (grid[startRow, startCol] == 1)
                        {
                            KillPigs(startRow - 1, startCol, startRow + 1, startCol + 1);
                            sum += (killPigsCount * flyCount);
                            break;
                        }
                    }
                    else if (startCol == grid.GetLength(1) - 1 && startRow > 0 && startRow < grid.GetLength(0) - 1)
                    {
                        if (grid[startRow, startCol] == 1)
                        {
                            KillPigs(startRow - 1, startCol - 1, startRow + 1, startCol);
                            sum += (killPigsCount * flyCount);
                            break;
                        }
                    }
                }

                if (direction == "down" && startRow == grid.GetLength(0) - 1)
                {
                    break;
                }
                if (startCol == grid.GetLength(1) - 1 && (direction == "up" || direction == "down"))
                {
                    break;
                }

                if (startRow == 0)
                {
                    direction = "down";
                }
                if (startRow == grid.GetLength(0) - 1)
                {
                    direction = "up";
                }

            }
        }

        private static void KillPigs(int rowStart, int colStart, int rowEnd, int colEnd)
        {
            for (int i = rowStart; i <= rowEnd; i++)
            {
                for (int j = colStart; j <= colEnd; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        grid[i, j] = 0;
                        killPigsCount++;
                    }
                }
            }
        }
        private static void FillGrid()
        {
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                int number = int.Parse(Console.ReadLine());
                string numberAsString = Convert.ToString(number, 2).PadLeft(16, '0');
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    grid[row, col] = short.Parse(numberAsString[col].ToString());
                }
            }
        }

        private static bool WinGame()
        {
            bool result = true;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 8; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        result = false;
                    }
                }
            }
            return result;
        }
    }
}
