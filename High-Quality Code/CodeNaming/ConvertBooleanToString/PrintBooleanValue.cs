////Refactor the following examples to produce code with well-named C# identifiers://
////Task1//
namespace PrintBooleanValue
{
    using System;

    public class PrintBooleanValue
    {
        private const int MAXCOUNT = 6;

        private static void Main()
        {
            PrintBooleanValue.PrintToString value = new PrintBooleanValue.PrintToString();
            value.Print(true);
        }

        private class PrintToString
        {
            public void Print(bool variable)
            {
                string variableToString = variable.ToString();
                Console.WriteLine(variableToString);
            }
        }    
    }
}
