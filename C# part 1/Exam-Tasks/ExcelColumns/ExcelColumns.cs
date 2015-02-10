
namespace ExcelColumns
{
    using System;

    class ExcelColumns
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string identifier = String.Empty;
            for (int i = 0; i < n; i++)
            {
                identifier += Console.ReadLine();
            }

            string reverseIdentifier = String.Empty;
            for (int i = identifier.Length - 1; i >= 0; i--)
            {
                reverseIdentifier += identifier[i];
            }

            double sum = 0;
            for (int i = 0; i < reverseIdentifier.Length; i++)
            {
                int position = AlphabetPosition(reverseIdentifier[i]);
                sum += position * Math.Pow(26, i);
            }
            Console.WriteLine(sum);
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
    }
}
