/*
 Problem 23. Series of letters

    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

Example:
input 	                    output
aaaaabbbbbcdddeeeedssaa 	abcdedsa
 */
namespace _23.SeriesOfLetters
{
    using System;
    class SeriesOfLetters
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            Console.WriteLine(ReplaceSeriesOfLetters(text));
        }

        private static string ReplaceSeriesOfLetters(string input)
        {
            char currentLetter = input[0];
            int counter = 1;
            int currentIndex = 0;
            string result = input;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentLetter)
                {
                    counter++;
                }
                else
                {
                    string repeatLetters = input.Substring(currentIndex, counter);
                    result = result.Replace(repeatLetters, currentLetter.ToString());
                    currentLetter = input[i];
                    currentIndex = i;
                    counter = 1;
                }

            }

            if (input[input.Length - 2] == input[input.Length - 1])
            {
                result = result.Remove(result.Length - 1, 1);
            }

            return result;
        }
    }
}
