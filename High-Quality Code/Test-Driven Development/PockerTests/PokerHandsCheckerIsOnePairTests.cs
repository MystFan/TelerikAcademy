using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;
using System.Linq;

namespace PockerTests
{
    [TestClass]
    public class PokerHandsCheckerIsOnePairTests
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
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts)
            };

            hand = new Hand(cards);
            checker = new PokerHandsChecker();
        }

        [TestMethod]
        public void PokerHandsCheckerIsOnePair_HandWithOnePair_ShouldBe_True()
        {
            var count = hand.Cards.Count(c => c.Face == CardFace.Four);
            Assert.AreEqual(count == 2, checker.IsOnePair(hand));
        }

        [TestMethod]
        public void PokerHandsCheckerIsOnePair_HandWithOnePair_PlusThreeCardsWhichAreNotWithSameFaces_ShuldBe_True()
        {
            var faces = hand.Cards.Select(c => c.Face).Where(f => f != CardFace.Four).ToArray();
            bool isDiffrentCardFaces = true;
            for (int i = 0; i < faces.Length - 1 ; i++)
            {
                if (faces[i] == faces[i + 1])
                {
                    isDiffrentCardFaces = false;
                }
            }

            Assert.AreEqual(isDiffrentCardFaces, checker.IsOnePair(hand));
        }


        [TestMethod]
        public void PokerHandsCheckerIsOnePair_MoreThanOnePair_OtherAreDifferent_ShuldBe_False()
        {
            var currentHand = new Hand(hand.Cards);
            currentHand.Cards.RemoveAt(2);
            currentHand.Cards.Add(new Card(currentHand.Cards[3].Face, currentHand.Cards[3].Suit));

            Assert.IsFalse(checker.IsOnePair(currentHand));
        }

        [TestMethod]
        public void PokerHandsCheckerIsOnePair_OnePair_PlusOtherCardWithSameFace_ShuldBe_False()
        {
            var currentHand = new Hand(hand.Cards);
            currentHand.Cards.RemoveAt(2);
            currentHand.Cards.Add(new Card(currentHand.Cards[0].Face, currentHand.Cards[0].Suit));

            Assert.IsFalse(checker.IsOnePair(currentHand));
        }

    }
}
