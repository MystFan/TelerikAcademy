namespace Guitar
{
    using System;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            int[] volumes = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray();

            int minVolume = int.Parse(Console.ReadLine());
            int maxVolume = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numberOfSongs + 1, maxVolume + 1];
            matrix[0, minVolume] = 1;

            for (int i = 1; i <= numberOfSongs; i++)
            {
                for (int j = 0; j <= maxVolume; j++)
                {
                    if(matrix[i - 1, j] == 1)
                    {
                        if(j - volumes[i - 1] >= 0)
                        {
                            matrix[i, j - volumes[i - 1]] = 1;
                        }

                        if(j + volumes[i - 1] <= maxVolume)
                        {
                            matrix[i, j + volumes[i - 1]] = 1;
                        }
                    }
                }
            }

            for (int i = maxVolume; i >= 0; i--)
            {
                if(matrix[numberOfSongs, i] == 1)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}
