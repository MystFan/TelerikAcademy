namespace EnigmaCat
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class EnigmaCat
    {
        private const string EnglishAlphabet = "abcdefghijklmnopqrstuvwxyz";

        private static void Main()
        {
            string input = Console.ReadLine();
            string[] words = ReadInputWords(input);

            List<string> results = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                BigInteger number = ConvertToDecimalNumeralSystem(words[i]);
                string result = ConvertDecimalToSeventeenNumeralSystem(number);
                results.Add(result);
            }

            PrintReultOnConsole(results);
        }

        private static void PrintReultOnConsole(List<string> results)
        {
            string output = string.Join(string.Empty, results);
            Console.WriteLine(output);
        }

        private static string[] ReadInputWords(string input)
        {
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        private static string ConvertDecimalToSeventeenNumeralSystem(BigInteger number)
        {
            StringBuilder sb = new StringBuilder();

            while (number != 0)
            {
                BigInteger num = number % 26;
                char ch = GetCharAlphabetcPosition((int)num);
                sb.Append(ch.ToString().ToLower());
                number = number / 26;
            }

            string result = string.Join(string.Empty, sb.ToString().ToCharArray().Reverse());
            return result;
        }

        private static char GetCharAlphabetcPosition(int num)
        {
            char[] alphabet = EnglishAlphabet.ToCharArray();
            char ch = alphabet[num];
            return ch;
        }

        private static BigInteger ConvertToDecimalNumeralSystem(string word)
        {
            BigInteger sum = 0;
            string reversedWord = string.Join(string.Empty, word.ToCharArray().Reverse());
            for (int i = 0; i < reversedWord.Length; i++)
            {
                if (char.IsDigit(reversedWord[i]))
                {
                    sum += int.Parse(reversedWord[i].ToString()) * Pow(17, i);
                }
                else
                {
                    sum += GetCharAlphabetPosition(reversedWord[i]) * Pow(17, i);
                }
            }

            return sum;
        }

        private static BigInteger Pow(int number, int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

        private static int GetCharAlphabetPosition(char ch)
        {
            char[] alphabet = EnglishAlphabet.ToCharArray();
            int position = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i].ToString() == ch.ToString().ToLower())
                {
                    position = i;
                    break;
                }
            }

            return position;
        }
    }
}
