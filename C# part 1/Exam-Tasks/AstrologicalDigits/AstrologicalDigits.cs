
namespace AstrologicalDigits
{
    using System;
    using System.Numerics;
    class AstrologicalDigits
    {
        static void Main()
        {
            string input = Console.ReadLine().Replace(".", "").Replace("-", "");
            BigInteger N = BigInteger.Parse(input);
            int sum = 0;
            while (true)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        sum += int.Parse(input[i].ToString());
                    }
                }
                if (sum > 9)
                {
                    input = sum.ToString();
                }
                else
                {
                    input = sum.ToString();
                    break;
                }
                sum = 0;
            }
            Console.WriteLine(input);
        }
    }
}
