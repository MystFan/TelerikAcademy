/*
 Problem 4. Sub-string in text

    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
 */
namespace _04.SubStringInText
{
    using System;
    class SubStringInText
    {
        static void Main()
        {
            string example = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";
            int result = SubstringCount(example, word);
            Console.WriteLine("{0} times", result);
        }

        private static int SubstringCount(string text, string str, bool caseInsensitive = true)
        {
            string inputText = text;
            string subString = str;
            int count = 0;
            int index = -1;
            while (true)
            {
                if (caseInsensitive)
                {
                    index = inputText.IndexOf(subString, index + 1, StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    index = inputText.IndexOf(subString, index + 1);
                }
                if (index < 0)
                {
                    break;
                }
                count++;
            }
            return count;
        }
    }
}
