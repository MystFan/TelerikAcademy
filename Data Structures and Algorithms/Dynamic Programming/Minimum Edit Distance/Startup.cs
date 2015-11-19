namespace Minimum_Edit_Distance
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static int[,] matrix;
        private static string firstWord;
        private static string secondWord;
        private static string firstWordOtherLetters;
        private static string secondWordOtherLetters;
        private static string result = string.Empty;

        public static void Main()
        {
            firstWord = "developer";
            secondWord = "enveloped";
            matrix = new int[firstWord.Length + 1, secondWord.Length + 1];
            int length = LCS(firstWord, secondWord);
            PrintLCS(matrix.GetLength(0) - 1, matrix.GetLength(1) - 1);

            int minLength = Math.Min(firstWord.Length, secondWord.Length);
            for (int i = 0; i < firstWord.Length; i++)
            {
                if (result.Contains(firstWord[i]))
                {
                    firstWordOtherLetters += "_";
                }
                else
                {
                    firstWordOtherLetters += firstWord[i];
                }
            }

            for (int i = 0; i < secondWord.Length; i++)
            {
                if (result.Contains(secondWord[i]))
                {
                    secondWordOtherLetters += "_";
                }
                else
                {
                    secondWordOtherLetters += secondWord[i];
                }
            }

            Console.WriteLine("Longest common sequence: {0}", result);
            Console.WriteLine(firstWordOtherLetters);
            Console.WriteLine(secondWordOtherLetters);

            double replaceCost = 1;
            double deleteCost = 0.9;
            double insertCost = 0.8;
            double minimumEditDistance = 0;
            int maxLen = Math.Max(firstWordOtherLetters.Length, secondWordOtherLetters.Length);
            int minLen = Math.Min(firstWordOtherLetters.Length, secondWordOtherLetters.Length);

            int firstWordIndex = 0;
            int secondWordIndex = 0;
            while (firstWordIndex < maxLen || secondWordIndex < maxLen)
            {
                if(firstWordIndex < minLen && secondWordIndex < minLen)
                {
                    if (firstWordOtherLetters[firstWordIndex] != '_' && secondWordOtherLetters[secondWordIndex] != '_')
                    {
                        minimumEditDistance += replaceCost;
                    }

                    if (firstWordOtherLetters[firstWordIndex] != '_' && secondWordOtherLetters[secondWordIndex] == '_')
                    {
                        minimumEditDistance += deleteCost;
                    }

                    if (firstWordOtherLetters[firstWordIndex] == '_' && secondWordOtherLetters[secondWordIndex] != '_')
                    {
                        minimumEditDistance += insertCost;
                    }
                }
                else if(firstWordIndex < firstWordOtherLetters.Length)
                {
                    minimumEditDistance += insertCost;
                }
                else if(secondWordIndex < secondWordOtherLetters.Length)
                {
                    minimumEditDistance += insertCost;
                }

                firstWordIndex++;
                secondWordIndex++;
            }

            Console.WriteLine("Minimum Edit Distance: {0}", minimumEditDistance);
        }

        static int LCS(string strOne, string strTwo)
        {
            int m = strOne.Length;
            int n = strTwo.Length;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (strOne[i - 1] == strTwo[j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        matrix[i, j] = Math.Max(matrix[i, j - 1], matrix[i - 1, j]);
                    }
                }
            }

            return matrix[m, n];
        }

        static void PrintLCS(int i, int j)
        {
            if (i == 0 || j == 0)
            {
                return;
            }

            if (firstWord[i - 1] == secondWord[j - 1])
            {
                PrintLCS(i - 1, j - 1);
                result += firstWord[i - 1];
            }
            else if (matrix[i, j] == matrix[i - 1, j])
            {
                PrintLCS(i - 1, j);
            }
            else
            {
                PrintLCS(i, j - 1);
            }
        }
    }
}
