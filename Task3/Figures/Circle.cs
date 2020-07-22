using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Circle class and working with it.
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Radius of circle.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="radius">A double number.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Method for calculating perimeter.
        /// </summary>
        /// <returns>Perimeter of circle.</returns>
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        /// <summary>
        /// Method for calculating square.
        /// </summary>
        /// <returns>Square of circle.</returns>
        public override double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Overriden method to output a string with the characteristics of the figure.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return "Circle : R = " + Convert.ToString(Radius) + "S = " + Convert.ToString(CalculateSquare()) + " P = " + Convert.ToString(CalculatePerimeter());
        }


        /// <summary>
        /// A method that determines whether two object instances are equal.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equals, and false if they are not.</returns>
        public override bool Equals(object obj)
        {
            return obj is Circle circle &&
                   Radius == circle.Radius;
        }

        /// <summary>
        /// The method that the object hashcode will define.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            return 598075851 + Radius.GetHashCode();
        }
    }
}
