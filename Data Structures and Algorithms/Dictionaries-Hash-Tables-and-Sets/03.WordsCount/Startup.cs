namespace _03.WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            string text = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";
            string[] words = Regex.Replace(text, @"[^\w\s]", " ")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> countedWords = CountWords(words);
            IEnumerable<KeyValuePair<string, int>> result = countedWords.OrderBy(w => w.Value);
            PrintWords(result);
        }

        private static void PrintWords(IEnumerable<KeyValuePair<string, int>> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine("{0} --> {1}", word.Key, word.Value);
            }
        }

        private static Dictionary<string, int> CountWords(string[] words)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!wordsCount.ContainsKey(words[i].ToLower()))
                {
                    wordsCount[words[i].ToLower()] = 0;
                }

                wordsCount[words[i].ToLower()]++;
            }

            return wordsCount;
        }
    }
}
