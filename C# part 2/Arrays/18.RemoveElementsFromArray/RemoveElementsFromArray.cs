/*
 Problem 18.* Remove elements from array

    Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
    Print the remaining sorted array.

 */

namespace _18.RemoveElementsFromArray
{
    using System;
    using System.Collections.Generic;
    class RemoveElementsFromArray
    {
        static void Main()
        {
            Console.Write("Enter array length = ");
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
            }

            var elements = RemoveElements(numbers);

            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i] + " ");
            }
        }

        private static int[] RemoveElements(int[] nums)
        {
            List<int> result = new List<int>();
            int beforeNumber = int.MinValue;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] <= nums[i + 1] && beforeNumber <= nums[i])
                {
                    result.Add(nums[i]);
                    beforeNumber = result[result.Count - 1];
                }
                else if (nums[i] > nums[i + 1] && beforeNumber <= nums[i])
                {
                    if (beforeNumber > nums[i + 1])
                    {
                        result.Add(nums[i]);
                        beforeNumber = result[result.Count - 1];
                    }
                }
            }
            return result.ToArray();
        }
    }
}
