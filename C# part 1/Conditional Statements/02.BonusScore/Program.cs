using System;
//Problem 2. Bonus Score

//    -Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//        If the score is between 1 and 3, the program multiplies it by 10.
//        If the score is between 4 and 6, the program multiplies it by 100.
//        If the score is between 7 and 9, the program multiplies it by 1000.
//        If the score is 0 or more than 9, the program prints “invalid score”.

namespace _02.BonusScore
{
    class Program
    {
        static void Main()
        {
            Console.Write("Score: ");
            string inputScore= Console.ReadLine();

            int score;
            bool isNumber = int.TryParse(inputScore, out score);

            if (isNumber)
            {
                if (score > 0 && score < 10)
                {
                    if (score > 0 && score < 4)
                    {
                        score *= 10;
                    }
                    else if (score > 3 && score < 7)
                    {
                        score *= 100;
                    }
                    else if (score > 6 && score < 10)
                    {
                        score *= 1000;
                    }
                    Console.WriteLine("Score = {0}", score);
                }
                else
                {
                    Console.WriteLine("invalid score");
                }
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
