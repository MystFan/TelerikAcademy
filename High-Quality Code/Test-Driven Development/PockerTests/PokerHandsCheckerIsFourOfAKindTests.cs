using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker;
using System.Linq;

namespace PockerTests
{
    [TestClass]
    public class PokerHandsCheckerIsFourOfAKindTests
    {
        private static List<ICard> cards;
        private static Hand hand;
        private static PokerHandsChecker checker;

        [TestInitialize]
        public void Init()
        {
            cards = new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts)
            };

            hand = new Hand(cards);
            checker = new PokerHandsChecker();
        }

        [TestMethod]
        public void PokerHandsChecker_IsFourOfAKind_ContainsFourCardsWithSameFace_ShouldBe_True()
        {
            int count = cards.Count(c => c.Face == CardFace.Eight);

            Assert.AreEqual(count == 4, checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void PokerHandsChecker_IsFourOfAKind_ContainsLessThanFourCardsWithSameFace_ShouldBe_False()
        {
            var currentHand = new Hand(cards);
            currentHand.Cards.RemoveAt(0);

            Assert.IsFalse(checker.IsFourOfAKind(currentHand));
        }

        [TestMethod]
        public void PokerHandsChecker_IsFourOfAKind_ContainsMoreThanFourCardsWithSameFace_ShouldBe_False()
        {
            var currentHand = new Hand(cards);
            currentHand.Cards.RemoveAt(cards.Count - 1);
            currentHand.Cards.Add(new Card(CardFace.Eight, CardSuit.Hearts));

            Assert.IsFalse(checker.IsFourOfAKind(currentHand));
        }
    }
}
