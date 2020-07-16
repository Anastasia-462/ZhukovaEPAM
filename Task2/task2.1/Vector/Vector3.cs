using System;

namespace Vectors
{
    /// <summary>
    /// Class for working with a three-dimensional vector.
    /// </summary>
    public class Vector3
    {
        const double ACCURACY = 0.001;

        /// <summary>
        /// Coordinate X of the vector.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Coordinate Y of the vector.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Coordinate Z of the vector.
        /// </summary>
        public double Z { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="x">A double number.</param>
        /// <param name="y">A double number.</param>
        /// <param name="z">A double number.</param>
        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Overriden operation is equal.
        /// </summary>
        /// <param name="v1">A Vector3 value.</param>
        /// <param name="v2">A Vector3 value.</param>
        /// <returns>True if vectors are equal, false in the opposite case.</returns>
        public static bool operator ==(Vector3 v1, Vector3 v2)
        {
            if (Math.Abs(v1.X - v2.X) < ACCURACY)
                if (Math.Abs(v1.Y - v2.Y) < ACCURACY)
                    if (Math.Abs(v1.Z - v2.Z) < ACCURACY)
                        return true;
            return false;
        }

        /// <summary>
        /// Overriden operation is not equal.
        /// </summary>
        /// <param name="v1">A Vector3 value.</param>
        /// <param name="v2">A Vector3 value.</param>
        /// <returns>True if vectors are not equal, false in the opposite case.</returns>
        public static bool operator !=(Vector3 v1, Vector3 v2)
        {
            if (Math.Abs(v1.X - v2.X) < ACCURACY)
                if (Math.Abs(v1.Y - v2.Y) < ACCURACY)
                    if (Math.Abs(v1.Z - v2.Z) < ACCURACY)
                        return false;
            return true;
        }

        /// <summary>
        /// Overriden operation is additions.
        /// </summary>
        /// <param name="v1">A Vector3 value.</param>
        /// <param name="v2">A Vector3 value.</param>
        /// <returns>New object of the class Vector3.</returns>
        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        /// <summary>
        /// Overriden operation is differences.
        /// </summary>
        /// <param name="v1">A Vector3 value.</param>
        /// <param name="v2">A Vector3 value.</param>
        /// <returns>New object of the class Vector3.</returns>
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        /// <summary>
        /// Overriden operation is multiplication by a number.
        /// </summary>
        /// <param name="v1">A Vector3 value.</param>
        /// <param name="number">A double number.</param>
        /// <returns>New object of the class Vector3.</returns>
        public static Vector3 operator *(Vector3 v1, double number)
        {
            return new Vector3(v1.X * number, v1.Y * number, v1.Z * number);
        }

        /// <summary>
        /// Overriden operation is dividing it by a number.
        /// </summary>
        /// <param name="v1">A Vector3 value.</param>
        /// <param name="number">A double number.</param>
        /// <returns>New object of the class Vector3.</returns>
        public static Vector3 operator /(Vector3 v1, double number)
        {
            double number2 = 1.0f / number;
            return new Vector3(v1.X * number2, v1.Y * number2, v1.Z * number2);
        }

        /// <summary>
        /// Overriden operation is scalar multiplication.
        /// </summary>
        /// <param name="v1">A Vector3 value.</param>
        /// <param name="v2">A Vector3 value.</param>
        /// <returns>New object of the class Vector3.</returns>
        public static double operator *(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        /// <summary>
        /// Method that calculates vector multiplication.
        /// </summary>
        /// <param name="v1">A Vector3 value.</param>
        /// <param name="v2">A Vector3 value.</param>
        /// <returns>New object of the class Vector3.</returns>
        public static Vector3 VectorMultiplication(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        /// <summary>
        /// Overriden equality operation. 
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if the values are equal, false in the opposite case.</returns>
        public override bool Equals(object obj)
        {
            return obj is Vector3 vector &&
                   X == vector.X &&
                   Y == vector.Y &&
                   Z == vector.Z;
        }

        /// <summary>
        /// Overriden method which calculates hashcode.
        /// </summary>
        /// <returns>An integer number.</returns>
        public override int GetHashCode()
        {
            int hashCode = -307843816;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            hashCode = hashCode * -1521134295 + Z.GetHashCode();
            return hashCode;
        }
    }
}
