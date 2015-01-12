using System;
/*
 Problem 11.* Number as Words

    -Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
 */
namespace _11.NumberAsWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                bool isValidNumber = number >= 0 && number <= 999;
                if (isValidNumber)
                {
                    if (number >= 0 && number < 21)
                    {
                        switch (number)
                        {
                            case 0: Console.WriteLine("Zero"); break;
                            case 1: Console.WriteLine("One"); break;
                            case 2: Console.WriteLine("Two"); break;
                            case 3: Console.WriteLine("Three"); break;
                            case 4: Console.WriteLine("Four"); break;
                            case 5: Console.WriteLine("Five"); break;
                            case 6: Console.WriteLine("Six"); break;
                            case 7: Console.WriteLine("Seven"); break;
                            case 8: Console.WriteLine("Eight"); break;
                            case 9: Console.WriteLine("Nine"); break;
                            case 10: Console.WriteLine("Ten"); break;
                            case 11: Console.WriteLine("Eleven"); break;
                            case 12: Console.WriteLine("Twelve"); break;
                            case 13: Console.WriteLine("Thirteen"); break;
                            case 14: Console.WriteLine("Fourteen"); break;
                            case 15: Console.WriteLine("Fifteen"); break;
                            case 16: Console.WriteLine("Sixteen"); break;
                            case 17: Console.WriteLine("Seventeen"); break;
                            case 18: Console.WriteLine("Eighteen"); break;
                            case 19: Console.WriteLine("Nineteen"); break;
                            case 20: Console.WriteLine("Twenty"); break;
                            default: Console.WriteLine("not a number"); break;
                        }
                    }
                    else if (number > 20 && number <= 99)
                    {
                        if (number % 10 == 0)
                        {
                            switch (number)
                            {
                                case 30: Console.WriteLine("Thirty"); break;
                                case 40: Console.WriteLine("Forty"); break;
                                case 50: Console.WriteLine("Fifty"); break;
                                case 60: Console.WriteLine("Sixty"); break;
                                case 70: Console.WriteLine("Seventy"); break;
                                case 80: Console.WriteLine("Eighty"); break;
                                case 90: Console.WriteLine("Ninety"); break;
                            }
                        }
                        else if (number > 20 && number < 30)
                        {
                            Console.Write("Twenty ");
                        }
                        else if (number > 30 && number < 40)
                        {
                            Console.Write("Thirty ");
                        }
                        else if (number > 40 && number < 50)
                        {
                            Console.Write("Forty ");
                        }
                        else if (number > 50 && number < 60)
                        {
                            Console.Write("Fifty ");
                        }
                        else if (number > 60 && number < 70)
                        {
                            Console.Write("Sixty ");
                        }
                        else if (number > 70 && number < 80)
                        {
                            Console.Write("Seventy ");
                        }
                        else if (number > 80 && number < 90)
                        {
                            Console.Write("Eighty ");
                        }
                        else if (number > 90 && number < 100)
                        {
                            Console.Write("Ninety ");
                        }
                        int lastDigit = number % 10;
                        switch (lastDigit)
                        {
                            case 1: Console.WriteLine("One"); break;
                            case 2: Console.WriteLine("Two"); break;
                            case 3: Console.WriteLine("Three"); break;
                            case 4: Console.WriteLine("Four"); break;
                            case 5: Console.WriteLine("Five"); break;
                            case 6: Console.WriteLine("Six"); break;
                            case 7: Console.WriteLine("Seven"); break;
                            case 8: Console.WriteLine("Eight"); break;
                            case 9: Console.WriteLine("Nine"); break;
                            default: Console.WriteLine("not a number"); break;
                        }
                    }
                    else if (number >= 100 && number < 1000)
                    {
                        if (number % 100 == 0)
                        {
                            switch (number)
                            {
                                case 100: Console.WriteLine("One hundred"); break;
                                case 200: Console.WriteLine("Two hundred"); break;
                                case 300: Console.WriteLine("Three hundred"); break;
                                case 400: Console.WriteLine("Four hundred"); break;
                                case 500: Console.WriteLine("Five hundred"); break;
                                case 600: Console.WriteLine("Six hundred"); break;
                                case 700: Console.WriteLine("Seven hundred"); break;
                                case 800: Console.WriteLine("Eight hundred"); break;
                                case 900: Console.WriteLine("Nine hundred"); break;
                            }
                        }
                        else
                        {
                            int firstDigit = number / 100;
                            switch (firstDigit)
                            {
                                case 1: Console.Write("One hundred and "); break;
                                case 2: Console.Write("Two hundred and "); break;
                                case 3: Console.Write("Three hundred and "); break;
                                case 4: Console.Write("Four hundred and "); break;
                                case 5: Console.Write("Five hundred and "); break;
                                case 6: Console.Write("Six hundred and "); break;
                                case 7: Console.Write("Seven hundred and "); break;
                                case 8: Console.Write("Eight hundred and "); break;
                                case 9: Console.Write("Nine hundred and "); break;
                            }
                            int secondDigits = (number % 100);
                            if (secondDigits >= 0 && secondDigits < 21)
                            {
                                switch (secondDigits)
                                {
                                    case 1: Console.WriteLine("One"); break;
                                    case 2: Console.WriteLine("Two"); break;
                                    case 3: Console.WriteLine("Three"); break;
                                    case 4: Console.WriteLine("Four"); break;
                                    case 5: Console.WriteLine("Five"); break;
                                    case 6: Console.WriteLine("Six"); break;
                                    case 7: Console.WriteLine("Seven"); break;
                                    case 8: Console.WriteLine("Eight"); break;
                                    case 9: Console.WriteLine("Nine"); break;
                                    case 10: Console.WriteLine("Ten"); break;
                                    case 11: Console.WriteLine("Eleven"); break;
                                    case 12: Console.WriteLine("Twelve"); break;
                                    case 13: Console.WriteLine("Thirteen"); break;
                                    case 14: Console.WriteLine("Fourteen"); break;
                                    case 15: Console.WriteLine("Fifteen"); break;
                                    case 16: Console.WriteLine("Sixteen"); break;
                                    case 17: Console.WriteLine("Seventeen"); break;
                                    case 18: Console.WriteLine("Eighteen"); break;
                                    case 19: Console.WriteLine("Nineteen"); break;
                                    case 20: Console.WriteLine("Twenty"); break;
                                    default: Console.WriteLine("not a number"); break;
                                }
                            }
                            else if (secondDigits > 20 && secondDigits < 100)
                            {
                                if (secondDigits % 10 == 0)
                                {
                                    switch (secondDigits)
                                    {
                                        case 30: Console.WriteLine("Thirty"); break;
                                        case 40: Console.WriteLine("Forty"); break;
                                        case 50: Console.WriteLine("Fifty"); break;
                                        case 60: Console.WriteLine("Sixty"); break;
                                        case 70: Console.WriteLine("Seventy"); break;
                                        case 80: Console.WriteLine("Eighty"); break;
                                        case 90: Console.WriteLine("Ninety"); break;
                                    }
                                }
                                else
                                {
                                    if (secondDigits > 20 && secondDigits < 30)
                                    {
                                        Console.Write("Twenty ");
                                    }
                                    else if (secondDigits > 30 && secondDigits < 40)
                                    {
                                        Console.Write("Thirty ");
                                    }
                                    else if (secondDigits > 40 && secondDigits < 50)
                                    {
                                        Console.Write("Forty ");
                                    }
                                    else if (secondDigits > 50 && secondDigits < 60)
                                    {
                                        Console.Write("Fifty ");
                                    }
                                    else if (secondDigits > 60 && secondDigits < 70)
                                    {
                                        Console.Write("Sixty ");
                                    }
                                    else if (secondDigits > 70 && secondDigits < 80)
                                    {
                                        Console.Write("Seventy ");
                                    }
                                    else if (secondDigits > 80 && secondDigits < 90)
                                    {
                                        Console.Write("Eighty ");
                                    }
                                    else if (secondDigits > 90 && secondDigits < 100)
                                    {
                                        Console.Write("Ninety ");
                                    }
                                    int thirdDigit = number % 10;
                                    switch (thirdDigit)
                                    {
                                        case 1: Console.WriteLine("One"); break;
                                        case 2: Console.WriteLine("Two"); break;
                                        case 3: Console.WriteLine("Three"); break;
                                        case 4: Console.WriteLine("Four"); break;
                                        case 5: Console.WriteLine("Five"); break;
                                        case 6: Console.WriteLine("Six"); break;
                                        case 7: Console.WriteLine("Seven"); break;
                                        case 8: Console.WriteLine("Eight"); break;
                                        case 9: Console.WriteLine("Nine"); break;
                                        default: Console.WriteLine("not a number"); break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
