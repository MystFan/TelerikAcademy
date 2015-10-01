namespace RSStoHTML.Models
{
    using Newtonsoft.Json;

    public class Image
    {
        [JsonProperty("@url")]
        public string Url { get; set; }

        [JsonProperty("@width")]
        public int Width { get; set; }

        [JsonProperty("@height")]
        public int Height { get; set; }
    }
}
