namespace Problem3
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    class ConsoleApplication1
    {
        static void Main(string[] args)
        {
            List<BigInteger> numbers = new List<BigInteger>();
            while (true)
            {
                string num = Console.ReadLine();
                if (num == "END")
                {
                    break;
                }
                BigInteger number = BigInteger.Parse(num);
                numbers.Add(number);
            }
            BigInteger productDigits = 1;
            BigInteger resultDigitProduct = 1;
            BigInteger finalResult = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    string numberStr = numbers[i].ToString();
                    for (int j = 0; j < numberStr.Length; j++)
                    {
                        int digit = int.Parse(numberStr[j].ToString());
                        if (digit != 0)
                        {
                            productDigits *= digit;

                        }
                    }
                    if (i <= 9)
                    {
                        resultDigitProduct *= productDigits;
                    }
                    else
                    {
                        finalResult *= productDigits;
                    }
                    productDigits = 1;
                }
            }


            if (numbers.Count <= 10)
            {
                Console.WriteLine(resultDigitProduct);
            }
            else
            {
                Console.WriteLine(resultDigitProduct);
                Console.WriteLine(finalResult);
            }
        }
    }
}
