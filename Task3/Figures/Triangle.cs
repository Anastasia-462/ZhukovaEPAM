using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Triangle class and working with it.
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// The first side of triangle.
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// The second side of triangle.
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// The third side of triangle.
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="a">A double number.</param>
        /// <param name="b">A double number.</param>
        /// <param name="c">A double number.</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="figure">A Figure object.</param>
        public Triangle(Figure figure)
        {
            if (CalculateSquare() > figure.CalculateSquare())
                throw new Exception("It's not possible to cut a figure from this one.");
        }

        /// <summary>
        /// Method for calculating perimeter.
        /// </summary>
        /// <returns>Perimeter of triangle.</returns>
        public override double CalculatePerimeter()
        {
            return A + B + C;
        }

        /// <summary>
        /// Method for calculating square.
        /// </summary>
        /// <returns>Square of triangle.</returns>
        public override double CalculateSquare()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        /// <summary>
        /// Overriden method to output a string with the characteristics of the figure.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return "Triangle : SideA = " + Convert.ToString(A) + " SideB = " + Convert.ToString(B) +
                " SideC = " + Convert.ToString(C) + " S = " + Convert.ToString(CalculateSquare()) +
                " P = " + Convert.ToString(CalculatePerimeter());
        }

        /// <summary>
        /// A method that determines whether two object instances are equal.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equals, and false if they are not.</returns>
        public override bool Equals(object obj)
        {
            return obj is Triangle triangle &&
                   A == triangle.A &&
                   B == triangle.B &&
                   C == triangle.C;
        }

        /// <summary>
        /// The method that the object hashcode will define.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            int hashCode = 793064651;
            hashCode = hashCode * -1521134295 + A.GetHashCode();
            hashCode = hashCode * -1521134295 + B.GetHashCode();
            hashCode = hashCode * -1521134295 + C.GetHashCode();
            return hashCode;
        }
    }
}
