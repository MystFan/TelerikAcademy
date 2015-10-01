namespace RSStoHTML
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Xml;
    using System.Xml.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using Models;

    public class EntryPoint
    {
        public static void Main()
        {
            //    1.    The RSS feed is located at https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw
            //    2.    Download the content of the feed programatically
            //          *   You can use `WebClient.DownloadFile()`

            string url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string rssFilePath = "../../rss/rss.xml";

            WebClient client = new WebClient();
            client.DownloadFile(url, rssFilePath);

            // 3.Parse teh XML from the feed to JSON
            XmlDocument document = new XmlDocument();
            document.Load(rssFilePath);

            string jsonRss = JsonConvert.SerializeObject(document, Newtonsoft.Json.Formatting.Indented);

            //Console.WriteLine(jsonRss);
            //    4.    Using LINQ-to-JSON select all the video titles and print the on the console
            GetVideoTitles(jsonRss);
            var titles = GetVideoTitles(jsonRss);
            PrintVideoTitles(titles);

            //  5.    Parse the videos' JSON to POCO
            var jsonObj = JObject.Parse(jsonRss);
            var videos = jsonObj["feed"]["entry"].Select(entry => JsonConvert.DeserializeObject<YouTubeVideo>(entry.ToString()));

            // 6.    Using the POCOs create a HTML page that shows all videos from the RSS
            //      *   Use `<iframe>`
            //      *   Provide a links, that nagivate to their videos in YouTube 
            HTMLBuilder builder = new HTMLBuilder();
            string htmlFilePath = "../../html/youtubeChanel.html";
            builder.BuildYouTubeChanelPage(videos, htmlFilePath);
        }

        private static void PrintVideoTitles(IEnumerable titles)
        {
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }

        private static IEnumerable<JToken> GetVideoTitles(string jsonRss)
        {
            var jsonObj = JObject.Parse(jsonRss);
            var titles = jsonObj["feed"]["entry"].Select(e => e["title"]);
            return titles;
        }
    }
}
