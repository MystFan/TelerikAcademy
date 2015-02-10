/*
 Problem 12. Subtracting polynomials

    Extend the previous program to support also subtraction and multiplication of polynomials.

 */
namespace _12.SubtractingPolynomials
{
    using System;
    using _11.AddingPolynomials;
    class SubtractingPolynomials
    {
        static void Main()
        {
            int[] polyOne = { 2, 0, 4 };
            int[] polyTwo = { 1, 3, 3 };
            Console.WriteLine("First polynomial");
            AddingPolynomials.PrintPolynomail(polyOne);
            Console.WriteLine("Second polynomial");
            AddingPolynomials.PrintPolynomail(polyTwo);
            var subtractResult = SubtractTwoPolynomials(polyOne, polyTwo);
            Console.WriteLine("Result subtraction");
            AddingPolynomials.PrintPolynomail(subtractResult);
            var multiplication = MultiplicationTwoPolynomials(polyOne, polyTwo);
            Console.WriteLine("Result multiplication");
            AddingPolynomials.PrintPolynomail(multiplication);
        }

        private static int[] SubtractTwoPolynomials(int[] firstPoly, int[] secondPoly)
        {
            int[] result = new int[firstPoly.Length];
            int[] clone = (int[])secondPoly.Clone();
            if (firstPoly.Length != secondPoly.Length)
            {
                throw new ArgumentException("Arrays with coefficients must have the same length");
            }
            for (int i = 0; i < clone.Length; i++)
            {
                clone[i] *= (-1);
            }
            for (int j = 0; j < result.Length; j++)
            {
                result[j] = firstPoly[j] + clone[j];
            }
            return result;
        }

        private static int[] MultiplicationTwoPolynomials(int[] firstPoly, int[] secondPoly)
        {
            int[] result = new int[firstPoly.Length];
            if (firstPoly.Length != secondPoly.Length)
            {
                throw new ArgumentException("Arrays with coefficients must have the same length");
            }
            for (int i = firstPoly.Length - 1; i >= 0; i--)
            {
                if (firstPoly[i] == 0)
                {
                    firstPoly[i] = 1;
                }
                if (secondPoly[i] == 0)
                {
                    secondPoly[1] = 1;
                }
                result[i] = secondPoly[i] * firstPoly[i];
            }
            return result;
        }
    }
}
