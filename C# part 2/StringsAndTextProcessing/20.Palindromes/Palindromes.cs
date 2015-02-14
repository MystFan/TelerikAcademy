using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string text = "ABBA lamal exe,exe ABBA. ala example";
            var palindromes = ExtractPalindromes(text);
            PrintPalindromes(palindromes);
        }

        private static string[] ExtractPalindromes(string text)
        {
            char[] separators = new char[] { ' ', ',', '.' };
            List<string> palindromes = new List<string>();

            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                string reverse = String.Empty;
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    reverse += words[i][j];
                }
                if (words[i] == reverse)
                {
                    palindromes.Add(words[i]);
                }
            }
            return palindromes.ToArray();
        }

        private static void PrintPalindromes(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
