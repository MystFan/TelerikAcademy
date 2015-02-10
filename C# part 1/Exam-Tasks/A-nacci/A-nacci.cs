
namespace A_nacci
{
    using System;
    using System.Collections.Generic;
    class A_nacci
    {
        static void Main()
        {
            string firstElement = Console.ReadLine();
            string secondElement = Console.ReadLine();
            int linesCount = int.Parse(Console.ReadLine());

            if (linesCount > 2)
            {
                int seqCount = (linesCount * 2) - 1;
                List<int> items = new List<int>();

                int sumFirstTwoMembers = AlphabetPosition(firstElement[0]) + AlphabetPosition(secondElement[0]);
                items.Add(AlphabetPosition(firstElement[0]));
                items.Add(AlphabetPosition(secondElement[0]));

                if (sumFirstTwoMembers > 26)
                {
                    sumFirstTwoMembers = sumFirstTwoMembers % 26;
                    items.Add(sumFirstTwoMembers);
                }
                else
                {
                    items.Add(sumFirstTwoMembers);
                }

                for (int i = 0; i < seqCount - 3; i++)
                {
                    sumFirstTwoMembers = items[items.Count - 1] + items[items.Count - 2];
                    if (sumFirstTwoMembers > 26)
                    {
                        sumFirstTwoMembers = sumFirstTwoMembers % 26;
                    }
                    items.Add(sumFirstTwoMembers);
                }

                List<string> characters = new List<string>();
                for (int i = 0; i < items.Count; i++)
                {
                    string letter = AlphabetLetter(items[i]).ToString().ToUpper();
                    characters.Add(letter);
                }

                Console.WriteLine(characters[0]);
                Console.WriteLine(characters[1] + characters[2]);
                char space = ' ';
                for (int i = 3; i < characters.Count - 1; i += 2)
                {
                    Console.WriteLine(characters[i] + new String(space, i / 2) + characters[i + 1]);
                }
            }
            if (linesCount == 1)
            {
                Console.WriteLine(firstElement);
            }
            if (linesCount == 2)
            {
                Console.WriteLine(firstElement);
                Console.WriteLine(secondElement);
            }
        }

        private static int AlphabetPosition(char c)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int position = 1;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (c.ToString().ToLower() == alphabet[i].ToString().ToLower())
                {
                    position = i + 1;
                    break;
                }
            }
            return position;
        }

        private static char AlphabetLetter(int pos)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char result = ' ';
            if (pos > 0 && pos <= 26)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (i + 1 == pos)
                    {
                        result = alphabet[i];
                        break;
                    }
                }
            }
            return result;
        }
    }
}
