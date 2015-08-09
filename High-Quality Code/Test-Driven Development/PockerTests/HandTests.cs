using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PockerTests
{
    [TestClass]
    public class HandTests
    {
        private List<ICard> cards;
        private Hand hand;

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
        }

        [TestMethod]
        public void Hand_Create_ShouldSetHandCardsCollection()
        {
            Hand hand = new Hand(this.cards);

            Assert.IsNotNull(hand.Cards);
        }

        [TestMethod]
        public void Hand_ToString_ShouldNotReturnNull()
        {
            string handToString = hand.ToString();

            Assert.IsNotNull(handToString);
        }

        [TestMethod]
        public void Hand_ToString_ShouldReturnNotEmptyString()
        {
            string handToString = hand.ToString();

            Assert.AreNotEqual(string.Empty.Length, handToString.Length);
        }

        [TestMethod]
        public void Hand_ToString_ShouldContains_FirstCardToString()
        {
            string firstCardToString = this.cards[0].ToString();
            string handToString = this.hand.ToString();

            Assert.IsTrue(handToString.IndexOf(firstCardToString) >= 0);
        }

        [TestMethod]
        public void Hand_ToString_ShouldContains_SecondCardToString()
        {
            string secondCardToString = this.cards[1].ToString();
            string handToString = this.hand.ToString();

            Assert.IsTrue(handToString.IndexOf(secondCardToString) >= 0);
        }

        [TestMethod]
        public void Hand_ToString_ShouldContains_ThirdCardToString()
        {
            string thirdCardToString = this.cards[2].ToString();
            string handToString = this.hand.ToString();

            Assert.IsTrue(handToString.IndexOf(thirdCardToString) >= 0);
        }

        [TestMethod]
        public void Hand_ToString_ShouldContains_FourCardToString()
        {
            string fourCardToString = this.cards[3].ToString();
            string handToString = this.hand.ToString();

            Assert.IsTrue(handToString.IndexOf(fourCardToString) >= 0);
        }

        [TestMethod]
        public void Hand_ToString_ShouldContains_FiveCardToString()
        {
            string fiveCardToString = this.cards[4].ToString();
            string handToString = this.hand.ToString();

            Assert.IsTrue(handToString.IndexOf(fiveCardToString) >= 0);
        }


        [TestMethod]
        public void Hand_ToString_ShouldReturn_CorrectValue()
        {
            string currentToString = string.Empty;
            currentToString += "(" + string.Join(", ", this.hand.Cards) + ")";
            string handToString = this.hand.ToString();

            Assert.AreEqual(currentToString, handToString);
        }

        [TestMethod]
        public void Hand_ToString_ShouldReturn_InvalidValue()
        {
            string currentToString =  string.Join(", ", this.hand.Cards);
            string handToString = this.hand.ToString();

            Assert.AreNotEqual(currentToString, handToString);
        }
    }
}
