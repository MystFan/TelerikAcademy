/*Problem 9. Forbidden words

    We are given a string containing a list of forbidden words and a text containing some of these words.
    Write a program that replaces the forbidden words with asterisks.

Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */
namespace _09.ForbiddenWords
{
    using System;
    using System.Text;
    class ForbiddenWords
    {
        static void Main()
        {
            string words = "PHP, CLR, Microsoft";
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string result = ReplaceForbiddenWords(words, text);
            Console.WriteLine(result);
        }
        private static string ReplaceForbiddenWords(string words, string text)
        {
            string[] forbiddenWords = words.Split(',');
            string fixedText = text;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                string currentWord = forbiddenWords[i].Trim();
                if (!String.IsNullOrWhiteSpace(currentWord))
                {
                    int index = -1;
                    while (true)
                    {
                        index = fixedText.IndexOf(currentWord, index + 1);
                        if (index < 0)
                        {
                            break;
                        }
                        for (int j = 0; j < currentWord.Length; j++)
                        {
                            sb.Append('*');
                        }
                        fixedText = fixedText.Replace(currentWord, sb.ToString());
                        sb.Clear();
                    }
                }
            }
            return fixedText;
        }
    }
}
