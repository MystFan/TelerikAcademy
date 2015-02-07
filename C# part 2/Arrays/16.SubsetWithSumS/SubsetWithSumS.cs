/*
 Problem 16.* Subset with sum S

    We are given an array of integers and a number S.
    Write a program to find if there exists a subset of the elements of the array that has a sum S.

 */
namespace _16.SubsetWithSumS
{
    using System;
    class SubsetWithSumS
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter sum: ");
            int S = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];

            Console.WriteLine("Enter integer values");
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

            //Array.Sort(numbers);
            int currentSum = 0;
            bool exist = false;
            int numSum = S;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentSum = numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j)
                    {
                        if (currentSum + numbers[j] <= S)
                        {
                            currentSum += numbers[j];
                        }
                    }
                }
                if (currentSum == S)
                {
                    exist = true;
                    break;
                }
            }

            if (exist)
            {
                Console.WriteLine("-->Yes");
            }
            else
            {
                Console.WriteLine("-->No");
            }
        }
    }
}
