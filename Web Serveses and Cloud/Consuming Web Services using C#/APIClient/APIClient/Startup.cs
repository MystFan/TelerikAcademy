namespace APIClient
{
    using System;

    public class Startup
    {
        static void Main(string[] args)
        {
            FootballApiClient footballClient = new FootballApiClient();
            var results = footballClient.GetTeamResult(340);

            if (results.Count > 0)
            {
                foreach (var fixture in results.Fixtures)
                {
                    Console.WriteLine("{0} - {1} {2}:{3}",
                        fixture.HomeTeamName,
                        fixture.AwayTeamName,
                        fixture.Result.GoalsHomeTeam,
                        fixture.Result.GoalsAwayTeam);
                }
            }
        }
    }
}
