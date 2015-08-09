namespace Deck.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        public Deck deck;
        public List<Card> cards; 

        [SetUp]
        public void Init()
        {
            this.deck = new Deck();
            this.cards = new List<Card>();
        }

        [Test]
        public void Test_CreateDeckShouldContains24Cards()
        {
            Assert.AreEqual(24, this.deck.CardsLeft);
        }

        [Test]
        public void Test_GetNextCard_ShouldDecreaseCardsCount()
        {
            var allCardsCount = this.deck.CardsLeft;
            Card card = this.deck.GetNextCard();
            Assert.AreEqual(this.deck.CardsLeft, allCardsCount - 1);
        }

        [Test]
        public void Test_ChangeTrumpCard_ShouldChangeTrumpCard()
        {
            Card trumpCard = this.deck.GetTrumpCard;
            Card nextCard = this.deck.GetNextCard();
            this.deck.ChangeTrumpCard(nextCard);
            Assert.AreNotSame(trumpCard, this.deck.GetTrumpCard);
        }

        [TestCase(CardType.Nine)]
        public void Test_DeckContainsCardTypeNine(CardType nine)
        {
            while (this.deck.CardsLeft > 0)
            {
                this.cards.Add(this.deck.GetNextCard());
            }
            var nineTypeCard = this.cards.FirstOrDefault(c => c.Type == nine);
            Assert.AreEqual(nine, nineTypeCard.Type);
        }

        [TestCase(CardType.Ten)]
        public void Test_DeckContainsCardTypeTen(CardType ten)
        {
            while (this.deck.CardsLeft > 0)
            {
                this.cards.Add(this.deck.GetNextCard());
            }
            var tenTypeCard = this.cards.FirstOrDefault(c => c.Type == ten);
            Assert.AreEqual(ten, tenTypeCard.Type);
        }

        [TestCase(CardType.Jack)]
        public void Test_DeckContainsCardTypeJack(CardType jack)
        {
            while (this.deck.CardsLeft > 0)
            {
                this.cards.Add(this.deck.GetNextCard());
            }
            var jackTypeCard = this.cards.FirstOrDefault(c => c.Type == jack);
            Assert.AreEqual(jack, jackTypeCard.Type);
        }

        [TestCase(CardType.Queen)]
        public void Test_DeckContainsCardTypeQueen(CardType queen)
        {
            while (this.deck.CardsLeft > 0)
            {
                this.cards.Add(this.deck.GetNextCard());
            }
            var queenTypeCard = this.cards.FirstOrDefault(c => c.Type == queen);
            Assert.AreEqual(queen, queenTypeCard.Type);
        }

        [TestCase(CardType.King)]
        public void Test_DeckContainsCardTypeKing(CardType king)
        {
            while (this.deck.CardsLeft > 0)
            {
                this.cards.Add(this.deck.GetNextCard());
            }
            var kingTypeCard = this.cards.FirstOrDefault(c => c.Type == king);
            Assert.AreEqual(king, kingTypeCard.Type);
        }

        [TestCase(CardType.Ace)]
        public void Test_DeckContainsCardTypeAce(CardType ace)
        {
            while (this.deck.CardsLeft > 0)
            {
                this.cards.Add(this.deck.GetNextCard());
            }
            var aceTypeCard = this.cards.FirstOrDefault(c => c.Type == ace);
            Assert.AreEqual(ace, aceTypeCard.Type);
        }

    }
}
