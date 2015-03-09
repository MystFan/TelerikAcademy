using System;
using System.Collections.Generic;
using System.IO;
/*
 Problem 8. Replace whole word

    Modify the solution of the previous problem to replace only whole words (not strings).
 */
namespace _08.ReplaceWholeWord
{
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class ReplaceWholeWord
    {
        static void Main()
        {
            string path = @"..\..\task8.txt";
            string oldWord = "FER";
            string newWord = "PER";
            ReplaceWords(oldWord, newWord, path);
        }

        private static void ReplaceWords(string oldWord, string newWord, string path)
        {
            List<string> list = new List<string>();
            string[] symbols = new string[] { ".", ",", "(", ")", "!", "?", " " };

            StreamReader reader = new StreamReader(path);

            string line = String.Empty;
            using (reader)
            {
                line = reader.ReadLine();
                while (line != null)
                {
                    foreach (var item in line.Split(symbols, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (item == oldWord)
                        {
                            line = line.Replace(item, newWord);
                        }
                    }
                    list.Add(line);
                    line = reader.ReadLine();
                }
            }

            StreamWriter writer = new StreamWriter(path);
            using (writer)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    line = list[i];
                    writer.WriteLine(line);
                }
            }
        }
    }
}
