using System;
/*
 Problem 11. Random Numbers in Given Range

    -Write a program that enters 3 integers n, min and max (min = max) and prints n random numbers in the range [min...max].
 */
namespace _11.RandomNumbersInGivenRange
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            string inputN = Console.ReadLine();
            Console.WriteLine("Enter min != max");
            Console.Write("min = ");
            string inputMin = Console.ReadLine();
            Console.Write("max = ");
            string inputMax = Console.ReadLine();

            int n;
            int min;
            int max;

            bool isNumberN = int.TryParse(inputN, out n);
            bool isNumberMin = int.TryParse(inputMin, out min);
            bool isNumberMax = int.TryParse(inputMax, out max);

            if (isNumberN && isNumberMin && isNumberMax)
            {
                if (min < max)
                {
                    Random numberGinerator = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(numberGinerator.Next(min,max) + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Some input string was not in correct format");
            }
        }
    }
}
