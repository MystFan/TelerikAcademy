using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class Hand : IHand, IComparable
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            var handToString = "(" + string.Join(", ", this.Cards) + ")";
            return handToString;
        }

        public int CompareTo(object other)
        {
            var sum = this.Cards.Sum(c => (int)c.Face);
            var otherSum = ((Hand)other).Cards.Sum(c => (int)c.Face);

            if (sum > otherSum)
            {
                return -1;
            }
            if (sum < otherSum)
            {
                return 1;
            }

            return 0;
        }
    }
}
