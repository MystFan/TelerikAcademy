namespace Pong.Hubs
{
    using Microsoft.AspNet.SignalR;
    using System;

    public class SaveResult : Hub
    {
        private Random rand = new Random();
        private int PlayerScore = 0;
        private int ComputerScore = 0;

        private string[] playerMessages = new string[]
        {
            "You are the best",
            "Keep still",
            "Very Good",
            "OK"
        };

        private string[] computerMessages = new string[]
        {
            "Maybe more",
            "Keep Going",
            "Just so you know",
            "You are weak"
        };

        public void GetPlayerMessage()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<SaveResult>();
            context.Clients.All.setMessage(playerMessages[rand.Next(0, 4)]);
        }

        public void GetComputerMessage()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<SaveResult>();
            context.Clients.All.setMessage(computerMessages[rand.Next(0, 4)]);
        }

        public void GetPlayerScore(int score)
        {
            PlayerScore++;
        }

        public void GetComputerScore(int score)
        {
            ComputerScore++;
        }

        public int GetCurrentPlayerScore()
        {
            return PlayerScore;
        }

        public int GetCurrentComputerScore()
        {
            return ComputerScore;
        }
    }
}