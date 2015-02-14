using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParseTags
{
    public class TagParser
    {
        public static string ParseUppercase(string text)
        {
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            StringBuilder sb = new StringBuilder();
            string result = text;
            int openTagIndex = -1;
            int closeTagIndex = -1;
            while (true)
            {
                openTagIndex = text.IndexOf(openTag, openTagIndex + 1);
                closeTagIndex = text.IndexOf(closeTag, closeTagIndex + 1);
                if (openTagIndex < 0)
                {
                    break;
                }
                for (int i = openTagIndex + openTag.Length; i < closeTagIndex; i++)
                {
                    sb.Append(text[i]);
                }
                result = result.Replace(sb.ToString(), sb.ToString().ToUpper());
                sb.Clear();
            }
            return result;
        }
    }
}
