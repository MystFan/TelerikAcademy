using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker;

namespace PockerTests
{
    [TestClass]
    public class PokerHandsCheckerIsValidHandTests
    {
        private List<ICard> cards;
        private Hand hand;
        private PokerHandsChecker checker;

        [TestInitialize]
        public void Init()
        {
            this.cards = new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts)
            };

            this.hand = new Hand(this.cards);
            this.checker = new PokerHandsChecker();
        }


        [TestMethod]
        public void PokerHandsChecker_HandWithLessThanFiveCardsShouldBeInvalid_False()
        {
            IList<ICard> currentCards = new List<ICard>(this.cards);
            currentCards.RemoveAt(0);
            var currentHand = new Hand(currentCards);

            Assert.IsFalse(this.checker.IsValidHand(currentHand));
        }

        [TestMethod]
        public void PokerHandsChecker_HandWithMoreThanFiveCardsShouldBeInvalid_False()
        {
            IList<ICard> currentCards = new List<ICard>(this.cards);
            currentCards.Add(new Card(CardFace.Three, CardSuit.Spades));
            var currentHand = new Hand(currentCards);

            Assert.IsFalse(this.checker.IsValidHand(currentHand));
        }

        [TestMethod]
        public void PokerHandsChecker_HandWithRepeatCardShouldBeInvalid_False()
        {
            IList<ICard> currentCards = new List<ICard>(this.cards);
            currentCards.RemoveAt(0);
            currentCards.Add(new Card(currentCards[0].Face, currentCards[0].Suit));
            var currentHand = new Hand(currentCards);

            Assert.IsFalse(this.checker.IsValidHand(currentHand));
        }

        [TestMethod]
        public void PokerHandsChecker_HandWithDifferentCardsAndCorrectCountShouldBeValid_True()
        {
            Assert.IsTrue(this.checker.IsValidHand(this.hand));
        }
    }
}
