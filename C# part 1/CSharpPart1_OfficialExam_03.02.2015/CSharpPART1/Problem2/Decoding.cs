namespace Problem2
{
    using System;
    class Decoding
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            double currentSum = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    currentSum += salt + text[i] + 500;
                }
                else if (char.IsLetter(text[i]))
                {
                    currentSum = 1;
                    currentSum *= (text[i] * salt) + 1000;
                }
                else 
                {
                    currentSum = text[i] - salt;
                }

                if (i % 2 == 0)
                {
                    currentSum /= 100;
                    Console.WriteLine("{0:F2}", currentSum);
                }
                else
                {
                    currentSum *= 100;
                    Console.WriteLine(currentSum);
                }

                currentSum = 0;
            }
        }
    }
}
