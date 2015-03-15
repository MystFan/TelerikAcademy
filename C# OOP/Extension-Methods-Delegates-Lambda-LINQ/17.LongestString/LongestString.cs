/*Problem 17. Longest string

    Write a program to return the string with maximum length from an array of strings.
    Use LINQ.
*/

namespace _17.LongestString
{
    using System;
    using System.Linq;
    class LongestString
    {
        static void Main()
        {
            string[] strings = new string[]
            {
                "Write a program",
                "string with maximum length",
                "some string",
                "another string"
            };

            string longestString = strings.FirstOrDefault(str => str.Length == strings.Max(s => s.Length));
            Console.WriteLine(longestString);
        }
    }
}
