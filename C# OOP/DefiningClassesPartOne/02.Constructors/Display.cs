﻿
namespace _02.Constructors
{
    public class Display
    {
        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        public double Size { get; set; }
        public int NumberOfColors { get; set; }
    }
}
