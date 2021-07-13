using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : IDrawable
    {

        public int Radius { get; private set; }

        public Circle(int radius)
        {
            this.Radius = radius;
        }
        public void Draw()
        {
            double rIn = this.Radius - 0.4;
            double rOut = this.Radius + 0.4;

            for (int y = this.Radius; y >= -this.Radius; --y)
            {
                for (double i = -this.Radius; i < rOut; i += 0.5)
                {
                    double value = i * i + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
