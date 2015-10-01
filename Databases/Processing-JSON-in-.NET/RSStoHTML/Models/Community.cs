namespace RSStoHTML.Models
{
    using Newtonsoft.Json;

    public class Community
    {
        [JsonProperty("media:starRating")]
        public Rating Rating { get; set; }

        [JsonProperty("media:statistics")]
        public Statistic Statistic { get; set; }
    }

}
