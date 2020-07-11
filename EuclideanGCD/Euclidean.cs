using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanGCD
{
    /// <summary>
    /// A class that implements the Euclidean algorithm for computing GCD.
    /// </summary>
    ///<remarks>
    ///This class can calculate GCD using two algorithms of Euclid.
    ///</remarks>
    public class Euclidean
    {
        int min = -1;
        int mod = 0;
        
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Euclidean() { }

        /// <summary>
        /// This method calculate GCD with the help Euclidean algorithm for two integers. 
        /// </summary>
        /// <param name="a">An integer number.</param>
        /// <param name="b">An integer number.</param>
        /// <returns>The GCD of two integers.</returns>
        public int GCD(int a, int b)
        {
            min = Min(Math.Abs(a), Math.Abs(b));
            mod = Mod(Math.Abs(a), Math.Abs(b));
            if (min == mod)
                return mod;
            else
                return GCD(min, mod);
        }

        private int Min(int a, int b)
        {
            if (a > b)
                min = b;
            else
                min = a;
            return min;
        }

        private int Mod(int a, int b)
        {
            if (a > b)
                mod = a - b;
            else
                mod = b - a;
            return mod;
        }
    }
}
