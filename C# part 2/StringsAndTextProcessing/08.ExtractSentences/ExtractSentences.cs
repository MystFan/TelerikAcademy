/*
 Problem 8. Extract sentences

    Write a program that extracts from a given text all sentences containing given word.

Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
 */
namespace _08.ExtractSentences
{
    using System;
using System.Collections;
using System.Collections.Generic;
    class ExtractSentences
    {
        static void Main()
        {
            string example = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";
            string[] sentences = ExtractSent(example, word);
            Print(sentences);
        }

        private static string[] ExtractSent(string text,string word)
        {
            string[] currentSentences = text.Split('.');
            List<string> result = new List<string>();
            for (int i = 0; i < currentSentences.Length; i++)
            {
                string[] words = currentSentences[i].Split(' ');
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].Trim().Equals(word))
                    {
                        result.Add(currentSentences[i]);
                        break;
                    }
                }
            }
            return result.ToArray();
        }

        private static void Print(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
