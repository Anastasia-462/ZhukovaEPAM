using System;

namespace Figures
{
    /// <summary>
    /// Class of the trapeze figure.
    /// </summary>
    public class Trapeze : Figure
    {
        /// <summary>
        /// The first side of trapeze.
        /// </summary>
        double SideA { get; set; }

        /// <summary>
        /// The second side of trapeze.
        /// </summary>
        double SideB { get; set; }

        /// <summary>
        /// The third side of trapeze.
        /// </summary>
        double SideC { get; set; }

        /// <summary>
        /// The forth side of trapeze.
        /// </summary>
        double SideD { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="sideA">A double number.</param>
        /// <param name="sideB">A double number.</param>
        /// <param name="sideC">A double number.</param>
        /// <param name="sideD">A double number.</param>
        public Trapeze(double sideA, double sideB, double sideC, double sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }

        /// <summary>
        /// Method to find perimeter of the trapeze.
        /// </summary>
        /// <returns>A double value of the perimeter.</returns>
        public override double CalcP()
        {
            return SideA + SideB + SideC + SideD;
        }

        /// <summary>
        /// Method to find square of the trapeze.
        /// </summary>
        /// <returns>A double value of the square.</returns>
        public override double CalcS()
        {
            return (SideA + SideB) / 2 * Math.Sqrt(Math.Pow(SideC, 2) - Math.Pow((Math.Pow(SideB - SideA, 2) +
                Math.Pow(SideC, 2) - Math.Pow(SideD, 2)) / 2 * (SideB - SideA), 2));
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A string with values of the square and perimeter.</returns>
        public override string ToString()
        {
            return "Trapeze : SideA = " + Convert.ToString(SideA) + "SideB = " + Convert.ToString(SideB) +
                "SideC = " + Convert.ToString(SideC) + "SideD = " + Convert.ToString(SideD) +
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
            hashCode = hashCode * -1521134295 + SideC.GetHashCode();
            hashCode = hashCode * -1521134295 + SideD.GetHashCode();
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

            Trapeze trapeze = (Trapeze)obj;
            return (this.SideA == trapeze.SideA &&
                this.SideB == trapeze.SideB &&
                this.SideC == trapeze.SideC &&
                this.SideD == trapeze.SideD);
        }
    }
}

