using System;

namespace Figures
{
    /// <summary>
    /// Class of the square figure.
    /// </summary>
    public class Square : Figure
    {
        /// <summary>
        /// The side of square.
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="sideA">A double number.</param>
        public Square(double sideA)
        {
            this.SideA = sideA;
        }

        /// <summary>
        /// Method to find perimeter of the square.
        /// </summary>
        /// <returns>A double value of the perimeter.</returns>
        public override double CalcP()
        {
            return 4 * SideA;
        }

        /// <summary>
        /// Method to find area of the square.
        /// </summary>
        /// <returns>A double value of the square.</returns>
        public override double CalcS()
        {
            return SideA * SideA;
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A string with values of the square and perimeter.</returns>
        public override string ToString()
        {
            return "Square : SideA = " + Convert.ToString(SideA) +
                " S = " + Convert.ToString(CalcS()) + " P = " + Convert.ToString(CalcP());
        }

        /// <summary>
        /// Overriden method GetHashCode.
        /// </summary>
        /// <returns>A hashcode.</returns>
        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + SideA.GetHashCode();
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

            Square square = (Square)obj;
            return (this.SideA == square.SideA);
        }
    }
}
