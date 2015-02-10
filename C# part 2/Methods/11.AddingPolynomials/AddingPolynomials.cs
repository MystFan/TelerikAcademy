/*
 Problem 11. Adding polynomials

    Write a method that adds two polynomials.
    Represent them as arrays of their coefficients.

 */
namespace _11.AddingPolynomials
{
    using System;

    public class AddingPolynomials
    {
        static void Main()
        {
            int[] polyOne = { 5, 0, 1, 9 };
            int[] polyTwo = { 3, 2, 0, 2 };
            Console.WriteLine("First polynomial");
            PrintPolynomail(polyOne);
            Console.WriteLine("Second polynomial");
            PrintPolynomail(polyTwo);
            var result = AddTwoPolynomials(polyOne, polyTwo);
            Console.WriteLine("Result polynomial");
            PrintPolynomail(result);
        }

        private static int[] AddTwoPolynomials(int[] firstPoly, int[] secondPoly)
        {
            int[] result = new int[firstPoly.Length];
            if (firstPoly.Length != secondPoly.Length)
            {
                throw new ArgumentException("Arrays with coefficients must have the same length");
            }
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstPoly[i] + secondPoly[i];
            }
            return result;
        }

        public static void PrintPolynomail(int[] print)
        {
            for (int i = print.Length - 1; i >= 0; i--)
            {
                if ((print[i] != 0) && (i != 0))
                {
                    if (print[i - 1] >= 0)
                    {
                        Console.Write(" {1}x^{0} +", i, print[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, print[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write(" {0}", print[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
