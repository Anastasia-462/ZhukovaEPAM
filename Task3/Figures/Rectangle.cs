using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Rectangle class and working with it.
    /// </summary>
    public class Rectangle : Figure
    {
        /// <summary>
        /// The first side of rectangle.
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// The second side of rectangle.
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="a">A double number.</param>
        /// <param name="b">A double number.</param>
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        /// <summary>
        /// Method for calculating perimeter.
        /// </summary>
        /// <returns>Perimeter of rectangle.</returns>
        public override double CalculatePerimeter()
        {
            return 2 * (A + B);
        }

        /// <summary>
        /// Method for calculating square.
        /// </summary>
        /// <returns>Square of rectangle.</returns>
        public override double CalculateSquare()
        {
            return A * B;
        }

        /// <summary>
        /// Overriden method to output a string with the characteristics of the figure.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return "Rectangle : SideA = " + Convert.ToString(A) + "SideB = " + Convert.ToString(B) +
                " S = " + Convert.ToString(CalculateSquare()) + " P = " + Convert.ToString(CalculatePerimeter());
        }

        /// <summary>
        /// A method that determines whether two object instances are equal.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equals, and false if they are not.</returns>
        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle &&
                   A == rectangle.A &&
                   B == rectangle.B;
        }

        /// <summary>
        /// The method that the object hashcode will define.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1817952719;
            hashCode = hashCode * -1521134295 + A.GetHashCode();
            hashCode = hashCode * -1521134295 + B.GetHashCode();
            return hashCode;
        }
    }
}
