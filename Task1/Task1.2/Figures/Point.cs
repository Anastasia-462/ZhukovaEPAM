using System;

namespace Figures
{
    /// <summary>
    /// Class coordinaates in the plane.
    /// </summary>
    public class Point
    {
        /// <summary>
        /// The X coordinate.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// The Y coordinate.
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
        /// Method to find the distance between points.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public double DistanceTo(Point point)
        {
            double d = (X - point.X) * (X - point.X) +
            (Y - point.Y) * (Y - point.Y);
            return Math.Sqrt(d);
        }

        /// <summary>
        /// Method to calculate distance to find the square.
        /// </summary>
        /// <param name="point">A Point value - coordinate.</param>
        /// <returns>Distance to find the square.</returns>
        public double Square(Point point)
        {
            return (X + point.X) * (point.Y - Y) / 2;
        }

        /// <summary>
        /// Method that checks equality.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if the objects are equal and false in the opposite case.</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Point point = (Point)obj;
            return X == point.X && Y == point.Y;
        }

        /// <summary>
        /// Overriden method GetHashCode.
        /// </summary>
        /// <returns>A hashcode.</returns>
        public override int GetHashCode()
        {
            int hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }
    }
}
