/*
 Problem 25. Extract text from HTML

    Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

Example input:

<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>

Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
 */
namespace _25.ExtractTextFromHTML
{
    using System;
    using System.Text;

    class ExtractTextFromHTML
    {
        static void Main(string[] args)
        {
            string html = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskilful .NET software engineers.</p></body></html>";
            Console.WriteLine("Title: {0}", ExtractTagContent(html, "<title>"));
            string bodyContent = ExtractTagContent(html, "<body>");
            Console.WriteLine("Text: {0}", ExtractContentWithoutTags(bodyContent));
        }

        private static string ExtractTagContent(string html, string tag)
        {
            int startTagLength = tag.Length;
            int closeTagLength = startTagLength + 1;
            string tagSubstring = tag.Substring(0, startTagLength - 1);
            string closeTag = "</" + tag.Substring(1, startTagLength - 1);
            int startIndex = html.IndexOf(tagSubstring);
            int endIndex = html.IndexOf(closeTag);
            StringBuilder sb = new StringBuilder();
            bool inTag = false;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (inTag)
                {
                    sb.Append(html[i]);
                }
                if (html[i] == '>')
                {
                    inTag = true;
                }
            }
            string content = sb.ToString();
            return content;
        }

        private static string ExtractContentWithoutTags(string html)
        {
            string content = String.Empty;
            StringBuilder sb = new StringBuilder();
            bool isOpenTag = false;

            for (int i = 0; i < html.Length - 1; i++)
            {
                if (isOpenTag && html[i] != '<' && html[i] != '>')
                {
                    sb.Append(html[i]);
                }
                if (html[i] == '>' && html[i + 1] != '<') 
                {
                    isOpenTag = true;
                }
                if (html[i] == '<' && isOpenTag)
                {
                    isOpenTag = false;
                    sb.Append(" ");
                }
            }

            content = sb.ToString();
            return content;
        }
    }
}
