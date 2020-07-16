using System.Collections.Generic;

namespace Polynomials
{
    /// <summary>
    /// Class for working with polynomials.
    /// </summary>
    public class Polynomial
    {
        /// <summary>
        /// Maximum degree of polynomial.
        /// </summary>
        public int Degree { get; set; }

        /// <summary>
        /// Array of coefficients of polynomial.
        /// </summary>
        public double[] Coefficients { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="coeff">A double array.</param>
        /// <param name="degree">An int number.</param>
        public Polynomial(double[] coeff, int degree)
        {
            Coefficients = coeff;
            Degree = degree;
        }

        /// <summary>
        /// Overriden operation is equal.
        /// </summary>
        /// <param name="p1">A Polynomial value.</param>
        /// <param name="p2">A Polynomial value.</param>
        /// <returns>True if polynomials are equal, false in the opposite case.</returns>
        public static bool operator ==(Polynomial p1, Polynomial p2)
        {
            int flag = 0;
            if (p1.Degree == p2.Degree)
            {
                for (int i = 0; i < p1.Coefficients.Length; i++)
                    if (p1.Coefficients[i] == p2.Coefficients[i])
                        flag++;
                if (flag == p1.Coefficients.Length)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Overriden operation is not equal.
        /// </summary>
        /// <param name="p1">A Polynomial value.</param>
        /// <param name="p2">A Polynomial value.</param>
        /// <returns>True if polynomials are not equal, false in the opposite case.</returns>
        public static bool operator !=(Polynomial p1, Polynomial p2)
        {
            int flag = 0;
            if (p1.Degree == p2.Degree)
            {
                for (int i = 0; i < p1.Coefficients.Length; i++)
                    if (p1.Coefficients[i] == p2.Coefficients[i])
                        flag++;
                if (flag == p1.Coefficients.Length)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Overriden operation is additions.
        /// </summary>
        /// <param name="p1">A Polynomial value.</param>
        /// <param name="p2">A Polynomial value.</param>
        /// <returns>New object of the class Polynomial.</returns>
        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            double[] coeff;
            if(p1.Degree > p2.Degree)
            {
                coeff = new double[p1.Degree + 1];
                for (int i = 0; i <= p2.Degree; i++)
                    coeff[i] = p1.Coefficients[i] + p2.Coefficients[i];
                for (int i = p2.Degree + 1; i <= p1.Degree; i++)
                    coeff[i] = p1.Coefficients[i];
                return new Polynomial(coeff, p1.Degree);
            }
            else
            {
                coeff = new double[p2.Degree + 1];
                for (int i = 0; i <= p1.Degree; i++)
                    coeff[i] = p1.Coefficients[i] + p2.Coefficients[i];
                for (int i = p1.Degree + 1; i <= p2.Degree; i++)
                    coeff[i] = p2.Coefficients[i];
                return new Polynomial(coeff, p2.Degree);
            }
        }


        /// <summary>
        /// Overriden operation is differences.
        /// </summary>
        /// <param name="p1">A Polynomial value.</param>
        /// <param name="p2">A Polynomial value.</param>
        /// <returns>New object of the class Polynomial.</returns>
        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            double[] coeff;
            if (p1.Degree > p2.Degree)
            {
                coeff = new double[p1.Degree + 1];
                for (int i = 0; i <= p2.Degree; i++)
                    coeff[i] = p1.Coefficients[i] - p2.Coefficients[i];
                for (int i = p2.Degree + 1; i <= p1.Degree; i++)
                    coeff[i] = p1.Coefficients[i];
                return new Polynomial(coeff, p1.Degree);
            }
            else
            {
                coeff = new double[p2.Degree + 1];
                for (int i = 0; i <= p1.Degree; i++)
                    coeff[i] = p1.Coefficients[i] - p2.Coefficients[i];
                for (int i = p1.Degree + 1; i <= p2.Degree; i++)
                    coeff[i] = 0 - p2.Coefficients[i];
                return new Polynomial(coeff, p2.Degree);
            }
        }


        /// <summary>
        /// Overriden operation is multiplication by a number.
        /// </summary>
        /// <param name="p1">A Polynomial value.</param>
        /// <param name="number">A double number.</param>
        /// <returns>New object of the class Polynomial.</returns>
        public static Polynomial operator *(Polynomial p1, double number)
        {
            double[] coeff = new double[p1.Degree + 1];
            if (number == 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i <= p1.Degree; i++)
                    coeff[i] = p1.Coefficients[i] * number;
                return new Polynomial(coeff, p1.Degree);
            }
        }


        /// <summary>
        /// Overriden operation is dividing it by a number.
        /// </summary>
        /// <param name="p1">A Vector3 value.</param>
        /// <param name="number">A double number.</param>
        /// <returns>New object of the class Polynomial.</returns>
        public static Polynomial operator /(Polynomial p1, double number)
        {
            double[] coeff = new double[p1.Degree + 1];
            if (number == 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i <= p1.Degree; i++)
                    coeff[i] = p1.Coefficients[i] / number;
                return new Polynomial(coeff, p1.Degree);
            }
        }

        //Method to compare polynomials.
        private bool CompareCoefficient(Polynomial p1, Polynomial p2)
        {
            bool flag = true;
            //if (p1.Degree != p2.Degree)
                for (int i = 0; i < p1.Coefficients.Length; i++)
                {
                    if (p1.Coefficients[i] != p2.Coefficients[i])
                        flag = false;
                }
            return flag;
        }
        /// <summary>
        /// Overriden equality operation. 
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if the values are equal, false in the opposite case.</returns>
        public override bool Equals(object obj)
        {
            
            return obj is Polynomial polynomial &&
                   Degree == polynomial.Degree &&
                   CompareCoefficient(this, polynomial);
        }

        /// <summary>
        /// Overriden method which calculates hashcode.
        /// </summary>
        /// <returns>An integer number.</returns>
        public override int GetHashCode()
        {
            int hashCode = 1279902996;
            hashCode = hashCode * -1521134295 + EqualityComparer<double[]>.Default.GetHashCode(Coefficients);
            hashCode = hashCode * -1521134295 + Degree.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A string with the value of the coefficients.</returns>
        public override string ToString()
        {
            string result = "Polynomial : ";
            for (int i = 0; i < Coefficients.Length; i++)
                result += Coefficients[i] + " ";
            return result;
        }
    }
}
