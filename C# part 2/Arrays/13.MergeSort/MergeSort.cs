/*
 Problem 13.* Merge sort

    Write a program that sorts an array of integers using the Merge sort algorithm.

 */
namespace _13.MergeSort
{
    using System;
    class MergeSort
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

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
                else
                {
                    Console.WriteLine("Input string was not in a correct format");
                }
            }
            var result = Merge(numbers, 0, numbers.Length - 1);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("[{0}] = {1}", i, result[i]);
            }
        }


        public static int[] Merge(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Merge(input, left, middle);
                Merge(input, middle + 1, right);

                //Merge
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
            }
            return input;
        }
    }
}
