namespace RSStoHTML.Models
{
    using Newtonsoft.Json;

    public class YouTubeVideoContent
    {
        [JsonProperty("@url")]
        public string Url { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("@width")]
        public int Width { get; set; }

        [JsonProperty("@height")]
        public int Height { get; set; }
    }
}
