namespace Problem4
{
    using System;
    class PersianRugs
    {
        static void Main(string[] args)
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

                int middleDot = 1;
                for (int i = N - 1; i >= 0; i--)
                {
                    int middle = width - ((2 * i) + 2);
                    smallTriangleWidth = width - (((2 * i) + 2) + (2 * currentDistance));
                    Console.Write(new string('#',i));
                    Console.Write('/');
                    if (smallTriangleWidth <= 1)
                    {
                        Console.Write(new string(' ', middle));
                    }
                    else
                    {
                        Console.Write(new string(' ', currentDistance));
                        Console.Write('/');
                        Console.Write(new string('.',middleDot));
                        Console.Write('\\');
                        Console.Write(new string(' ', currentDistance));

                        middleDot+=2;
                    }
                    Console.Write('\\');
                    Console.WriteLine(new string('#', i));
                }
            }
            else
            {
                int middle = width - 2;
                for (int i = 0; i < N; i++)
                {
                    Console.Write(new string('#',i));
                    Console.Write('\\');
                    Console.Write(new string(' ', middle - (2 * i) ));
                    Console.Write('/');
                    Console.WriteLine(new string('#', i));
                }
                Console.Write(new string('#', N));
                Console.Write('X');
                Console.WriteLine(new string('#', N));
                int mid = 1;
                for (int i = N - 1; i >= 0; i--)
                {
                    Console.Write(new string('#',i));
                    Console.Write('/');
                    Console.Write(new string(' ',mid));
                    Console.Write('\\');
                    Console.WriteLine(new string('#',i));
                    mid += 2;
                }
            }
        }
    }
}
