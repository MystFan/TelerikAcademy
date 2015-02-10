/*
 Problem 7. Reverse number

    Write a method that reverses the digits of given decimal number.

 */
namespace _07.ReverseNumber
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;
    class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger revNumber = Reverse(number);
            Console.WriteLine(revNumber);
        }

        private static BigInteger Reverse(BigInteger numberByReverse)
        {
            BigInteger currentNumber = numberByReverse;
            StringBuilder sb = new StringBuilder();
            string currentString = String.Empty;
            List<string> list = new List<string>();
            while (currentNumber != 0)
            {
                currentString = (currentNumber % 10).ToString();
                currentNumber = currentNumber / 10;
                list.Add(currentString);
            }
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
            }
            BigInteger result = BigInteger.Parse(sb.ToString());
            return result;
        }
    }
}
