using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return this.length; }

            private set
            {
                if (value > 0)
                {
                    this.length = value;
                }
                else
                {
                    throw new ArgumentException("Length cannot be zero or negative."); 
                }
            }
        }
        public double Width 
        { 
            get { return this.width; }
            
            private set 
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }
        public double Height 
        { 
            get { return this.height; }
            
            private set 
            {
                if (value > 0)
                {
                    this.height = value;
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

        //Volume = lwh
        public string MultipleVolume() 
        {
            var result = this.Length * this.Width * this.Height;

            StringBuilder sb = new StringBuilder();

            sb.Append($"Volume - {result:F2}");
            return sb.ToString();
        }

        //Lateral Surface Area = 2lh + 2wh
        public string MultipleLateralSurfaceArea() 
        {
            var result = (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

            StringBuilder sb = new StringBuilder();
            sb.Append($"Lateral Surface Area - {result:F2}");

            return sb.ToString();
        }

        //Surface Area = 2lw + 2lh + 2wh
        public string MultipleSurfaceArea() 
        {
            var result = (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

            StringBuilder sb = new StringBuilder();
            sb.Append($"Surface Area - {result:F2}");

            return sb.ToString();
        }


    }
}
