namespace _02.SequenceOfStrings
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string[] words = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            Dictionary<string, int> wordsCount = CountWords(words);
            List<string> oddOccurrencesWords = ExtraxtOddOccurrencesWords(wordsCount);
            PrintWords(oddOccurrencesWords);
        }

        private static void PrintWords(List<string> oddOccurrencesWords)
        {
            foreach (var word in oddOccurrencesWords)
            {
                Console.WriteLine(word);
            }
        }

        private static List<string> ExtraxtOddOccurrencesWords(Dictionary<string, int> wordsCount)
        {
            List<string> extractedWords = new List<string>();
            foreach (var word in wordsCount)
            {
                if (word.Value % 2 != 0)
                {
                    extractedWords.Add(word.Key);
                }
            }

            return extractedWords;
        }

        private static Dictionary<string, int> CountWords(string[] words)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!wordsCount.ContainsKey(words[i]))
                {
                    wordsCount[words[i]] = 0;
                }

                wordsCount[words[i]]++;
            }

            return wordsCount;
        }
    }
}
