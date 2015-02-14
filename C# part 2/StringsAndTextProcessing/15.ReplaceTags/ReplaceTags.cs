/*
 Problem 15. Replace tags

    Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

Example:
   input 	
  <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p> 
 * output
 * <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */
namespace _15.ReplaceTags
{
    using System;
    using System.Text;
    class ReplaceTags
    {
        static int StartIndex = -1;
        static int EndIndex = -1;
        static string newHTML = String.Empty;
        static void Main()
        {
            string htmlText = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p> ";

            while (true)
            {
                if (EndIndex < htmlText.Length)
                {
                    StartIndex = htmlText.IndexOf("<a", StartIndex + 1);
                    EndIndex = htmlText.IndexOf("a>", EndIndex + 1);
                    if ((StartIndex < 0) && (EndIndex < 0))
                    {
                        break;
                    }
                    string anchor = ExtractAnchor(htmlText, StartIndex, EndIndex);
                    newHTML = htmlText.Replace(anchor, URLTagBuilder(ExtractURL(anchor), ExtractAnchorContent(anchor)));
                    htmlText = newHTML;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(htmlText);
        }

        private static string ExtractAnchor(string htmlText, int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < htmlText.Length; i++)
            {
                if ((i >= start) && (i <= end + 1))
                {
                    sb.Append(htmlText[i]);
                }
            }
            string anchor = htmlText.Substring(start, sb.ToString().Length);
            return anchor;
        }

        private static string ExtractURL(string anchor)
        {
            StringBuilder sb = new StringBuilder();
            int startIndex = anchor.IndexOf("=\"");
            for (int i = 0; i < anchor.Length; i++)
            {
                if (i >= startIndex + 2)
                {
                    if (anchor[i] == '"')
                    {
                        break;
                    }
                    sb.Append(anchor[i]);
                }
            }
            return sb.ToString();
        }

        private static string URLTagBuilder(string http, string content)
        {
            string pattern = "[URL=....]...[/URL]";
            string urlTag = pattern.Replace("....", http);
            string urlfinal = urlTag.Replace("...", content);
            urlTag = String.Empty;
            return urlfinal;
        }

        private static string ExtractAnchorContent(string tag)
        {
            StringBuilder sb = new StringBuilder();
            int startContent = tag.IndexOf(">");
            for (int i = 0; i < tag.Length; i++)
            {
                if ((i > startContent))
                {
                    if (tag[i] == '<')
                    {
                        break;
                    }
                    sb.Append(tag[i]);
                }
            }
            return sb.ToString();
        }
    }
}
