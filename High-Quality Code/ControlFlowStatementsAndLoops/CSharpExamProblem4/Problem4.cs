namespace CSharpExamProblem4
{
    using System;

    public class Problem4
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());

            int currentDistance = distance;
            int width = (2 * N) + 1;
            int height = (2 * N) + 1;
            int smallTriangleWidth = width - (2 + (2 * distance));
            if (smallTriangleWidth > 0)
            {
                for (int i = 0; i < N; i++)
                {
                    smallTriangleWidth = width - (((2 * i) + 2) + (2 * distance));
                    Console.Write(new string('#', i));
                    Console.Write("\\");
                    Console.Write(new string(' ', distance));
                    if (smallTriangleWidth < 0)
                    {
                        distance--;
                    }

                    if (smallTriangleWidth > 1)
                    {
                        Console.Write('\\');
                        Console.Write(new string('.', smallTriangleWidth - 2));
                        Console.Write('/');
                    }
                    else if (smallTriangleWidth == 1)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(new string(' ', distance));
                    Console.Write("/");
                    Console.WriteLine(new string('#', i));
                }

                Console.Write(new string('#', N));
                Console.Write('X');
                Console.WriteLine(new string('#', N));

                int middleDotsLength = 1;
                for (int i = N - 1; i >= 0; i--)
                {
                    int middle = width - ((2 * i) + 2);
                    smallTriangleWidth = width - (((2 * i) + 2) + (2 * currentDistance));
                    Console.Write(new string('#', i));
                    Console.Write('/');
                    if (smallTriangleWidth <= 1)
                    {
                        Console.Write(new string(' ', middle));
                    }
                    else
                    {
                        Console.Write(new string(' ', currentDistance));
                        Console.Write('/');
                        Console.Write(new string('.', middleDotsLength));
                        Console.Write('\\');
                        Console.Write(new string(' ', currentDistance));
                        middleDotsLength += 2;
                    }

                    Console.Write('\\');
                    Console.WriteLine(new string('#', i));
                }
            }
            else
            {
                int middleSpacesWidth = width - 2;
                for (int i = 0; i < N; i++)
                {
                    Console.Write(new string('#', i));
                    Console.Write('\\');
                    Console.Write(new string(' ', middleSpacesWidth - (2 * i)));
                    Console.Write('/');
                    Console.WriteLine(new string('#', i));
                }

                Console.Write(new string('#', N));
                Console.Write('X');
                Console.WriteLine(new string('#', N));

                middleSpacesWidth = 1;
                for (int i = N - 1; i >= 0; i--)
                {
                    Console.Write(new string('#', i));
                    Console.Write('/');
                    Console.Write(new string(' ', middleSpacesWidth));
                    Console.Write('\\');
                    Console.WriteLine(new string('#', i));
                    middleSpacesWidth += 2;
                }
            }
        }
    }
}
