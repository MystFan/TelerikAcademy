using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeAndEncrypt
{
    class EncodeAndEncrypt
    {
        static void Main()
        {
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();
            string encryptedMessage = Encrypt(message, cypher);
            string result = Encode(encryptedMessage + cypher);
            Console.WriteLine(result + cypher.Length);
        }

        private static string Encode(string str)
        {
            int counter = 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > 2)
                    {
                        sb.Append(counter.ToString() + str[i]);
                    }
                    else if (counter == 2)
                    {
                        sb.Append(str[i].ToString() + str[i]);
                    }
                    else
                    {
                        sb.Append(str[i]);
                    }
                    counter = 1;
                }
            }


            if (counter == 2)
            {
                sb.Append(str[str.Length - 1].ToString() + str[str.Length - 1]);
            }
            else if (counter == 1)
            {
                sb.Append(str[str.Length - 1].ToString());
            }
            else if (counter == 3)
            {
                sb.Append(counter + str[str.Length - 1].ToString());
            }

            return sb.ToString();

        }

        private static string Encrypt(string message, string cypher)
        {
            StringBuilder sb = new StringBuilder();
            if (cypher.Length <= message.Length)
            {
                int messageIndex = 0;
                int cypherIndex = 0;
                while (messageIndex < message.Length)
                {
                    if (cypherIndex == cypher.Length)
                    {
                        cypherIndex = 0;
                    }
                    int symbol = (LetterAtPosition(message[messageIndex]) ^ LetterAtPosition(cypher[cypherIndex])) + 65;
                    sb.Append((char)symbol);
                    messageIndex++;
                    cypherIndex++;
                }
            }
            else if (cypher.Length > message.Length)
            {
                int len = cypher.Length - message.Length;
                string cypherPartTwo = cypher.Substring(message.Length, len);
                int messageIndex = 0;
                int cypherIndex = 0;
                int cypherPartIndex = 0;
                while (messageIndex < message.Length)
                {
                    int symbol = 0;
                    if (cypherPartIndex < len)
                    {
                        symbol = (LetterAtPosition(message[messageIndex]) ^ LetterAtPosition(cypher[cypherIndex])) ^ LetterAtPosition(cypherPartTwo[cypherPartIndex]);
                    }
                    else
                    {
                        symbol = (LetterAtPosition(message[messageIndex]) ^ LetterAtPosition(cypher[cypherIndex]));
                    }
                    sb.Append(LetterPosition(symbol));
                    messageIndex++;
                    cypherIndex++;
                    cypherPartIndex++;
                }
            }

            return sb.ToString();
        }

        static int LetterAtPosition(char letter)
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int pos = Array.FindIndex<char>(alphabet, c => c.ToString() == letter.ToString());
            return pos;
        }


        static char LetterPosition(int position)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (position < 0)
            {
                position *= (-1);
            }
            if (position > alphabet.Length - 1)
            {
                return (char)position;
            }
            return alphabet[position];
        }
    }
}
