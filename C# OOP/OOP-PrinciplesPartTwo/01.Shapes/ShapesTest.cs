/*Problem 1. Shapes

    Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
    Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
    Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.
*/

namespace _01.ShapesTest
{
    using System;
    using System.Collections.Generic;
    using Shapes;
    class ShapesTest
    {
        static void Main()
        {
            Random rand = new Random();
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < 5; i++)
            {
                Triangle triangle = new Triangle((double)rand.Next(1,20),(double)rand.Next(1,20));
                shapes.Add(triangle);
            }

            for (int i = 0; i < 5; i++)
            {
                Rectangle rectangle = new Rectangle((double)rand.Next(1, 20), (double)rand.Next(1, 20));
                shapes.Add(rectangle);
            }

            for (int i = 1; i <= 5; i++)
            {
                Circle circle = new Circle(i,i);
                shapes.Add(circle);
            }

            foreach (var shape in shapes)
            {
                string type = shape.GetType().Name;
                Console.WriteLine("{0}, surface - {1}", type, shape.GetSurface());
            }
        }
    }
}
