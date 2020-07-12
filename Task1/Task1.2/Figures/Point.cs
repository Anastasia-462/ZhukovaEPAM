using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point point)
        {
            return X == point.X &&
                Y == point.Y;
        }

        public double DistanceTo(Point point)
        {
            double d = (X - point.X) * (X - point.X) +
            (Y - point.Y) * (Y - point.Y);
            return Math.Sqrt(d);
        }

        public double Square(Point point)
        {
            return (X + point.X) * (point.Y - Y) / 2;
        }
    }
}
