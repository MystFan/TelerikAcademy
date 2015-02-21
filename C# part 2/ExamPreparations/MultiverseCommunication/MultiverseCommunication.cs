using System;
using System.Collections.Generic;
using System.Numerics;

namespace MultiverseCommunication
{
    class MultiverseCommunication
    {
        static void Main()
        {
            string message = Console.ReadLine();
            string msg = DecryptMessage(message);
            string result = ConvertToDecimal(msg);
            Console.WriteLine(result);
        }

        private static string ConvertToDecimal(string msg)
        {
            string currentMessage = String.Empty;
            for (int i = msg.Length - 1; i >= 0; i--)
            {
                currentMessage += msg[i];
            }

            string result = String.Empty;
            BigInteger sum = 0;
            for (int i = 0; i < currentMessage.Length; i++)
            {
                int number = 0;
                if (currentMessage[i] == 'A')
                {
                    number = 10;
                }
                else if (currentMessage[i] == 'B')
                {
                    number = 11;
                }
                else if (currentMessage[i] == 'C')
                {
                    number = 12;
                }
                else
                {
                    number = int.Parse(currentMessage[i].ToString());
                }
                sum += (BigInteger)(number * (Math.Pow(13, i)));
            }
            return sum.ToString();
        }

        private static string DecryptMessage(string msg)
        {
            List<string> symbols = new List<string>() 
            {
                "CHU",
                "TEL",
                "OFT",
                "IVA",
                "EMY",
                "VNB",
                "POQ",
                "ERI",
                "CAD",
                "K-A",
                "IIA",
                "YLO",
                "PLA"
            };

            int index = 0;
            string currentSymbol = String.Empty;
            string result = String.Empty;
            while (index < msg.Length)
            {
                currentSymbol = msg.Substring(index, 3);
                for (int i = 0; i < symbols.Count; i++)
                {
                    if (symbols[i] == currentSymbol)
                    {
                        if (i == 10)
                        {
                            result += 'A';
                        }
                        else if (i == 11)
                        {
                            result += 'B';
                        }
                        else if (i == 12)
                        {
                            result += 'C';
                        }
                        else
                        {
                            result += i;
                        }
                    }
                }
                index += 3;
            }

            return result;
        }
    }
}
