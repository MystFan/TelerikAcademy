namespace RSStoHTML.Models
{
    using Newtonsoft.Json;

    public class YouTubeVideo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("yt:videoId")]
        public string VideoId { get; set; }

        [JsonProperty("yt:channelId")]
        public string ChannelId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("media:group")]
        public Media Media { get; set; }
    }
}
