
namespace AngryFemaleGPS
{
    using System;
    class AngryFemaleGPS
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            long evenSum = 0;
            long oddSum = 0;
            long currentNumber = number;
            if (currentNumber < 0)
            {
                currentNumber *= (-1);
            }
            for (int i = 0; i < number.ToString().Length; i++)
            {
                long digit = currentNumber % 10;
                currentNumber = currentNumber / 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
            }



            string direction = String.Empty;
            if (evenSum > oddSum)
            {
                direction = "right";
                Console.WriteLine("{0} {1}", direction, evenSum);
            }
            if (oddSum > evenSum)
            {
                direction = "left";
                Console.WriteLine("{0} {1}", direction, oddSum);
            }
            if (oddSum == evenSum)
            {
                direction = "straight";
                Console.WriteLine("{0} {1}", direction, oddSum);
            }

        }
    }
}
