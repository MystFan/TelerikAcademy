/*
 Problem 13. Reverse sentence

    Write a program that reverses the words in given sentence.

Example:
                input 	                              output
C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!
 */
namespace _13.ReverseSentence
{
    using System;
    using System.Text;
    class ReverseSentence
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            Console.WriteLine(ReverseSentenceWords(sentence));
        }

        private static string ReverseSentenceWords(string text)
        {
            char[] splitCharacters = new char[] { ' '};
            StringBuilder sb = new StringBuilder();
            string[] words = text.Substring(0,text.Length - 1).Split(splitCharacters,StringSplitOptions.RemoveEmptyEntries);
            string word = String.Empty;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    sb.Append(words[i] + " ");
                }
                else
                {
                    sb.Append(words[i] + "!");
                }
            }
            return sb.ToString();
        }
    }
}
