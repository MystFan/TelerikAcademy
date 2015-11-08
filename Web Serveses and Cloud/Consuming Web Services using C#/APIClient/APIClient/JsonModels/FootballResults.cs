
namespace APIClient.JsonModels
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class FootballResults
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("fixtures")]
        public IEnumerable<Fixture> Fixtures { get; set; }
    }
}
