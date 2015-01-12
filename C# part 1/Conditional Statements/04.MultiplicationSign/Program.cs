using System;
//Problem 4. Multiplication Sign

//    -Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//      Use a sequence of if operators.

namespace _04.MultiplicationSign
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

            double firstNumber;
            double secondNumber;
            double thirdNumber;

            bool isValidFirstNumber = double.TryParse(inputFirstNumber, out firstNumber);
            bool isValidSecondNumber = double.TryParse(inputSecondNumber, out secondNumber);
            bool isValidThirdNumber = double.TryParse(inputThirdNumber, out thirdNumber);


            if (isValidFirstNumber && isValidSecondNumber && isValidThirdNumber)
            {
                if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
                {
                    Console.WriteLine("Result --> +");
                }
                else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
                {
                    Console.WriteLine("Result --> 0");
                }
                else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
                {
                    Console.WriteLine("Result --> +");
                }
                else if (secondNumber > 0 && firstNumber < 0 && thirdNumber < 0)
                {
                    Console.WriteLine("Result --> +");
                }
                else if (thirdNumber > 0 && firstNumber < 0 && secondNumber < 0)
                {
                    Console.WriteLine("Result --> +");
                }
                else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
                {
                    Console.WriteLine("Result --> -");
                }
                else if (secondNumber < 0 && firstNumber > 0 && thirdNumber > 0)
                {
                    Console.WriteLine("Result --> -");
                }
                else if (thirdNumber < 0 && firstNumber > 0 && secondNumber > 0)
                {
                    Console.WriteLine("Result --> -");
                }
                else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
                {
                    Console.WriteLine("Result --> -");
                }
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
