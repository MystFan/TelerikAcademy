using System;
using System.Collections.Generic;
using System.Numerics;
namespace StrangeLandNumbers
{
    class StrangeLandNumbers
    {
        static readonly string[] arr = new string[7]
        { 
            "hT", "pNWE", "lPVKNQ", "mNTRAVL", "oBJEC", "bIN", "f"
        };
        static void Main()
        {
            string input = Console.ReadLine();
            BigInteger result = ConvertToDecimal(input);
            Console.WriteLine(result);
        }

        static BigInteger ConvertToDecimal(string strangeNumber)
        {
            List<string> list = new List<string>();
            List<int> list1 = new List<int>();
            string current = String.Empty;
            BigInteger sum = 0;

            for (int i = strangeNumber.Length - 1; i >= 0; i--)
            {
                switch (strangeNumber[i])
                {
                    case 'h': list.Add("hT"); break;
                    case 'p': list.Add("pNWE"); break;
                    case 'l': list.Add("lPVKNQ"); break;
                    case 'm': list.Add("mNTRAVL"); break;
                    case 'o': list.Add("oBJEC"); break;
                    case 'b': list.Add("bIN"); break;
                    case 'f': list.Add("f"); break;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i])
                {
                    case "pNWE": sum = sum + (7 * 5 * ((BigInteger)Math.Pow(7, i))); break;
                    case "hT": sum = sum + (7 * 6 * ((BigInteger)Math.Pow(7, i))); break;
                    case "lPVKNQ": sum = sum + (7 * 4 * ((BigInteger)Math.Pow(7, i))); break;
                    case "mNTRAVL": sum = sum + (7 * 3 * ((BigInteger)Math.Pow(7, i))); break;
                    case "oBJEC": sum = sum + (7 * 2 * ((BigInteger)Math.Pow(7, i))); break;
                    case "bIN": sum = sum + (7 * 1 * ((BigInteger)Math.Pow(7, i))); break;
                    case "f": sum = sum + (7 * 0 * ((BigInteger)Math.Pow(7, i))); break;

                }
            }
            return sum / 7;
        }
    }
}
