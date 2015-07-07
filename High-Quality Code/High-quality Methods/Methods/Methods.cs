namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
            {
                throw new ArgumentException("Can not form a triangle.Each side must be less than the sum of the other two.");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            return area;
        }

        public static string DigitAsString(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Parameter should be digit not a number");
            }
        }

        public static int GetMaxNumber(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException("The collection of numbers is null");
            }

            if (numbers.Length == 0)
            {
                throw new ArgumentException("Collection is empty.");
            }

            int maxNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }

        public static string FormatNumber(object number, string format)
        {
            string result = string.Empty;
            if (format == "f")
            {
                result = string.Format("{0:f2}", number);
            }
            else if (format == "%")
            {
                result = string.Format("{0:p0}", number);
            }
            else if (format == "r")
            {
                result = string.Format("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Invalid string format");
            }

            return result;
        }

        public static void PrintNumber(object number)
        {
            Console.WriteLine(number);
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static bool IsVerticalLine(double x1, double x2)
        {
            bool isVertical = x1 == x2;
            return isVertical;
        }

        public static bool IsHorizontalLine(double y1, double y2)
        {
            bool isHorizontal = y1 == y2;
            return isHorizontal;
        }

        public static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(DigitAsString(5));

            Console.WriteLine(GetMaxNumber(5, -1, 3, 2, 14, 2, 3));

            PrintNumber(FormatNumber(1.3, "f"));
            PrintNumber(FormatNumber(0.75, "%"));
            PrintNumber(FormatNumber(2.30, "r"));

            Point firstPoint = new Point(3, -1);
            Point secondPoint = new Point(3, 2.5);
            bool horizontal = IsHorizontalLine(firstPoint.X, secondPoint.X);
            bool vertical = IsVerticalLine(firstPoint.Y, secondPoint.Y);
            Console.WriteLine(CalculateDistance(firstPoint.X, firstPoint.Y, secondPoint.X, secondPoint.Y));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov");
            peter.BirthDay = DateTime.Parse("17.03.1992");

            Student stella = new Student("Stella", "Markova");
            stella.BirthDay = DateTime.Parse("03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
