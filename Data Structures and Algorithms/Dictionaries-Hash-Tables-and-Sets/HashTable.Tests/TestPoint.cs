namespace Tests
{
    using System;

    public class TestPoint : IComparable
    {
        public TestPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public override int GetHashCode()
        {
            return this.X.GetHashCode() + this.Y.GetHashCode();
        }

        public bool Equals(TestPoint other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        public int CompareTo(object other)
        {
            TestPoint otherPoint = other as TestPoint;

            if (this.X > otherPoint.X && this.Y > otherPoint.Y)
            {
                return -1;
            }
            else if (this.X < otherPoint.X && this.Y < otherPoint.Y)
            {
                return 1;
            }
            else if (this.X > otherPoint.X && this.Y == otherPoint.Y)
            {
                return -1;
            }
            else if (this.X < otherPoint.X && this.Y == otherPoint.Y)
            {
                return 1;
            }
            else if (this.X == otherPoint.X && this.Y > otherPoint.Y)
            {
                return -1;
            }
            else if (this.X == otherPoint.X && this.Y < otherPoint.Y)
            {
                return 1;
            }

            return 0;
        }

        public override string ToString()
        {
            return "(" + this.X + ", " + this.Y + ")";
        }
    }
}
