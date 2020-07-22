using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Polygonum class and working with it.
    /// </summary>
    public class Polygonum : Figure
    {
        /// <summary>
        /// An array of coordinates.
        /// </summary>
        public Point[] Points { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="points">An array of coordinates.</param>
        public Polygonum(Point[] points)
        {
            Points = points;
        }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="figure">A Figure object.</param>
        public Polygonum(Figure figure)
        {
            if (CalculateSquare() > figure.CalculateSquare())
                throw new Exception("It's not possible to cut a figure from this one.");
        }

        /// <summary>
        /// Method for calculating perimeter.
        /// </summary>
        /// <returns>Perimeter of polygonum.</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < Points.Length - 1; i++)
            {
                perimeter += Points[i].DistanceTo(Points[i + 1]);
            }
            perimeter += Points[Points.Length - 1].DistanceTo(Points[0]);
            return perimeter;
        }

        /// <summary>
        /// Method for calculating square.
        /// </summary>
        /// <returns>Square of polygonum.</returns>
        public override double CalculateSquare()
        {
            double square = 0;
            for (int i = 0; i < Points.Length - 1; i++)
            {
                square += Points[i].Square(Points[i + 1]);
            }
            square += Points[Points.Length - 1].Square(Points[0]);
            return Math.Abs(square);
        }

        /// <summary>
        /// Overriden method to output a string with the characteristics of the figure.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            string result = "Polygonum : ";
            for (int i = 0; i < Points.Length; i++)
            {
                result += "Side " + (i + 1) + ": " + "x = " + Convert.ToString(Points[i].X) + "y = " + Convert.ToString(Points[i].Y) + "\n";
            }
            result += " S = " + Convert.ToString(CalculateSquare()) + " P = " + Convert.ToString(CalculatePerimeter());
            return result;
        }

        /// <summary>
        /// A method that determines whether two object instances are equal.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equals, and false if they are not.</returns>
        public override bool Equals(object obj)
        {
            return obj is Polygonum polygonum &&
                   EqualityComparer<Point[]>.Default.Equals(Points, polygonum.Points);
        }

        /// <summary>
        /// The method that the object hashcode will define.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            return 480822998 + EqualityComparer<Point[]>.Default.GetHashCode(Points);
        }
    }
}
