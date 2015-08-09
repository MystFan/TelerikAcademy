using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;
using System.Linq;

namespace PockerTests
{
    [TestClass]
    public class PokerHandsCheckerIsTwoPairTests
    {
        private static List<ICard> cards;
        private static Hand hand;
        private static PokerHandsChecker checker;

        [TestInitialize]
        public void Init()
        {
            cards = new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts)
            };

            hand = new Hand(cards);
            checker = new PokerHandsChecker();
        }

        [TestMethod]
        public void PokerHandsCheckerIsTwoPair_HandWithTwoPair_ShouldBe_True()
        {
            var count = hand.Cards.Count(c => c.Face == CardFace.Four || c.Face == CardFace.Five);
            Assert.AreEqual(count == 4, checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void PokerHandsCheckerIsTwoPair_HandWithTwoPair_PlusOneCardsWhichAreNotWithSameFace_ShuldBe_True()
        {
            var lastCards = hand.Cards.Where(f => f.Face != CardFace.Four && f.Face != CardFace.Five).ToArray();
            
            Assert.AreEqual(lastCards.Length == 1, checker.IsTwoPair(hand));
        }


        [TestMethod]
        public void PokerHandsCheckerIsTwoPair_LastCard_ShuldBeDifferent_False()
        {
            var currentHand = new Hand(hand.Cards);
            currentHand.Cards.RemoveAt(currentHand.Cards.Count - 1);
            currentHand.Cards.Add(new Card(currentHand.Cards[0].Face, currentHand.Cards[0].Suit));

            Assert.IsFalse(checker.IsTwoPair(currentHand));
        }

    }
}
