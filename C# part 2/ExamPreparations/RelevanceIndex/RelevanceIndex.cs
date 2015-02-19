using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevanceIndex
{
    class Paragraph
    {
        public Paragraph(string[] arr, int index)
        {
            this.index = index;
            this.words = (string[])arr.Clone();
        }
        public string[] words { get; set; }
        public int index { get; set; }
    }
    class RelevanceIndex
    {
        private static char[] separators = new char[] { ',', '.', '(', ')', ';', '-', '!', '?', ' ' };
        private static string searchWord;
        static void Main(string[] args)
        {
            searchWord = Console.ReadLine();
            List<Paragraph> paragraphs = new List<Paragraph>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                Paragraph p = new Paragraph(words, 0);
                paragraphs.Add(p);
            }

            List<Paragraph> orderedWords = CountWords(paragraphs);
            List<Paragraph> result = WordsToUppercase(orderedWords);
            PrintResult(result);
        }

        private static void PrintResult(List<Paragraph> collection)
        {
            foreach (var item in collection)
            {
                for (int i = 0; i < item.words.Length; i++)
                {
                    Console.Write(item.words[i] + " ");
                }
                Console.WriteLine();
            }
        }

        private static List<Paragraph> CountWords(List<Paragraph> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int count = list[i].words.Where(w => w.ToLower() == searchWord.ToLower()).Count();
                list[i].index = count;
            }
            List<Paragraph> result = list.OrderByDescending(item => item.index).ToList();
            return result;
        }

        private static List<Paragraph> WordsToUppercase(List<Paragraph> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].words.Length; j++)
                {
                    if (list[i].words[j].ToLower() == searchWord.ToLower())
                    {
                        list[i].words[j] = list[i].words[j].ToUpper();
                    }
                }
            }
            return list;
        }
    }
}
