using System;
/*
 Problem 12.* Zero Subset

   - We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
   - Assume that repeating the same subset several times is not a problem.
 */
namespace _12.ZeroSubset
{
    class Program
    {
        static void Main()
        {
            Console.Write("First number: ");
            string inputFirstNumber = Console.ReadLine();
            Console.Write("Second number: ");
            string inputSecondNumber = Console.ReadLine();
            Console.Write("Third number: ");
            string inputThirdNumber = Console.ReadLine();
            Console.Write("Four number: ");
            string inputFourNumber = Console.ReadLine();
            Console.Write("Five number: ");
            string inputFiveNumber = Console.ReadLine();

            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int fourNumber;
            int fiveNumber;

            bool isValidFirstNumber = int.TryParse(inputFirstNumber, out firstNumber);
            bool isValidSecondNumber = int.TryParse(inputSecondNumber, out secondNumber);
            bool isValidThirdNumber = int.TryParse(inputThirdNumber, out thirdNumber);
            bool isValidFourNumber = int.TryParse(inputFourNumber, out fourNumber);
            bool isValidFiveNumber = int.TryParse(inputFiveNumber, out fiveNumber);

            if (isValidFirstNumber && isValidSecondNumber && isValidThirdNumber && isValidFourNumber && isValidFiveNumber)
            {
                bool findSubset = false;
                if (firstNumber + secondNumber == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", firstNumber, secondNumber);
                    findSubset = true;
                }
                if (firstNumber + thirdNumber == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", firstNumber, thirdNumber);
                    findSubset = true;
                }
                if (firstNumber + fourNumber == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", firstNumber, fourNumber);
                    findSubset = true;
                }
                if (firstNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", firstNumber, fiveNumber);
                    findSubset = true;
                }
                if (secondNumber + thirdNumber == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", secondNumber, thirdNumber);
                    findSubset = true;
                }
                if (secondNumber + fourNumber == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", secondNumber, fourNumber);
                    findSubset = true;
                }
                if (secondNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", secondNumber, fiveNumber);
                    findSubset = true;
                }
                if (thirdNumber + fourNumber == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", thirdNumber, fourNumber);
                    findSubset = true;
                }
                if (thirdNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", thirdNumber, fiveNumber);
                    findSubset = true;
                }
                if (fourNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", fourNumber, fiveNumber);
                    findSubset = true;
                }
                if (firstNumber + secondNumber + thirdNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", firstNumber , secondNumber ,thirdNumber);
                    findSubset = true;
                }
                if (firstNumber + secondNumber + fourNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fourNumber);
                    findSubset = true;
                }
                if (firstNumber + secondNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fiveNumber);
                    findSubset = true;
                }
                if (firstNumber + thirdNumber + fourNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, thirdNumber, fourNumber);
                    findSubset = true;
                }
                if (firstNumber + thirdNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, thirdNumber, fiveNumber);
                    findSubset = true;
                }
                if (firstNumber + fourNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, fourNumber, fiveNumber);
                    findSubset = true;
                }
                if (secondNumber + thirdNumber + fourNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, thirdNumber, fourNumber);
                    findSubset = true;
                }
                if (secondNumber + thirdNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, thirdNumber, fiveNumber);
                    findSubset = true;
                }
                if (secondNumber + fourNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, fourNumber, fiveNumber);
                    findSubset = true;
                }
                if (thirdNumber + fourNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", thirdNumber, fourNumber, fiveNumber);
                    findSubset = true;
                }
                if (firstNumber + secondNumber + thirdNumber + fourNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fourNumber);
                    findSubset = true;
                }
                if (firstNumber + secondNumber + fourNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber,secondNumber, fourNumber, fiveNumber);
                    findSubset = true;
                }
                if (firstNumber + thirdNumber + fourNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0",firstNumber, thirdNumber, fourNumber, fiveNumber);
                    findSubset = true;
                }
                if (firstNumber + secondNumber + thirdNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0",firstNumber,secondNumber, thirdNumber, fiveNumber);
                    findSubset = true;
                }
                if (secondNumber + thirdNumber + fourNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0",secondNumber, thirdNumber, fourNumber, fiveNumber);
                    findSubset = true;
                }
                if (firstNumber + secondNumber + thirdNumber + fourNumber + fiveNumber == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0",firstNumber,secondNumber, thirdNumber, fourNumber, fiveNumber);
                    findSubset = true;
                }
                if (!findSubset)
                {
                    Console.WriteLine("no zero subset");
                }
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
