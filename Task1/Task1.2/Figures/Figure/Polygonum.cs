using System;

namespace Figures
{
    /// <summary>
    /// Class of the polygonum figure.
    /// </summary>
    public class Polygonum : Figure
    {
        /// <summary>
        /// Array of coordinates.
        /// </summary>
        public Point[] Points { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="points">Array of coordinates.</param>
        public Polygonum(Point[] points)
        {
            Points = points;
        }

        /// <summary>
        /// Method to find perimeter of the polygonum.
        /// </summary>
        /// <returns>A double value of the perimeter.</returns>
        public override double CalcP()
        {
            double perimeter = 0;
            for (int i = 0; i < Points.Length - 1; i++)
            {
                perimeter += Points[i].DistanceTo(Points[i + 1]);
            }
            perimeter += Points[Points.Length - 1].DistanceTo(Points[0]);
            return perimeter;
        }

        /// <summary>
        /// Method to find square of the polygonum.
        /// </summary>
        /// <returns>A double value of the square.</returns>
        public override double CalcS()
        {
            double square = 0;
            for (int i = 0; i < Points.Length - 1; i++)
            {
                square += Points[i].Square(Points[i + 1]);
            }
            square += Points[Points.Length - 1].Square(Points[0]);
            return Math.Abs(square);
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A string with values of the square and perimeter.</returns>
        public override string ToString()
        {
            string result = "Polygonum : ";
            for (int i = 0; i < Points.Length; i++)
            {
                result += "Side " + (i + 1) + ": " + "x = " + Convert.ToString(Points[i].X) + "y = " + Convert.ToString(Points[i].Y) + "\n";
            }
            result += " S = " + Convert.ToString(CalcS()) + " P = " + Convert.ToString(CalcP());
            return result;
        }

        /// <summary>
        /// Overriden method GetHashCode.
        /// </summary>
        /// <returns>A hashcode.</returns>
        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            for(int i = 0; i < Points.Length; i++)
            {
                hashCode = hashCode * -1521134295 + Points[i].GetHashCode();
            }
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

            Polygonum polygonum = (Polygonum)obj;
            int amount = 0;
            for (int i = 0; i < Points.Length; i++)
            {
                if(this.Points[i] == polygonum.Points[i])
                {
                    amount++;
                }
            }
            return (amount == Points.Length);
        }
    }
}
