namespace _03.SetOfWords
{
    using System;
    using System.Collections.ObjectModel;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            //http://codereview.stackexchange.com/questions/2195/is-this-a-reasonable-trie-implementation

            TrieNode trie = new TrieNode(StringComparer.CurrentCultureIgnoreCase);

            StreamReader reader = new StreamReader("../../text.txt");
            string text = string.Empty;
            using (reader)
            {
                text = reader.ReadToEnd();
            }

            string[] words = text.Split(new char[] { ' ', '.', '!', '?', ',', '\r', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            trie.AddRange(words);

            ReadOnlyCollection<string> matches = trie.FindMatches("le");
            foreach (var word in matches)
            {
                Console.WriteLine(word);
            }
        }
    }
}
