namespace CompareSortAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class CompareSortAlgorithms
    {
        static void Main()
        {
            Random rand = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                numbers.Add(rand.Next(1, 100000));
            }

            var numbersSelectionSort = new List<int>(numbers).ToArray();
            var numbersQuickSort = new List<int>(numbers).ToArray();
            var numbersInsertionSort = new List<int>(numbers).ToArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SelectionSort(numbersSelectionSort);
            Console.WriteLine("SelectionSort(): {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            Quicksort(numbersQuickSort, 0, numbersQuickSort.Length - 1);
            Console.WriteLine("Quicksort(): {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            InsertionSort(numbersInsertionSort);
            Console.WriteLine("InsertionSort(): {0}", sw.Elapsed);
        }

        public static void SelectionSort(int[] numbers)
        {
            int currentNumber = 0;
            int minNumber = int.MaxValue;
            int position = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    currentNumber = numbers[j];
                    if (currentNumber < minNumber)
                    {
                        minNumber = currentNumber;
                        position = j;
                    }
                }

                numbers[position] = numbers[i];
                numbers[i] = minNumber;
                minNumber = int.MaxValue;
            }
        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

        public static void InsertionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        int temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;

                    }

                    j--;
                }
            }
        }
    }
}
