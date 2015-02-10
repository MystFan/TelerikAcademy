
namespace Secrets
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    class Secrets
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            int position = 1;
            BigInteger currentNumber = number;
            BigInteger digit = 0;
            BigInteger specialSum = 0;
            if (currentNumber < 0)
            {
                currentNumber = currentNumber * (-1);
            }
            while (currentNumber > 0)
            {
                digit = currentNumber % 10;
                currentNumber /= 10;
                if (position % 2 != 0)
                {
                    specialSum += (digit * (position * position));
                }
                else
                {
                    specialSum += ((digit * digit) * position);
                }
                position++;
            }

            BigInteger seqLenth = specialSum % 10;
            if (seqLenth > 0)
            {
                BigInteger R = specialSum % 26;
                char firstLetterPosition = AlphabetLetter(R + 1);
                List<BigInteger> letterPositions = new List<BigInteger>();

                BigInteger currentLetterPosition = R + 1;
                while (seqLenth > 0)
                {
                    if (currentLetterPosition > 26)
                    {
                        currentLetterPosition = 1;
                    }
                    letterPositions.Add(currentLetterPosition);
                    currentLetterPosition++;
                    seqLenth--;
                }
                Console.WriteLine(specialSum);
                for (int i = 0; i < letterPositions.Count; i++)
                {
                    Console.Write(AlphabetLetter(letterPositions[i]));
                }
                Console.WriteLine();
            }
            else if (seqLenth == 0)
            {
                Console.WriteLine(specialSum);
                Console.WriteLine("{0} has no secret alpha-sequence", number);
            }
        }

        private static char AlphabetLetter(BigInteger pos)
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
