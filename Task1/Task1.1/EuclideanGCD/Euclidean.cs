using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        Stopwatch swatch = new Stopwatch();
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Euclidean() { }

        /// <summary>
        /// This method calculate GCD with the help Euclidean algorithm for two integers. 
        /// </summary>
        /// <param name="a">An integer number.</param>
        /// <param name="b">An integer number.</param>
        /// <param name="clock">A TimeSpan number.</param>
        /// <returns>The GCD of two integers numbers.</returns>
        public int GCD(int a, int b, out TimeSpan clock)
        {
            swatch.Start();
            min = Min(Math.Abs(a), Math.Abs(b));
            mod = Mod(Math.Abs(a), Math.Abs(b));
            if (min == mod)
            {
                swatch.Stop();
                clock = swatch.Elapsed;
                return mod;
            }
            else
            {
                swatch.Stop();
                clock = swatch.Elapsed;
                return GCD(min, mod);
            }
        }

        /// <summary>
        /// This method calculate GCD with the help Euclidean algorithm for several integers.
        /// </summary>
        /// <param name="a">An array of integers number.</param>
        /// <returns>The GCD of several integers numbers.</returns>
        public int GCD(params int[] a)
        {
            List<int> mod = Mod(a);
            min = Min(a);
            int max = mod.Count;
            while (max != 1)
            {
                max = mod.Count;
                min = Min(mod);
                mod = Mod(mod);
                if (mod.Count == 2 && mod[0] == mod[1])
                {
                    max--;
                }
            }
            return Min(mod);
        }

        /// <summary>
        /// A method that implements the Stein algorithm (binary Euclidean algorithm)
        /// for calculating the GCD of two integers.
        /// </summary>
        /// <param name="a">An integer number.</param>
        /// <param name="b">An integer number.</param>
        /// <param name="clock">A TimeSpan number.</param>
        /// <returns>The GCD of two integers numbers.</returns>
        public int BinGCD(int a, int b, out TimeSpan clock)
        {
            swatch.Start();
            if (a == 0)
            {
                swatch.Stop();
                clock = swatch.Elapsed;
                return b;
            }
            if (b == 0)
            {
                swatch.Stop();
                clock = swatch.Elapsed;
                return a;
            }

            if (a == b)
            {
                swatch.Stop();
                clock = swatch.Elapsed;
                return a;
            }

            if ((a == 1) || (b == 1))
            {
                swatch.Stop();
                clock = swatch.Elapsed;
                return 1;
            }

            if (a % 2 == 0)
            {
                swatch.Stop();
                return (b % 2 == 0) ? 2 * BinGCD(a / 2, b / 2, out clock) : BinGCD(a / 2, b, out clock);
            }
            else if (a % 2 != 0)
            {
                swatch.Stop();
                return (b % 2 == 0) ? BinGCD(a, b / 2, out clock) : BinGCD(b > a ? (b - a) / 2 : (a - b) / 2,
                    b > a ? a : b, out clock);
            }
            swatch.Stop();
            clock = swatch.Elapsed;
            return 0;
        }

        //This method finds the minimum value for two integers.
        private int Min(int a, int b)
        {
            if (a > b)
                min = b;
            else
                min = a;
            return min;
        }

        //This method calculate difference between two integers.
        private int Mod(int a, int b)
        {
            if (a > b)
                mod = a - b;
            else
                mod = b - a;
            return mod;
        }

        //This method finds the minimum value for several integers.
        //Used for the first iteration in GCD method.
        private int Min(params int[] a)
        {
            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                    min = a[i];
            }
            return min;
        }

        //This method finds the minimum value for several integers.
        //Used for subsequent iteration in GCD method.
        private int Min(List<int> a)
        {
            int min = int.MaxValue;
            for (int i = 0; i < a.Count; i++)
            {
                if (min > a[i])
                    min = a[i];
            }
            return min;
        }

        //This method calculate difference between the number and the minimum value.
        //Used for the first iteration in GCD method.
        private List<int> Mod(params int[] a)
        {
            List<int> mod = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (Math.Abs(Math.Abs(a[i]) - Min(a)) == 0)
                {
                    mod.Add(Min(a));
                }
                else
                    mod.Add(Math.Abs(Math.Abs(a[i]) - Min(a)));
            }
            return mod;
        }

        //This method calculate difference between the number and the minimum value.
        //Used for subsequent iteration in GCD method.
        private List<int> Mod(List<int> a)
        {
            List<int> mod = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                mod.Add(Math.Abs(Math.Abs(a[i]) - Min(a)));
            }
            mod.Add(Min(a));
            mod.RemoveAll(item => item == 0);
            return mod;
        }
    }
}
