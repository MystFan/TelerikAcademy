/*
 Problem 14. Quick sort

    Write a program that sorts an array of strings using the Quick sort algorithm.

 */
namespace _14.QuickSort
{
    using System;
    class QuickSort
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            string[] words = new string[length];

            Console.WriteLine("Enter integer values");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                words[i] = Console.ReadLine();
            }


            Quicksort(words, 0, words.Length - 1);


            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        public static void Quicksort(string[] elements, int left, int right)
        {
            int i = left;
            int j = right;
            string pivot = elements[(left + right) / 2];

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
                    string tmp = elements[i];
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
    }
}
