/*
 Problem 3. Correct brackets

    Write a program to check if in a given expression the brackets are put correctly.

Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */
namespace _03.CorrectBrackets
{
    using System;
    class CorrectBrackets
    {
        static void Main()
        {
            string example = "((a + b) / 5 - d)";
            Console.WriteLine(isCorectBrackets(example));
            example = ")(a+b))";
            Console.WriteLine(isCorectBrackets(example));
        }

        private static bool isCorectBrackets(string exp)
        {
            int countOpenBrackets = 0;
            int countCloseBrackets = 0;
            bool validBrackets = false;
            if ((exp[0] == ')') || (exp[exp.Length - 1] == '('))
            {
                validBrackets = false;
                return validBrackets;
            }
            else
            {
                for (int i = 0; i < exp.Length; i++)
                {
                    if (exp[i] == '(')
                    {
                        countOpenBrackets++;
                    }
                    if (exp[i] == ')')
                    {
                        countCloseBrackets++;
                    }
                }
            }

            if (countCloseBrackets == countOpenBrackets)
            {
                return true;
            }
            return validBrackets;
        }
    }
}
