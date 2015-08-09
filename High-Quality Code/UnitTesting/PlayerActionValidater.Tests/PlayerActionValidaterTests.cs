using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Santase.Logic;

namespace PlayerActionValidater.Tests
{
    [TestClass]
    public class PlayerActionValidaterTests
    {
        private Santase.Logic.PlayerActionValidater playerActionValidater;
        private Santase.ConsoleUI.ConsolePlayer player;

        [TestInitialize]
        public void Init()
        {
            this.playerActionValidater = new Santase.Logic.PlayerActionValidater();
            this.player = new Santase.ConsoleUI.ConsolePlayer(2, 3);
        }

        [TestMethod]
        public void PlayerActionValidater_ActionParameter_PlayerActionTypePlayCard_PlayerCardsNotContains_ActionCard()
        {
            this.player.AddCard(new Santase.Logic.Cards.Card(Santase.Logic.Cards.CardSuit.Club, Santase.Logic.Cards.CardType.Jack));
            var action = new Santase.Logic.Players.PlayerAction(Santase.Logic.Players.PlayerActionType.PlayCard, new Santase.Logic.Cards.Card(Santase.Logic.Cards.CardSuit.Club, Santase.Logic.Cards.CardType.King), Announce.None);

        }
    }
}
