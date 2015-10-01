namespace RSStoHTML.Models
{
    using Newtonsoft.Json;

    public class Media
    {
        [JsonProperty("media:title")]
        public string Title { get; set; }

        [JsonProperty("media:content")]
        public YouTubeVideoContent Content { get; set; }

        [JsonProperty("media:thumbnail")]
        public Image Image { get; set; }

        [JsonProperty("media:description")]
        public string Description { get; set; }

        [JsonProperty("media:community")]
        public Community Community { get; set; }
    }
}
