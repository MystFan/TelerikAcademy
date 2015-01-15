using System;
/*Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

    -Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
    -Use only one loop. Print the result with 5 digits after the decimal point.
*/
namespace _05.Calculate
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            string inputN = Console.ReadLine();
            Console.Write("x = ");
            string inputX = Console.ReadLine();

            int n;
            int x;
            bool isValidN = int.TryParse(inputN, out n);
            bool isValidX = int.TryParse(inputX, out x);
            if (isValidN && isValidX)
            {
                double sum = 1;
                int max = x;
                int min = n;
                if (n > max)
                {
                    max = n;
                    min = x;
                }
                int j = 0;
                for (int i = 1; i <= max; i++)
                {
                    if (j <= min)
                    {
                        j++;
                    }
                    sum += (i / j * i);
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Input string was not in correct format");
            }
        }
    }
}
