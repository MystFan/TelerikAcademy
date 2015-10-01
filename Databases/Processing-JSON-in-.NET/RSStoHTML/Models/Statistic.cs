namespace RSStoHTML.Models
{
    using Newtonsoft.Json;

    public class Statistic
    {
        [JsonProperty("@views")]
        public int Views { get; set; }
    }
}
