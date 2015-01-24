namespace TripleRotationOfDigits
{
    using System;
    class TripleRotationOfDigits
    {
        static void Main()
        {
            int numberToRotate = int.Parse(Console.ReadLine());

            string number = String.Empty;
            for (int i = 0; i < 3; i++)
            {
                int digit = numberToRotate % 10;
                if (digit != 0)
                {
                    number = digit + number;
                }
                numberToRotate = numberToRotate / 10;
            }
            if (numberToRotate != 0)
            {
                Console.WriteLine(number + numberToRotate);
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
