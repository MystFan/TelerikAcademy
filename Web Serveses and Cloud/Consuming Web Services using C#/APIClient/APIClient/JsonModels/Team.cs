namespace APIClient.JsonModels
{
    using Newtonsoft.Json;

    public class Team
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}