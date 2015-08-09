using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PockerTests
{

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Card_Initialize_ShouldSetFace()
        {
            Card card = new Card(CardFace.Five, CardSuit.Diamonds);
            var face = CardFace.Five;
            Assert.AreEqual(face, card.Face);
        }

        [TestMethod]
        public void Card_Initialize_ShouldSetSuit()
        {
            Card card = new Card(CardFace.Five, CardSuit.Diamonds);
            var suit = CardSuit.Diamonds;
            Assert.AreEqual(suit, card.Suit);
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_SuitDiamonds()
        {
            Card card = new Card(CardFace.Five, CardSuit.Diamonds);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual('\u2666'.ToString(), cardToString.Substring(length - 1));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_SuitClubs()
        {
            Card card = new Card(CardFace.Five, CardSuit.Clubs);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual('\u2663'.ToString(), cardToString.Substring(length - 1));
        }


        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_SuitHearts()
        {
            Card card = new Card(CardFace.Five, CardSuit.Hearts);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual('\u2665'.ToString(), cardToString.Substring(length - 1));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_SuitSpades()
        {
            Card card = new Card(CardFace.Five, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual('\u2660'.ToString(), cardToString.Substring(length - 1));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectFace_Five()
        {
            Card card = new Card(CardFace.Five, CardSuit.Diamonds);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Five", cardToString.Substring(0, 4));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectFace_Jack()
        {
            Card card = new Card(CardFace.Jack, CardSuit.Clubs);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Jack", cardToString.Substring(0, 4));
        }


        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_Queen()
        {
            Card card = new Card(CardFace.Queen, CardSuit.Hearts);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Queen", cardToString.Substring(0, 5));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_King()
        {
            Card card = new Card(CardFace.King, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("King", cardToString.Substring(0, 4));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_Ace()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Ace", cardToString.Substring(0, 3));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_Ten()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Ten", cardToString.Substring(0, 3));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_Nine()
        {
            Card card = new Card(CardFace.Nine, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Nine", cardToString.Substring(0, 4));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_Eight()
        {
            Card card = new Card(CardFace.Eight, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Eight", cardToString.Substring(0, 5));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_Seven()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Seven", cardToString.Substring(0, 5));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_Six()
        {
            Card card = new Card(CardFace.Six, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Six", cardToString.Substring(0, 3));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_Four()
        {
            Card card = new Card(CardFace.Four, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Four", cardToString.Substring(0, 4));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_Three()
        {
            Card card = new Card(CardFace.Three, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Three", cardToString.Substring(0, 5));
        }

        [TestMethod]
        public void Card_ToString_ShouldReturnCorrectSuit_Two()
        {
            Card card = new Card(CardFace.Two, CardSuit.Spades);
            var cardToString = card.ToString();
            var length = cardToString.Length;
            Assert.AreEqual("Two", cardToString.Substring(0, 3));
        }
    }
}
