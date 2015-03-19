
namespace Shapes
{
    using System;
    public abstract class Shape
    {
        protected double width;
        protected double height;

        protected Shape(double initialWidth, double initialHeight)
        {
            this.Width = initialWidth;
            this.Height = initialHeight;
        }
        public virtual double Width
        {
            get
            {
                return this.width;
            }
            protected set
            {
                if (value < 0.1)
                {
                    throw new ArgumentException("Invalid shape width");
                }
                this.width = value;
            }
        }

        public virtual double Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value < 0.1)
                {
                    throw new ArgumentException("Invalid shape height");
                }
                this.height = value;
            }
        }

        public virtual double GetSurface()
        {
            return this.width * this.height;
        }
        protected abstract double CalculateSurface();
    }
}
