namespace _02.ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("../../numbers.txt");
            Console.SetIn(reader);

            Stack<int> stack = new Stack<int>();

            while (true)
            {
                string numberInput = Console.ReadLine();
                if (numberInput == "" || numberInput == null)
                {
                    break;
                }

                int number = int.Parse(numberInput);
                stack.Push(number);
            }

            PrintNumbers(stack);
        }

        private static void PrintNumbers(Stack<int> stack)
        {
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
