using System;
using System.Collections.Generic;
/* Problem 12.* Randomize the Numbers 1…N

    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
*/
namespace _12.RandomizeNumbers_1_N
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            string inputN = Console.ReadLine();

            int n;
            bool isNumberN = int.TryParse(inputN, out n);

            if (isNumberN)
            {
                Random random = new Random();
                List<int> randomNumbers = new List<int>();

                for (int i = 0; i < n; i++)
                {
                    int number;

                    do
                    {
                        number = random.Next(1, n + 1);
                    }
                    while (randomNumbers.Contains(number));

                    randomNumbers.Add(number);
                }
                for (int i = 0; i < randomNumbers.Count; i++)
                {
                    Console.Write(randomNumbers[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Input string was not in correct format");
            }
        }
    }
}
