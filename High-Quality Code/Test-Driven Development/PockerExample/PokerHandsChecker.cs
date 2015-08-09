using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            var isValid = true;
            var handValidCardsCount = 5;

            if (hand.Cards.Count < handValidCardsCount || hand.Cards.Count > handValidCardsCount)
            {
                isValid = false;
                return isValid;
            }


            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (i != j)
                    {
                        if (hand.Cards[i].Face == hand.Cards[j].Face && hand.Cards[i].Suit == hand.Cards[j].Suit)
                        {
                            isValid = false;
                            return isValid;
                        }
                    }
                }
            }

            return isValid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var hasFourOfAKind = false;
            CardFace[] faces = hand.Cards.Select(c => c.Face).ToArray();
            for (int i = 0; i < faces.Length; i++)
            {
                int count = faces.Count(f => f == faces[i]);
                if (count == 4)
                {
                    hasFourOfAKind = true;
                    break;
                }
            }

            return hasFourOfAKind;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            var isValid = true;
            var handValidCardsCount = 5;

            if (hand.Cards.Count < handValidCardsCount || hand.Cards.Count > handValidCardsCount)
            {
                isValid = false;
                return isValid;
            }

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (((int)hand.Cards[i].Face) == ((int)hand.Cards[i].Face) + 1)
                {
                    isValid = false;
                    return isValid;
                }
            }

            return isValid;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            var hasThreeOfAKind = false;
            CardFace[] faces = hand.Cards.Select(c => c.Face).ToArray();
            for (int i = 0; i < faces.Length; i++)
            {
                int count = faces.Count(f => f == faces[i]);
                if (count == 3)
                {
                    var lastTwo = faces.Where(f => f != faces[i]).ToArray();
                    if (lastTwo[0] != lastTwo[1])
                    {
                        hasThreeOfAKind = true;
                    }
                    else
                    {
                        hasThreeOfAKind = false;
                    }
                    break;
                }
            }

            return hasThreeOfAKind;
        }

        public bool IsTwoPair(IHand hand)
        {
            var faces = hand.Cards.Select(c => c.Face).ToArray();

            bool hasTwoPair = true;
            int pairsCount = 0;
            for (int i = 0; i < faces.Length; i++)
            {
                for (int j = i; j < faces.Length; j++)
                {
                    if (i != j)
                    {
                        if (faces[i] == faces[j])
                        {
                            pairsCount++;
                            if (pairsCount > 2)
                            {
                                hasTwoPair = false;
                                return hasTwoPair;
                            }
                        }
                    }
                }
            }

            return hasTwoPair;
        }

        public bool IsOnePair(IHand hand)
        {
            var faces = hand.Cards.Select(c => c.Face).ToArray();

            bool hasOnePair = true;
            int pairsCount = 0;
            for (int i = 0; i < faces.Length; i++)
            {
                for (int j = i; j < faces.Length ; j++)
                {
                    if (i != j)
                    {
                        if (faces[i] == faces[j])
                        {
                            pairsCount++;
                            if (pairsCount > 1)
                            {
                                hasOnePair = false;
                                return hasOnePair;
                            }
                        }
                    }
                }
            }

            return hasOnePair;
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            if (firstHand == null || secondHand == null)
            {
                throw new ArgumentNullException();
            }

            return (firstHand as Hand).CompareTo(secondHand as Hand);
        }
    }
}
