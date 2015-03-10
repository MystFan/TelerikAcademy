using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Properties
{
    public class Display
    {
        private double size;
        private int numberOfColors;
        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        public double Size 
        {
            get
            {
                return this.size;
            }
            private set
            {
                this.size = value;
            } 
        }
        public int NumberOfColors 
        {
            get
            {
                return this.numberOfColors;
            }
            private set
            {
                this.numberOfColors = value;
            } 
        }
    }
}
