namespace APIClient
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using APIClient.JsonModels;
    using Newtonsoft.Json;

    public class FootballApiClient
    {
        private const string BaseApiUri = "http://api.football-data.org";
        private const string ApiAuthenticationToken = "8b99d7e7662d4f29b7598279d6a8fe78";
        private const string ApiAuthenticationHeaderName = "X-Auth-Token";

        private readonly HttpClient httpClient;

        public FootballApiClient()
        {
            this.httpClient = new HttpClient();
        }

        public FootballResults GetTeamResult(int teamId)
        {
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add(ApiAuthenticationHeaderName, ApiAuthenticationToken);
            Task<string> requestFootballTeam = GetResponseString(BaseApiUri + "//alpha/teams/" + teamId + "/fixtures/");
            var teamResultsAsJson = requestFootballTeam.Result;
            var results = JsonConvert.DeserializeObject<FootballResults>(teamResultsAsJson);

            return results;
        }

        public TeamsModel GetTeamAllTeamsNames(int leagueId)
        {
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add(ApiAuthenticationHeaderName, ApiAuthenticationToken);
            Task<string> requestFootballTeam = GetResponseString(BaseApiUri + "/alpha/soccerseasons/"+ leagueId + "/teams");
            var teamAsJson = requestFootballTeam.Result;
            var teams = JsonConvert.DeserializeObject<TeamsModel>(teamAsJson);

            return teams;
        }

        private async Task<string> GetResponseString(string uri)
        {
            var response = await this.httpClient.GetAsync(new Uri(uri));
            var contents = await response.Content.ReadAsStringAsync();

            return contents;
        }
    }
}
