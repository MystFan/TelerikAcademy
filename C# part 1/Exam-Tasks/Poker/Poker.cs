
namespace Poker
{
    using System;
    using System.Collections.Generic;
    class Poker
    {
        static void Main()
        {
            List<string> hand = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                hand.Add(Console.ReadLine());
            }

            if (EqualChars(hand, 5) == 1)
            {
                Console.WriteLine("Impossible");
            }
            else if (EqualChars(hand, 4) == 1)
            {
                Console.WriteLine("Four of a Kind");
            }
            else if (EqualChars(hand, 3) == 1 && !(EqualChars(hand, 2) == 1))
            {
                Console.WriteLine("Three of a Kind");
            }
            else if (EqualChars(hand, 3) == 1 && EqualChars(hand, 2) == 1)
            {
                Console.WriteLine("Full House");
            }
            else if (!(EqualChars(hand, 2) == 1) && !(EqualChars(hand, 3) == 1) && !(EqualChars(hand, 4) == 1) && !(EqualChars(hand, 5) == 1) && !(EqualChars(hand, 2) == 2))
            {
                Console.WriteLine("Straight");
            }
            else if (EqualChars(hand, 2) == 2)
            {
                Console.WriteLine("Two Pairs");
            }
            else if (EqualChars(hand, 2) == 1)
            {
                Console.WriteLine("One Pair");
            }
            else if (AreConsecutive(hand))
            {
                Console.WriteLine("Straight");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
        private static bool AreConsecutive(List<string> list)
        {
            bool result = true;
            List<int> nums = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                int number;
                bool isNumber = int.TryParse(list[i].ToString(), out number);
                if (isNumber)
                {
                    nums.Add(number);
                }
                else
                {
                    switch (list[i])
                    {
                        case "J": nums.Add(11); break;
                        case "Q": nums.Add(12); break;
                        case "K": nums.Add(13); break;
                        case "A": nums.Add(14); break;
                    }
                }
            }
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    result = false;
                }
            }
            return result;
        }
        private static int EqualChars(List<string> str, int count)
        {
            int currentCounter = 0;
            int counter = 0;
            for (int i = 0; i < str.Count; i++)
            {
                for (int j = 0; j < str.Count; j++)
                {
                    if (str[i] == str[j])
                    {
                        currentCounter++;
                    }
                }
                if (currentCounter == count)
                {
                    counter++;
                    if (count > 2)
                    {
                        break;
                    }
                }
                currentCounter = 0;
            }
            if (count == 2)
            {
                counter /= 2;
            }
            return counter;
        }
    }
}
