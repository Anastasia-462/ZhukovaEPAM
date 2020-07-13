using System;

namespace Figures
{
    /// <summary>
    /// Class of the rhombus figure.
    /// </summary>
    public class Rhombus : Figure
    {
        /// <summary>
        /// The first diagonal of rhombus.
        /// </summary>
        public double DiagonalA { get; set; }

        /// <summary>
        /// The second diagonal of rhombus.
        /// </summary>
        public double DiagonalB { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="diagonalA">A double number.</param>
        /// <param name="diagonalB">A double number.</param>
        public Rhombus(double diagonalA, double diagonalB)
        {
            DiagonalA = diagonalA;
            DiagonalB = diagonalB;
        }

        /// <summary>
        /// Method to find perimeter of the rhombus.
        /// </summary>
        /// <returns>A double value of the perimeter.</returns>
        public override double CalcP()
        {
            return 4 * Math.Sqrt(0.5 * Math.Pow(DiagonalA, 2) + 0.5 * Math.Pow(DiagonalB, 2));
        }

        /// <summary>
        /// Method to find square of the rhombus.
        /// </summary>
        /// <returns>A double value of the square.</returns>
        public override double CalcS()
        {
            return 0.5 * DiagonalA * DiagonalB;
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A string with values of the square and perimeter.</returns>
        public override string ToString()
        {
            return "Rhombus : DiagonalA = " + Convert.ToString(DiagonalA) + "DiagonalB = " + Convert.ToString(DiagonalB) +
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

            Rhombus rhombus = (Rhombus)obj;
            return (this.DiagonalA == rhombus.DiagonalA &&
                this.DiagonalB == rhombus.DiagonalB);
        }
    }
}
