namespace CSharpExamProblem3
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Problem3
    {
        public static void Main()
        {
            List<BigInteger> numbers = new List<BigInteger>();
            while (true)
            {
                string inputNumber = Console.ReadLine();
                if (inputNumber == "END")
                {
                    break;
                }

                BigInteger number = BigInteger.Parse(inputNumber);
                numbers.Add(number);
            }

            BigInteger currentProductOfDigits = 1;
            BigInteger productOfDigits = 1;
            BigInteger finalProductOfDigits = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    string numberAsString = numbers[i].ToString();
                    for (int j = 0; j < numberAsString.Length; j++)
                    {
                        int digit = int.Parse(numberAsString[j].ToString());
                        if (digit != 0)
                        {
                            currentProductOfDigits *= digit;
                        }
                    }

                    if (i <= 9)
                    {
                        productOfDigits *= currentProductOfDigits;
                    }
                    else
                    {
                        finalProductOfDigits *= currentProductOfDigits;
                    }

                    currentProductOfDigits = 1;
                }
            }

            if (numbers.Count <= 10)
            {
                Console.WriteLine(productOfDigits);
            }
            else
            {
                Console.WriteLine(productOfDigits);
                Console.WriteLine(finalProductOfDigits);
            }
        }
    }
}
