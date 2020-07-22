using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Coordinates class.
    /// </summary>
    public class Point : IEquatable<Point>
    {
        /// <summary>
        /// Coordinate X.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Coordinate Y.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="x">A double number.</param>
        /// <param name="y">A double number.</param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// A method that determines whether two object instances are equal.
        /// </summary>
        /// <param name="point">A Point value.</param>
        /// <returns>True if objects are equals, and false if they are not.</returns>
        public bool Equals(Point point)
        {
            return X == point.X &&
                Y == point.Y;
        }

        /// <summary>
        /// Method to calculate distance between two points.
        /// </summary>
        /// <param name="point">A Point value.</param>
        /// <returns>A double number.</returns>
        public double DistanceTo(Point point)
        {
            double d = (X - point.X) * (X - point.X) +
            (Y - point.Y) * (Y - point.Y);
            return Math.Sqrt(d);
        }

        /// <summary>
        /// Method for calculating the half-sum of coordinates to find the square.
        /// </summary>
        /// <param name="point">A Point value.</param>
        /// <returns>A double number.</returns>
        public double Square(Point point)
        {
            return (X + point.X) * (point.Y - Y) / 2;
        }
    }
}
