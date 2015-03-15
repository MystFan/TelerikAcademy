/*Problem 1. StringBuilder.Substring

    Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
*/

namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;
    class StringBuilderSubstring
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append("Some text ");
            }
            string str = sb.SubString(1, 7);
            Console.WriteLine(str);
        }
    }

    public static class Extensions
    {
        public static string SubString(this StringBuilder sb, int index, int length)
        {
            string result = string.Empty;
            StringBuilder builder = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                builder.Append(sb[i]);
            }
            return builder.ToString();
        }
    }
}
