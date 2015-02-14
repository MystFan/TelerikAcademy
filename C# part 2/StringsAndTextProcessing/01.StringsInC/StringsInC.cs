/*
 Problem 1. Strings in C

    Describe the strings in C#.
    What is typical for the string data type?
    Describe the most important methods of the String class.
 */
namespace _01.StringsInC
{
    using System;
    class StringsInC
    {
        static void Main()
        {
            string text = @"A string is an object of type String whose value is text. 
Internally, the text is stored as a sequential read-only collection of Char objects. 
There is no null-terminating character at the end of a C# string; 
therefore a C# string can contain any number of embedded null characters ('\0'). 
The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters.\n 
Most important methods
string.Compare()\n;
string.Equals()\n;
string.IndexOf()\n;
string.LastIndexOf()\n;
string.Substring()\n;
string.Split()\n;
string.Replace()\n;
string.Remove()\n;
string.ToLower()\n;
string.ToUpper()\n;
String.Format()\n;";
            Console.WriteLine(text);
        }
    }
}
