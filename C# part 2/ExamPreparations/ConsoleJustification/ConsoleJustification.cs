using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJustification
{

    class ConsoleJustification
    {
        private static char[] separators = new char[] { ' ' };
        static int lineWidth;

        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            lineWidth = int.Parse(Console.ReadLine());
            string[] lines = new string[linesCount];
            for (int i = 0; i < linesCount; i++)
            {
                lines[i] = Console.ReadLine();
            }

            string[] array = GetWords(lines);
            MadeRows(array);
        }

        private static void MadeRows(string[] words)
        {
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < words.Length; i++)
            {
                queue.Enqueue(words[i]);
            }
            int currentRowLength = 0;
            int wordsCount = 0;
            string currentWord = String.Empty;
            List<string> current = new List<string>();
            int counter = 0;

            while (true)
            {

                if (!queue.Any())
                {
                    break;
                }
                currentWord = queue.Peek();
                currentRowLength += currentWord.Length + 1;
                wordsCount++;
                if (currentRowLength <= lineWidth + 1)
                {
                    current.Add(queue.Dequeue());
                    counter++;
                }
                if (currentRowLength > lineWidth + 1 || !queue.Any())
                {
                    int spaces = lineWidth - String.Join("", current).Trim().Length;
                    int i = 0;
                    while (spaces > 0)
                    {
                        if (current.Count > 1)
                        {
                            if (i == current.Count - 1)
                            {
                                i = 0;
                            }
                            if (i < current.Count - 1)
                            {
                                current[i] = current[i] + " ";
                                spaces--;
                            }
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine(String.Join("", current).Trim());
                    current.Clear();
                    currentRowLength = 0;
                }
            }
        }

        private static string[] GetWords(string[] lines)
        {
            List<string> words = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] currentWords = lines[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < currentWords.Length; j++)
                {
                    words.Add(currentWords[j]);
                }
            }
            return words.ToArray();
        }

    }
}
