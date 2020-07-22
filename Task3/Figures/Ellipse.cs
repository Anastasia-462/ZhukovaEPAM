using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Ellipse class and working with it.
    /// </summary>
    public class Ellipse : Figure
    {
        /// <summary>
        /// The first diagonal of ellipse.
        /// </summary>
        public double DiagonalA { get; set; }

        /// <summary>
        /// The second diagonal of ellipse.
        /// </summary>
        public double DiagonalB { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="diagonalA">A double number.</param>
        /// <param name="diagonalB">A double number.</param>
        public Ellipse(double diagonalA, double diagonalB)
        {
            DiagonalA = diagonalA;
            DiagonalB = diagonalB;
        }

        /// <summary>
        /// Method for calculating perimeter.
        /// </summary>
        /// <returns>Perimeter of ellipse.</returns>
        public override double CalculatePerimeter()
        {
            return 4 * (Math.PI * DiagonalA * DiagonalB + (DiagonalA - DiagonalB)) / (DiagonalA + DiagonalB);
        }

        /// <summary>
        /// Method for calculating square.
        /// </summary>
        /// <returns>Square of ellipse.</returns>
        public override double CalculateSquare()
        {
            return Math.PI * DiagonalA * DiagonalB;
        }

        /// <summary>
        /// Overriden method to output a string with the characteristics of the figure.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return "Ellipse : DiagonalA = " + Convert.ToString(DiagonalA) + "DiagonalB = " + Convert.ToString(DiagonalB) +
                " S = " + Convert.ToString(CalculateSquare()) + " P = " + Convert.ToString(CalculatePerimeter());
        }

        /// <summary>
        /// A method that determines whether two object instances are equal.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equals, and false if they are not.</returns>
        public override bool Equals(object obj)
        {
            return obj is Ellipse ellipse &&
                   DiagonalA == ellipse.DiagonalA &&
                   DiagonalB == ellipse.DiagonalB;
        }

        /// <summary>
        /// The method that the object hashcode will define.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            int hashCode = 33704049;
            hashCode = hashCode * -1521134295 + DiagonalA.GetHashCode();
            hashCode = hashCode * -1521134295 + DiagonalB.GetHashCode();
            return hashCode;
        }
    }
}
