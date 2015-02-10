
namespace DrunkenNumbers
{
    using System;
    class DrunkenNumbers
    {
        static void Main()
        {
            int rounds = int.Parse(Console.ReadLine());

            long mitkoSum = 0;
            long vladkoSum = 0;
            for (int j = 0; j < rounds; j++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    input *= (-1);
                }
                string num = input.ToString().TrimStart('0');

                if (num.Length % 2 == 0)
                {
                    for (int i = 0; i < num.Length / 2; i++)
                    {
                        mitkoSum += int.Parse(num[i].ToString());
                    }
                    for (int i = num.Length / 2; i < num.Length; i++)
                    {
                        vladkoSum += int.Parse(num[i].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < num.Length / 2 + 1; i++)
                    {
                        mitkoSum += int.Parse(num[i].ToString());
                    }
                    for (int i = num.Length / 2; i < num.Length; i++)
                    {
                        vladkoSum += int.Parse(num[i].ToString());
                    }
                }
            }

            if (mitkoSum > vladkoSum)
            {
                Console.WriteLine("M {0}", mitkoSum - vladkoSum);
            }
            else if (vladkoSum > mitkoSum)
            {
                Console.WriteLine("V {0}", vladkoSum - mitkoSum);
            }
            else
            {
                Console.WriteLine("No {0}", mitkoSum + vladkoSum);
            }
        }
    }
}
