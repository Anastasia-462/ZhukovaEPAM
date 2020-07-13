using System;

namespace Figures
{
    /// <summary>
    /// Class of the circle figure.
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
        /// Method to find perimeter of the circle.
        /// </summary>
        /// <returns>A double value of the perimeter.</returns>
        public override double CalcP()
        {
            return 2 * Math.PI * Radius;
        }

        /// <summary>
        /// Method to find square of the circle.
        /// </summary>
        /// <returns>A double value of the square.</returns>
        public override double CalcS()
        {
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A string with values of the square and perimeter.</returns>
        public override string ToString()
        {
            return "Circle : R = " + Convert.ToString(Radius) + " S = " + Convert.ToString(CalcS()) + " P = " + Convert.ToString(CalcP());
        }

        /// <summary>
        /// Overriden method GetHashCode.
        /// </summary>
        /// <returns>A hashcode.</returns>
        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Radius.GetHashCode();
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

            Circle circle = (Circle)obj;
            return (this.Radius == circle.Radius);
        }
    }
}
