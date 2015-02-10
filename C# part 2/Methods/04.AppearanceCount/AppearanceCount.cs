/*
 Problem 4. Appearance count

    Write a method that counts how many times given number appears in given array.
    Write a test program to check if the method is workings correctly.
 */
namespace _04.AppearanceCount
{
    using System;
    using System.Collections;
    public class AppearanceCount
    {
        static void Main()
        {
            Console.Write("Enter arrays length: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                string input = Console.ReadLine();
                int number;
                bool isNumber = int.TryParse(input, out number);
                if (isNumber)
                {
                    numbers[i] = number;
                }
            }
            Console.Write("Number: ");
            int num = int.Parse(Console.ReadLine());
            int count = Appearances(numbers, num);
            Console.WriteLine("Number {1} appearances:{0} times", count, num);
            /////////////////////////
            /////Check Tests project
            ////////////////////////
        }

        /// <summary>
        /// Method work with diffrent collections
        /// </summary>
        public static int Appearances<T>(T[] array, T element)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
