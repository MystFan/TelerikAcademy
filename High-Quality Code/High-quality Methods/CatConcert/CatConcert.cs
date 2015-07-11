namespace CatConcert
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class CatConcert
    {
        private static int GetCount(string line)
        {
            string[] data = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = int.Parse(data[0]);
            return count;
        }

        private static List<string> ReadLines()
        {
            List<string> lines = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Mew!")
                {
                    break;
                }

                lines.Add(line);
            }

            return lines;
        }

        private static int[,] FillMatrix(List<string> lines, int catsCount, int songsCount)
        {
            int[,] matrix = new int[catsCount, songsCount];

            for (int i = 0; i < lines.Count; i++)
            {
                string[] data = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(data[1]) - 1;
                int col = int.Parse(data[4]) - 1;
                matrix[row, col] = 1;
            }

            return matrix;
        }

        private static void Main()
        {
            StreamReader reader = new StreamReader("..\\..\\3.txt");
            Console.SetIn(reader);

            string catsCount = Console.ReadLine();
            int cats = GetCount(catsCount);
            string songsCount = Console.ReadLine();
            int songs = GetCount(songsCount);

            List<string> lines = ReadLines();

            int[,] matrix = FillMatrix(lines, cats, songs);

            List<int> numbers = new List<int>();
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        counter++;
                    }
                }

                if (counter > 0)
                {
                    numbers.Add(counter);
                }

                counter = 0;
            }

            if (numbers.Count < cats)
            {
                Console.WriteLine("No concert!");
            }
            else
            {
                counter = 0;
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        if (matrix[j, i] == 1)
                        {
                            counter++;
                            break;
                        }
                    }
                }

                Console.WriteLine(counter);
            }
        }
    }
}
