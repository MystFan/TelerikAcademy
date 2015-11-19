namespace GameOfLife
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0] + 2, sizes[1] + 2];
            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    matrix[i, j] = int.Parse(line[j - 1]);
                }
            }

            int[,] directions = new int[,]
            {
                { -1, -1},
                {-1, 0 },
                {-1, 1 },
                {0, -1 },
                {0, 1 },
                {1, -1 },
                {1, 0 },
                {1, 1 }
            };

            for (int i = 0; i < N; i++)
            {
                var currentMatrix = CopyMatrix(matrix);

                for (int j = 1; j < matrix.GetLength(0) - 1; j++)
                {
                    for (int k = 1; k < matrix.GetLength(1) - 1; k++)
                    {
                        int counter = 0;
                        for (int p = 0; p < directions.GetLength(0); p++)
                        {
                            if (matrix[j + directions[p, 0], k + directions[p, 1]] == 1)
                            {
                                counter++;
                            }
                        }

                        if (matrix[j, k] == 0)
                        {
                            if(counter == 3)
                            {
                                currentMatrix[j, k] = 1;
                            }
                        }
                        else
                        {
                            if(counter < 2)
                            {
                                currentMatrix[j, k] = 0;
                            }
                            else if(counter > 3)
                            {
                                currentMatrix[j, k] = 0;
                            }
                        }
                    }
                }

                matrix = currentMatrix;
            }

            int finalResult = 0;
            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    if(matrix[i, j] == 1)
                    {
                        finalResult++;
                    }
                }
            }

            Console.WriteLine(finalResult);
        }

        private static int[,] CopyMatrix(int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            return result;
        }
    }
}
