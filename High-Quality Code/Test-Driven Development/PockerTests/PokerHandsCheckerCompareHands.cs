using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker;
using System.Linq;

namespace PockerTests
{
    [TestClass]
    public class PokerHandsCheckerCompareHands
    {
        private static List<ICard> firstHandCards;
        private static List<ICard> secondHandCards;
        private static Hand firstHand;
        private static Hand secondHand;
        private static PokerHandsChecker checker;

        [TestInitialize]
        public void Init()
        {
            firstHandCards = new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts)
            };

            secondHandCards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds)
            };

            firstHand = new Hand(firstHandCards);
            secondHand = new Hand(secondHandCards);
            checker = new PokerHandsChecker();
        }


        [TestMethod]
        public void PokerHandsCheckerCompareHands_DifferentHands_ShouldReturnNotZero()
        {
            Assert.AreNotEqual(0, checker.CompareHands(firstHand, secondHand));
        }

        [TestMethod]
        public void PokerHandsCheckerCompareHands_FirstHandIsGreater_ShouldReturnOne()
        {
            Assert.AreEqual(1, checker.CompareHands(firstHand, secondHand));
        }

        [TestMethod]
        public void PokerHandsCheckerCompareHands_SecondHandIsGreater_ShouldReturnMinusOne()
        {
            Assert.AreEqual(-1, checker.CompareHands(secondHand, firstHand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PokerHandsCheckerCompareHands_FirstHandIsNull_ShouldThrow()
        {
            checker.CompareHands(null, secondHand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PokerHandsCheckerCompareHands_SecondHandIsNull_ShouldThrow()
        {
            checker.CompareHands(firstHand, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PokerHandsCheckerCompareHands_TwoHandsIsNull_ShouldThrow()
        {
            checker.CompareHands(null, null);
        }
    }
}
