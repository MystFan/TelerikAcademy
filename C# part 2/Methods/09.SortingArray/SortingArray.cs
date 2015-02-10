
namespace _09.SortingArray
{
    using System;
    using System.Collections.Generic;
    class SortingArray
    {
        static void Main()
        {
            int[] nums = new int[] { 3, 4, 5, 8, 2, 3, 535, 3, 35, 3 };
            SortArray(nums);
            PrintArray(nums);
            SortArray(nums,Order.Dsc);
            PrintArray(nums);
        }

        private static int[] SortArray(int[] array, Order order = Order.Dsc)
        {
            List<int> list = new List<int>();
            int[] arr = (int[])array.Clone();
            
            if (order == 0)
            {
                for (int i = array.Length - 1; i >= 0 ; i--)
                {
                    int index = MaxElementAtIndex(array, 0,i);
                    if (index != i)
                    {
                        Swap(array, i, index);
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int index = MaxElementAtIndex(array, i,array.Length - 1);
                    Swap(array, i, index);
                }
            }
            return array;
        }

        private static int MaxElementAtIndex(int[] array, int startIndex, int endIndex)
        {
            int max = int.MinValue;
            int position = 0;
            int currentNumber = 0;
            for (int i = startIndex; i < endIndex + 1; i++)
            {
                currentNumber = array[i];
                if (currentNumber > max)
                {
                    max = currentNumber;
                    position = i;
                }
            }
            return position;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }

        private static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
