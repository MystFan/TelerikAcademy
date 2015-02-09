/*
 Problem 5. Sort by string length

    You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

 */
namespace _05.SortByStringLength
{
    using System;
    class SortByStringLength
    {
        static void Main()
        {
            string[] array = new string[]
            {
                "Pesho",
                "Pesho Peshev",
                "Some text",
                "Regular text",
                "Nikolai Kostov",
                "Doncho Minkov",
                "Ivaylo Kenov",
                "Some long long long text"
            };

            SortByLength(array);
        }

        private static void SortByLength(string[] arr)
        {
            string[] str = (string[])arr.Clone();
            int maxLen = 0;
            int position = 0;
            for (int i = arr.Length - 1; i >= 0 ; i--)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    int len = str[j].Length;
                    if (len > maxLen)
                    {
                        maxLen = len;
                        position = j;
                    }
                }
                arr[i] = str[position];
                str[position] = String.Empty;
                maxLen = 0;
            }

        }
    }
}
