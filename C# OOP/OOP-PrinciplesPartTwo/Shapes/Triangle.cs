
namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {

        }

        protected override double CalculateSurface()
        {
            double surface = (this.width * this.height) / 2;
            return surface;
        }

        public override double GetSurface()
        {
            return this.CalculateSurface();
        }
    }
}
