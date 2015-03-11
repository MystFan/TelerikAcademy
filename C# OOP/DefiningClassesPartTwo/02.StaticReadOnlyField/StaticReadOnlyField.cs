/*Problem 2. Static read-only field

    Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
    Add a static property to return the point O.
*/
namespace _02.StaticReadOnlyField
{
    using System;
    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);
        private double x;
        private double y;
        private double z;
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X
        {
            get
            {
                return this.x;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
        }
        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }
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
            PrintAtPosition((int)Math.Abs(40 - x), (int)Math.Abs(40 - y), '@');
            Console.SetCursorPosition(0, 40);
            return "";
        }

        private void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

    }
    class StaticReadOnlyField
    {
        static void Main()
        {
        }
    }
}
