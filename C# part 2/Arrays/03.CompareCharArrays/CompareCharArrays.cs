/*
 Problem 3. Compare char arrays

    Write a program that compares two char arrays lexicographically (letter by letter).

 */
namespace _03.CompareCharArrays
{
    using System;
    class CompareCharArrays
    {
        static void Main()
        {
            Console.WriteLine("Enter first string as char array");
            string firstCharArray = Console.ReadLine();
            Console.WriteLine("Enter second string as char array");
            string secondCharArray = Console.ReadLine();

            int maxLenght = firstCharArray.Length;

            if (secondCharArray.Length > maxLenght)
            {
                maxLenght = secondCharArray.Length;
            }


            for (int i = 0; i < maxLenght; i++)
            {
                if (firstCharArray[i] < secondCharArray[i])
                {
                    Console.WriteLine("The second string is Lexicographic ahead");
                    break;
                }
                if (firstCharArray[i] > secondCharArray[i])
                {
                    Console.WriteLine("The first string is Lexicographic ahead");
                    break;
                }
            }
            
        }
    }
}
