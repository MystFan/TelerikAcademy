using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;
using System.Linq;

namespace PockerTests
{
    [TestClass]
    public class PokerHandsCheckerIsThreeOfAKindTests
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
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts)
            };

            hand = new Hand(cards);
            checker = new PokerHandsChecker();
        }

        [TestMethod]
        public void PokerHandsChecker_IsThreeOfAKind_ContainsThreeCardsWithSameFace_ShouldBe_True()
        {
            int count = cards.Count(c => c.Face == CardFace.Eight);

            Assert.AreEqual(count == 3, checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void PokerHandsChecker_IsThreeOfAKind_ContainsLessThanThreeCardsWithSameFace_ShouldBe_False()
        {
            var currentHand = new Hand(cards);
            currentHand.Cards.RemoveAt(0);

            Assert.IsFalse(checker.IsThreeOfAKind(currentHand));
        }

        [TestMethod]
        public void PokerHandsChecker_IsThreeOfAKind_ContainsMoreThanThreeCardsWithSameFace_ShouldBe_False()
        {
            var currentHand = new Hand(cards);
            currentHand.Cards.RemoveAt(cards.Count - 1);
            currentHand.Cards.Add(new Card(CardFace.Eight, CardSuit.Hearts));

            Assert.IsFalse(checker.IsThreeOfAKind(currentHand));
        }
    }
}
