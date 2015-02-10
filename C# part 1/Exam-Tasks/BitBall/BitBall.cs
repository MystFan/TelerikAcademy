
namespace BitBall
{
    using System;
    class BitBall
    {
        static void Main()
        {
            char[,] field = new char[8, 8];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                int num = int.Parse(Console.ReadLine());
                string numAsString = Convert.ToString(num, 2).PadLeft(8, '0');
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    int bit = int.Parse(numAsString[j].ToString());
                    if (bit == 1)
                    {
                        field[i, j] = 'T';
                    }
                    if (bit == 0)
                    {
                        field[i, j] = '\0';
                    }
                }
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                int num = int.Parse(Console.ReadLine());
                string numAsString = Convert.ToString(num, 2).PadLeft(8, '0');
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    int bit = int.Parse(numAsString[j].ToString());
                    if (bit == 1 && field[i, j] == '\0')
                    {
                        field[i, j] = 'B';
                    }
                    if (bit == 1 && field[i, j] == 'T')
                    {
                        field[i, j] = '\0';
                    }
                }
            }

            int topScore = 0;
            int bottomScore = 0;

            for (int col = 0; col < field.GetLength(1); col++)
            {
                for (int row = field.GetLength(0) - 1; row >= 0; row--)
                {
                    if (field[row, col] != '\0')
                    {
                        if (field[row, col] == 'T')
                        {
                            topScore++;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            for (int col = 0; col < field.GetLength(1); col++)
            {
                for (int row = 0; row < field.GetLength(0); row++)
                {
                    if (field[row, col] != '\0')
                    {
                        if (field[row, col] == 'B')
                        {
                            bottomScore++;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(topScore + ":" + bottomScore);
        }
    }
}
