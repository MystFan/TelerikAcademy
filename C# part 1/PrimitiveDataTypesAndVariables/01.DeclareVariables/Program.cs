using System;
/*
 Problem 1. Declare Variables

    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

 */

namespace _01.DeclareVariables
{
    class Program
    {
        static void Main()
        {
            int variableFirstInt = 52130;
            sbyte variableByte = -115;
            int variableSecondInt = 4825932;
            long variableLong = -10000;
            short variableShort = 97;
            Console.WriteLine("Int: {0}",variableFirstInt);
            Console.WriteLine("Byte: {0}", variableByte);
            Console.WriteLine("Int: {0}", variableSecondInt);
            Console.WriteLine("Long: {0}", variableLong);
            Console.WriteLine("Short: {0}", variableShort);
        }
    }
}
