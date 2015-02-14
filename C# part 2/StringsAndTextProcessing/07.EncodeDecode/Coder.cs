using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EncodeDecode
{
    public class Coder
    {
        private const string KEY = "pass";
        public string Encode(string text)
        {
            string encryptText = String.Empty;
            StringBuilder sb = new StringBuilder();
            bool isEncrypt = false;
            int indexText = 0;
            while (true)
            {
                for (int i = 0; i < KEY.Length; i++)
                {
                    if (indexText > text.Length - 1)
                    {
                        isEncrypt = true;
                        break;
                    }
                    encryptText +=(char)((KEY[i] ^ text[indexText]));
                    indexText++;
                }
                if (isEncrypt)
                {
                    break;
                }
            }
            return encryptText;
        }

        public string Decode(string text)
        {
            string decodeText = String.Empty;
            StringBuilder sb = new StringBuilder();
            bool isDecrypt = false;
            int indexText = 0;
            while (true)
            {
                for (int i = 0; i < KEY.Length; i++)
                {
                    if (indexText > text.Length - 1)
                    {
                        isDecrypt = true;
                        break;
                    }
                    decodeText += ((char)(KEY[i] ^ text[indexText]));
                    indexText++;
                }
                if (isDecrypt)
                {
                    break;
                }
            }
            return decodeText;
        }
    }
}
