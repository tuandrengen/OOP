using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class Circle
    {
        public double centerX { get; set; }
        public double centerY { get; set; }
        public double radius { get; set; }

        public Circle(double centerX, double centerY, double radius)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
        }

        public bool IsInside(Circle circle, double x, double y)
        {
            return Math.Pow(x - circle.centerX, 2) + Math.Pow(y - circle.centerY, 2) < Math.Pow(radius, 2);
        }

        //public bool IsOverlapping(Circle x, Circle y)
        //{
        //    return Math.Pow(x.radius - y.radius, 2) <= Math.Pow(x.centerX - y.centerX, 2) + Math.Pow(x.centerY - y.centerY, 2);
        //}
    }
}
