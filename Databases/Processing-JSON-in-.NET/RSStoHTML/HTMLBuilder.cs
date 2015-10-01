namespace RSStoHTML
{
    using RSStoHTML.Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class HTMLBuilder
    {
        public void BuildYouTubeChanelPage(IEnumerable<YouTubeVideo> videos, string path)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<!DOCTYPE html>\n<html>\n<head>\n<meta charset=\"utf-8\">\n<title>Telerik Academy Videos</title>\n<link rel=\"stylesheet\" href=\"styles/style.css/>\n</head>\n<body>");
            foreach (var video in videos)
            {
                sb.AppendLine("<h3>" + video.Title + "</h3>");
                sb.AppendLine("<div>");
                sb.AppendLine("<a href=\"" + video.Media.Content.Url + "\">" + video.Link.Href + "</a>");
                sb.AppendLine("</div>");
                sb.AppendLine("<div>");
                sb.AppendLine("<iframe width=\"560\" height=\"315\" src=\"" + video.Media.Content.Url + "\" frameborder=\"0\" allowfullscreen></iframe><br/>");
                sb.AppendLine("</div>");
            }

            sb.AppendLine("</body>\n</html>");
            string result = sb.ToString();
            this.SaveHtmlFile(result, path);
        }

        private void SaveHtmlFile(string content, string path)
        {
            File.WriteAllText(path, content);
        }
    }
}
