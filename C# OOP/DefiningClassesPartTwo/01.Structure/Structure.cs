/*Problem 1. Structure

    Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
    Implement the ToString() to enable printing a 3D point.
*/

namespace _01.Structure
{
    using System;
    public struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public override string ToString()
        {
            for (int i = 0; i < 40; i++)
            {
                PrintAtPosition(1, 1 + i, '*');
            }
            for (int i = 0; i < 40; i++)
            {
                PrintAtPosition(1 + i, 40, '*');
            }
            PrintAtPosition((int)Math.Abs(40 - X), (int)Math.Abs(40 - Y), '@');
            Console.SetCursorPosition(0, 40);
            return "";
        }

        private void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

    }
    class Structure
    {
        static void Main()
        {
        }
    }
}
