using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            char suit = '\0';
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suit = '\u2663';
                    break;
                case CardSuit.Diamonds:
                    suit = '\u2666';
                    break;
                case CardSuit.Hearts:
                    suit = '\u2665';
                    break;
                case CardSuit.Spades:
                    suit = '\u2660';
                    break;
            }

            string result = (this.Face) + " " + suit;
            return result;
        }
    }
}
