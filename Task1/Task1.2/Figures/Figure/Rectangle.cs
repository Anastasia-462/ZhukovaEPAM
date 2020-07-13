using System;

namespace Figures
{
    /// <summary>
    /// Class of the rectangle figure.
    /// </summary>
    public class Rectangle : Figure
    {
        /// <summary>
        /// The first side of rectangle.
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// The second side of rectangle.
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="sideA">A double number.</param>
        /// <param name="sideB">A double number.</param>
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        /// <summary>
        /// Method to find perimeter of the rectangle.
        /// </summary>
        /// <returns>A double value of the perimeter.</returns>
        public override double CalcP()
        {
            return 2 * (SideA + SideB);
        }

        /// <summary>
        /// Method to find square of the rectangle.
        /// </summary>
        /// <returns>A double value of the square.</returns>
        public override double CalcS()
        {
            return SideA * SideB;
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A string with values of the square and perimeter.</returns>
        public override string ToString()
        {
            return "Rectangle : SideA = " + Convert.ToString(SideA) + "SideB = " + Convert.ToString(SideB) +
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
            hashCode = hashCode * -1521134295 + SideB.GetHashCode();
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

            Rectangle rectangle = (Rectangle)obj;
            return (this.SideA == rectangle.SideA &&
                this.SideB == rectangle.SideB);
        }
    }
}
