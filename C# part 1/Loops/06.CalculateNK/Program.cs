using System;
/*
 Problem 6. Calculate N! / K!

   -Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
   - Use only one loop.

 */
namespace _06.CalculateNK
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter n and k (1 < k < n < 100)");
            Console.Write("n = ");
            string inputN = Console.ReadLine();
            Console.Write("k = ");
            string inputK = Console.ReadLine();

            int n;
            int k;
            bool isNumberN = int.TryParse(inputN, out n);
            bool isNumberK = int.TryParse(inputK, out k);

            if (isNumberN && isNumberK)
            {
                if ((k > 1 && k < 100) && (n > 1 && n < 100))
                {
                    if (k < n)
                    {
                        long factorielN = 1;
                        long factorielK = 1;
                        for (int i = n; i > 0; i--)
                        {
                            if (i <= k)
                            {
                                factorielK *= i;
                            }
                            factorielN *= i;
                        }

                        long expression = factorielN / factorielK;
                        Console.WriteLine("Result --> {0}",expression);
                    }
                    else
                    {
                        Console.WriteLine("K must be less than N");
                    }
                }
                else
                {
                    Console.WriteLine("N or K is out of range");
                }
            }
            else
            {
                Console.WriteLine("Some input string was not in correct format");
            }
        }
    }
}
