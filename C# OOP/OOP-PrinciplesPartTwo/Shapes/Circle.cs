
namespace Shapes
{
    using System;
    public class Circle : Shape
    {
        public Circle(double width, double height)
            : base(width, width)
        {

        }

        protected override double CalculateSurface()
        {
            double surface = Math.PI * Math.Pow(this.width, 2);
            return surface;
        }

        public override double GetSurface()
        {
            return CalculateSurface();
        }
    }
}
