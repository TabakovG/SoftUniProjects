using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExercises
{
    internal class Box
    {
        private double length;

        public double Length
        {
            get { return length; }
            private set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
            }
        }
        private double width;

        public double Width
        {
            get { return width; }
            private set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }
        private double height;

        public double Height
        {
            get { return height; }
            private set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double SurfaceArea()
        {
            return 2 * ((this.length * this.Width) + (this.Width * this.height) + (this.length * this.height));
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.height * (this.length + this.width);
        }
        public double Volume()
        {
            return this.length * this.width * this.height;
        }
    }
}
