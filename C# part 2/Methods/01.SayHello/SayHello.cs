/*
 Problem 1. Say Hello

    Write a method that asks the user for his name and prints “Hello, <name>”
    Write a program to test this method.

 */
namespace _01.SayHello
{
    using System;
    class SayHello
    {
        static void Main()
        {
            Hello();
        }

        private static void Hello()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
