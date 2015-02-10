
namespace NaBabaMiSmetalnika
{
    using System;
    using System.Numerics;
    using System.Text;
    class NaBabaMiSmetalnika
    {
        private static int[,] smetalo;
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());

            smetalo = new int[8, width];

            for (int row = 0; row < smetalo.GetLength(0); row++)
            {
                int number = int.Parse(Console.ReadLine());
                string numberAsString = Convert.ToString(number, 2).PadLeft(width, '0');
                for (int col = 0; col < smetalo.GetLength(1); col++)
                {
                    smetalo[row, col] = int.Parse(numberAsString[col].ToString());
                }
            }
            int currentRow = 0;
            int currentCol = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                if (command == "reset")
                {
                    Reset();
                }
                else
                {
                    currentRow = int.Parse(Console.ReadLine());
                    currentCol = int.Parse(Console.ReadLine());
                }

                if (command == "left")
                {
                    if (currentCol < 0)
                    {
                        currentCol = 0;
                    }
                    if (currentCol > width - 1)
                    {
                        currentCol = width - 1;
                    }
                    Left(currentRow, currentCol);
                }
                if (command == "right")
                {
                    if (currentCol < 0)
                    {
                        currentCol = 0;
                    }
                    if (currentCol > width - 1)
                    {
                        currentCol = width - 1;
                    }
                    Right(currentRow, currentCol);
                }
            }
            BigInteger result = CalculateSmetalo();
            Console.WriteLine(result);
        }

        private static void Right(int rowPos, int colPos)
        {
            int counter = 0;
            for (int col = colPos; col < smetalo.GetLength(1); col++)
            {
                if (smetalo[rowPos, col] == 1)
                {
                    counter++;
                    smetalo[rowPos, col] = 0;
                }
            }
            for (int col = smetalo.GetLength(1) - 1; col >= smetalo.GetLength(1) - counter; col--)
            {
                smetalo[rowPos, col] = 1;
            }
        }
        private static void Left(int rowPos, int colPos)
        {
            int counter = 0;
            for (int col = colPos; col >= 0; col--)
            {
                if (smetalo[rowPos, col] == 1)
                {
                    counter++;
                    smetalo[rowPos, col] = 0;
                }
            }
            for (int col = 0; col < counter; col++)
            {
                smetalo[rowPos, col] = 1;
            }
        }
        private static int EmptyColumns()
        {
            int counter = 0;
            bool isEmptyCol = true;
            for (int col = 0; col < smetalo.GetLength(1); col++)
            {
                for (int row = 0; row < smetalo.GetLength(0); row++)
                {
                    if (smetalo[row, col] == 1)
                    {
                        isEmptyCol = false;
                        break;
                    }
                }
                if (isEmptyCol)
                {
                    counter++;
                }
                isEmptyCol = true;
            }
            return counter;
        }
        private static BigInteger CalculateSmetalo()
        {
            StringBuilder sb = new StringBuilder();
            int emptyCols = EmptyColumns();
            BigInteger sum = 0;
            for (int row = 0; row < smetalo.GetLength(0); row++)
            {
                for (int col = 0; col < smetalo.GetLength(1); col++)
                {
                    sb.Append(smetalo[row, col].ToString());
                }
                long number = Convert.ToInt64(sb.ToString(), 2);
                sum += number;
                sb.Clear();
            }

            BigInteger result = sum * emptyCols;
            return result;
        }
        private static void Reset()
        {
            int counter = 0;
            for (int row = 0; row < smetalo.GetLength(0); row++)
            {
                for (int col = 0; col < smetalo.GetLength(1); col++)
                {
                    if (smetalo[row, col] == 1)
                    {
                        counter++;
                        smetalo[row, col] = 0;
                    }
                }

                for (int i = 0; i < counter; i++)
                {
                    smetalo[row, i] = 1;
                }
                counter = 0;
            }
        }
    }
}
