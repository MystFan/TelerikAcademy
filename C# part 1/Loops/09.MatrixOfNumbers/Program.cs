using System;
/*
 Problem 9. Matrix of Numbers

    -Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
 */
namespace _09.MatrixOfNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number between 1 and 20 (1 = n = 20)");
            Console.Write("n = ");
            string input = Console.ReadLine();

            int n;
            bool isNumber = int.TryParse(input, out n);
            bool inRange = n >= 1 && n <= 20;
            if (isNumber)
            {
                if (inRange)
                {
                    for (int row = 1; row <= n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            int number = col + row;
                            if (number < 10)
                            {
                                Console.Write(number + "  ");
                            }
                            else
                            {
                                Console.Write((col + row) + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("N is outside the permitted values");
                }
            }
            else
            {
                Console.WriteLine("Input string was not in correct format");
            }
        }
    }
}
