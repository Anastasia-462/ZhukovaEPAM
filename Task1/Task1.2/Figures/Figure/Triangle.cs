using System;

namespace Figures
{
    /// <summary>
    /// Class of the triangle figure.
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// The first side of triangle.
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// The second side of triangle.
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// The thirdside of triangle.
        /// </summary>
        public double SideC { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="sideA">A double number.</param>
        /// <param name="sideB">A double number.</param>
        /// <param name="sideC">A double number.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Method to find perimeter of the triangle.
        /// </summary>
        /// <returns>A double value of the perimeter.</returns>
        public override double CalcP()
        {
            return SideA + SideB + SideC;
        }

        /// <summary>
        /// Method to find square of the triangle.
        /// </summary>
        /// <returns>A double value of the square.</returns>
        public override double CalcS()
        {
            double p = CalcP() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A string with values of the square and perimeter.</returns>
        public override string ToString()
        {
            return "Triangle : SideA = " + Convert.ToString(SideA) + "SideB = " + Convert.ToString(SideB) +
                "SideC = " + Convert.ToString(SideC) + " S = " + Convert.ToString(CalcS()) +
                " P = " + Convert.ToString(CalcP());
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
            hashCode = hashCode * -1521134295 + SideC.GetHashCode();
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

            Triangle triangle = (Triangle)obj;
            return (this.SideA == triangle.SideA &&
                this.SideB == triangle.SideB &&
                this.SideC == triangle.SideC);
        }
    }
}
