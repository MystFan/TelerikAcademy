using System;
/*
 Problem 9. Play with Int, Double and String

    -Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
    -Print the result at the console. Use switch statement.
 */
namespace _09.PlayWith_Int_Double_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            Console.Write("Choise: ");
            string input =  Console.ReadLine();

            int value;
            bool isValueNumber = int.TryParse(input, out value);
            if (isValueNumber)
            {
                switch (value)
                {
                    case 1: Console.Write("Please enter a int: ");
                        int integer = int.Parse(Console.ReadLine());
                        Console.WriteLine("--> {0}", integer + 1); break;
                    case 2: Console.Write("Please enter a double: ");
                        double realNumber = double.Parse(Console.ReadLine());
                        Console.WriteLine("--> {0}", realNumber + 1); break;
                    case 3: Console.Write("Please enter a text: ");
                        string text = Console.ReadLine();
                        Console.WriteLine("--> {0}*", text); break;
                    default: Console.WriteLine("Input choose is not valid"); break;
                }
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
