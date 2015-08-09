using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Linq;
using System.Collections.Generic;

namespace PockerTests
{
    [TestClass]
    public class PokerHandsCheckerIsFlushTests
    {
        private static List<ICard> cards;
        private static Hand hand;
        private static PokerHandsChecker checker;

        [TestInitialize]
        public void Init()
        {
            cards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            };

            cards.Sort((c1, c2) => ((int)c1.Face).CompareTo((int)c2.Face));
            hand = new Hand(cards);
            checker = new PokerHandsChecker();
        }

        [TestMethod]
        public void PokerHandsCheckerIsFlush_HandWithValidCardsCountShouldBe_True()
        {
            Assert.AreEqual(cards.Count == 5, checker.IsFlush(hand));
        }

        [TestMethod]
        public void PokerHandsCheckerIsFlush_HandWithInvalidCardsCountShouldBe_False()
        {
            var currentHand = new Hand(hand.Cards);
            currentHand.Cards.RemoveAt(0);
            Assert.AreNotEqual(cards.Count, checker.IsFlush(currentHand));
        }

        [TestMethod]
        public void PokerHandsCheckerIsFlush_HandCardsWithSameSuit_isFlushShouldBe_True()
        {
            bool sameSuit = hand.Cards.All(c => c.Suit == CardSuit.Clubs);

            Assert.AreEqual(sameSuit, checker.IsFlush(hand));
        }

        [TestMethod]
        public void PokerHandsCheckerIsFlush_HandCardsWithNotInSequenceFaces_isFlushShouldBe_True()
        {
            var notSequenceCardFaces = true;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (((int)hand.Cards[i].Face) == ((int)hand.Cards[i].Face) + 1)
                {
                    notSequenceCardFaces = false;
                    break;
                }
            }

            Assert.AreEqual(notSequenceCardFaces, checker.IsFlush(hand));
        }
    }
}
