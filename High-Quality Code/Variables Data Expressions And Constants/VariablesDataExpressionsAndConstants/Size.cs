namespace VariablesDataExpressionsAndConstants
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double initializeWidth, double initializeHeight)
        {
            this.Width = initializeWidth;
            this.Height = initializeHeight;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width should be greater by zero");
                }

                this.width = value;
            }
        }

        public double Height 
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height should be greater by zero");
                }

                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size size, double angleOfTheFigureThatWillBeRotaed)
        {
            double newWidth = (Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * size.Width) +
                           (Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * size.Height);
            double newHeight = (Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * size.Width) +
                           (Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * size.Height);
            Size newSize = new Size(newWidth, newHeight);
            return newSize;
        }
    }
}
