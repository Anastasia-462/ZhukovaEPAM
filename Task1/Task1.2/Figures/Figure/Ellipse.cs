using System;

namespace Figures
{
    /// <summary>
    /// Class of the ellipse figure.
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
        /// Method to find perimeter of the ellipse.
        /// </summary>
        /// <returns>A double value of the perimeter.</returns>
        public override double CalcP()
        {
            return 4 * (Math.PI * DiagonalA * DiagonalB + (DiagonalA - DiagonalB)) / (DiagonalA + DiagonalB);
        }

        /// <summary>
        /// Method to find square of the ellipse.
        /// </summary>
        /// <returns>A double value of the square.</returns>
        public override double CalcS()
        {
            return Math.PI * DiagonalA * DiagonalB;
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A string with values of the square and perimeter.</returns>
        public override string ToString()
        {
            return "Ellipse : DiagonalA = " + Convert.ToString(DiagonalA) + "DiagonalB = " + Convert.ToString(DiagonalB) +
                " S = " + Convert.ToString(CalcS()) + " P = " + Convert.ToString(CalcP());
        }

        /// <summary>
        /// Overriden method GetHashCode.
        /// </summary>
        /// <returns>A hashcode.</returns>
        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + DiagonalA.GetHashCode();
            hashCode = hashCode * -1521134295 + DiagonalB.GetHashCode();
            return hashCode;
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

            Ellipse ellipse = (Ellipse)obj;
            return (this.DiagonalA == ellipse.DiagonalA && 
                this.DiagonalB == ellipse.DiagonalB);
        }
    }
}
