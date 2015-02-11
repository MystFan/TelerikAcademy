/*
 Problem 2. Random numbers

    Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */
namespace _02.RandomNumbers
{
    using System;
    class RandomNumbers
    {
        static void Main()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", random.Next(100, 200));
            }
            Console.WriteLine();
        }
    }
}
