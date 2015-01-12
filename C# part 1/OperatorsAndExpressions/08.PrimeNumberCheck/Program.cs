using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 8. Prime Number Check

//    -Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

namespace _08.PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 and 99");
            string input = Console.ReadLine();

            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber && number > 0 && number < 100)
            {
                Console.Write("Number is Prime: ");
                bool isPrime = true;
                if (number == 1)
                {
                    Console.WriteLine(!isPrime);
                }
                else if(number >= 2)
                {
                    for (int i = 2; i < 100; i++)
                    {
                        if (number % i == 0 && number != i)
                        {
                            isPrime = false;
                        }
                    }
                    Console.WriteLine(isPrime);
                }

            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
