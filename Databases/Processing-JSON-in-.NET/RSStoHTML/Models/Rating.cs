namespace RSStoHTML.Models
{
    using Newtonsoft.Json;

    public class Rating
    {
        [JsonProperty("@count")]
        public int Count { get; set; }

        [JsonProperty("@average")]
        public double Average { get; set; }

        [JsonProperty("@min")]
        public int Min { get; set; }

        [JsonProperty("@max")]
        public int Max { get; set; }
    }
}
