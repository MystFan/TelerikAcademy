using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KukataISDancing
{
    class KukataISDancing
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[, ,] cube = new char[3, 3, 3];
            int[] dims = new int[] { 3, 3, 3 };
            for (int row = 0; row < cube.GetLength(0); row++)
            {
                for (int col = 0; col < cube.GetLength(1); col++)
                {
                    for (int dep = 0; dep < cube.GetLength(2); dep++)
                    {
                        int[] pos = new int[] { row, col, dep };
                        int count = IndexesCount(pos, dims);
                        if (count == 3)
                        {
                            cube[row, col, dep] = 'R';
                        }
                        else if (count == 1)
                        {
                            cube[row, col, dep] = 'G';
                        }
                        else
                        {
                            cube[row, col, dep] = 'B';
                        }
                    }
                }
            }

            List<string> commands = new List<string>();

            for (int i = 0; i < n; i++)
            {
                commands.Add(Console.ReadLine());
            }

            string position = "GREEN";
            string direction = "back";
            int[] kukataPos = new int[] { 0, 1, 1 };
            for (int i = 0; i < commands.Count; i++)
            {
                string command = commands[i];

                if (command.IndexOf("W") >= 0)
                {
                    for (int j = 0; j < command.Length; j++)
                    {
                        if (command[j] == 'W')
                        {
                            if (direction == "back")
                            {
                                if (kukataPos[2] < 2)
                                {
                                    kukataPos[2]++;
                                }
                                else if (kukataPos[2] == 2)
                                {
                                    kukataPos[2] = 0;
                                }
                            }
                            if (direction == "left")
                            {
                                if (kukataPos[1] > 0)
                                {
                                    kukataPos[1]--;
                                }
                                else if (kukataPos[1] == 0)
                                {
                                    kukataPos[1] = 2;
                                }
                            }
                            if (direction == "right")
                            {
                                if (kukataPos[1] < 2)
                                {
                                    kukataPos[1]++;
                                }
                                else if (kukataPos[1] == 2)
                                {
                                    kukataPos[1] = 0;
                                }
                            }
                            if (direction == "front")
                            {
                                if (kukataPos[2] > 0)
                                {
                                    kukataPos[2]--;
                                }
                                else if (kukataPos[2] == 0)
                                {
                                    kukataPos[2] = 2;
                                }
                            }
                        }

                        if (command[j] == 'L')
                        {
                            if (direction == "back")
                            {
                                direction = "left";
                            }
                            else if (direction == "left")
                            {
                                direction = "front";
                            }
                            else if (direction == "right")
                            {
                                direction = "back";
                            }
                            else if (direction == "front")
                            {
                                direction = "right";
                            }
                        }

                        if (command[j] == 'R')
                        {
                            if (direction == "back")
                            {
                                direction = "right";
                            }
                            else if (direction == "left")
                            {
                                direction = "back";
                            }
                            else if (direction == "right")
                            {
                                direction = "front";
                            }
                            else if (direction == "front")
                            {
                                direction = "left";
                            }
                        }

                    }

                    char color = cube[kukataPos[0], kukataPos[1], kukataPos[2]];
                    if (color == 'G')
                    {
                        Console.WriteLine("GREEN");
                    }
                    if (color == 'R')
                    {
                        Console.WriteLine("RED");
                    }
                    if (color == 'B')
                    {
                        Console.WriteLine("BLUE");
                    }

                    kukataPos[0] = 0;
                    kukataPos[1] = 1;
                    kukataPos[2] = 1;
                    direction = "back";
                }
                else
                {
                    Console.WriteLine(position);
                }
            }
        }


        static int IndexesCount(int[] pos, int[] dims)
        {
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                if (pos[i] == 0 || pos[i] == 2)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
