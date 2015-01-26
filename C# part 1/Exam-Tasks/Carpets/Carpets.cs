namespace Carpets
{
    using System;
    class Carpets
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char blank = '.';
            char left = '/';
            char right = '\\';
            char space = ' ';

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new String(blank, ((n / 2) - 1) - i));
                Console.Write(left);
                if (i != 0)
                {
                    for (int k = 0; k < i; k++)
                    {
                        if (k % 2 == 0)
                        {
                            Console.Write(space);
                        }
                        else
                        {
                            Console.Write(left);
                        }
                    }
                    if (i % 2 == 0)
                    {
                        for (int k = 0; k < i; k++)
                        {
                            if (k % 2 == 0)
                            {
                                Console.Write(right);
                            }
                            else
                            {
                                Console.Write(space);
                            }
                        }
                    }
                    else
                    {
                        for (int k = 0; k < i; k++)
                        {
                            if (k % 2 == 0)
                            {
                                Console.Write(space);
                            }
                            else
                            {
                                Console.Write(right);
                            }
                        }
                    }
                }
                Console.Write(right);
                Console.WriteLine(new String(blank, ((n / 2) - 1) - i));
            }

            for (int i = n / 2; i > 0; i--)
            {
                Console.Write(new String(blank, (n / 2) - i));
                Console.Write(right);
                if (i != 0)
                {
                    for (int k = 0; k < i - 1; k++)
                    {
                        if (k % 2 == 0)
                        {
                            Console.Write(space);
                        }
                        else
                        {
                            Console.Write(right);
                        }
                    }
                    if (i % 2 == 0)
                    {
                        for (int k = 0; k < i - 1; k++)
                        {
                            if (k % 2 == 0)
                            {
                                Console.Write(space);
                            }
                            else
                            {
                                Console.Write(left);
                            }
                        }
                    }
                    else
                    {
                        for (int k = 0; k < i - 1; k++)
                        {
                            if (k % 2 == 0)
                            {
                                Console.Write(left);
                            }
                            else
                            {
                                Console.Write(space);
                            }
                        }
                    }
                }
                Console.Write(left);
                Console.WriteLine(new String(blank, (n / 2) - i));
            }
        }
    }
}
