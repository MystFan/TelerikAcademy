namespace Abstraction
{
    using System;

    public class Circle : Figure, IFigure
    {
        private double radius;

        public Circle(double radius)
            : base(2 * radius, 2 * radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Circle radius should be greater than zero");
                }

                this.radius = value;
            }
        }

        public override double Width
        {
            get
            {
                return base.Width;
            }

            set
            {
                base.Width = value;
                this.Radius = base.Width / 2;
            }
        }

        public override double Height
        {
            get
            {
                return base.Height;
            }

            set
            {
                base.Height = value;
                this.Radius = this.Height / 2;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
