
namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }
        protected override double CalculateSurface()
        {
            double surface = this.width * this.height;
            return surface;
        }

        public override double GetSurface()
        {
            return this.CalculateSurface();
        }
    }
}
