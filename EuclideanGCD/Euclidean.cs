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
        /// <param name="number1">An integer number.</param>
        /// <param name="number2">An integer number.</param>
        /// <param name="clock">A TimeSpan number.</param>
        /// <returns>The GCD of two integers numbers.</returns>
        public int GCD(int number1, int number2, out TimeSpan clock)
        {
            swatch.Start();
            min = Min(Math.Abs(number1), Math.Abs(number2));
            mod = Mod(Math.Abs(number1), Math.Abs(number2));
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
        /// <param name="numbers">An array of integers number.</param>
        /// <returns>The GCD of several integers numbers.</returns>
        public int GCD(params int[] numbers)
        {
            List<int> mod = Mod(numbers);
            min = Min(numbers);
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
        /// <param name="number1">An integer number.</param>
        /// <param name="number2">An integer number.</param>
        /// <param name="clock">A TimeSpan number.</param>
        /// <returns>The GCD of two integers numbers.</returns>
        public int BinGCD(int number1, int number2, out TimeSpan clock)
        {
            swatch.Start();
            if (number1 == 0)
            {
                swatch.Stop();
                clock = swatch.Elapsed;
                return number2;
            }
            if (number2 == 0)
            {
                swatch.Stop();
                clock = swatch.Elapsed;
                return number1;
            }

            if (number1 == number2)
            {
                swatch.Stop();
                clock = swatch.Elapsed;
                return number1;
            }

            if ((number1 == 1) || (number2 == 1))
            {
                swatch.Stop();
                clock = swatch.Elapsed;
                return 1;
            }

            if (number1 % 2 == 0)
            {
                swatch.Stop();
                return (number2 % 2 == 0) ? 2 * BinGCD(number1 / 2, number2 / 2, out clock) : 
                    BinGCD(number1 / 2, number2, out clock);
            }
            else if (number1 % 2 != 0)
            {
                swatch.Stop();
                return (number2 % 2 == 0) ? BinGCD(number1, number2 / 2, out clock) : 
                    BinGCD(number2 > number1 ? (number2 - number1) / 2 : (number1 - number2) / 2,
                    number2 > number1 ? number1 : number2, out clock);
            }
            swatch.Stop();
            clock = swatch.Elapsed;
            return 0;
        }

        /// <summary>
        /// A method that prepares data for building a histogram.
        /// </summary>
        /// <param name="number1">An integer number.</param>
        /// <param name="number2">An integer number.</param>
        /// <returns>Dictionary with name of the method and time taken to complete the calculations in this method.</returns>
        public Dictionary<string, string> BarChart(int number1, int number2)
        {
            Dictionary<string, string> workTime = new Dictionary<string, string>();
            TimeSpan watchBinGCD;
            TimeSpan watchGCD;
            BinGCD(number1, number2, out watchBinGCD);
            GCD(number1, number2, out watchGCD);
            workTime.Add("GCD", watchGCD.ToString("s\\.ffffff"));
            workTime.Add("BinaryGCD", watchBinGCD.ToString("s\\.ffffff"));
            return workTime;
        }

        //This method finds the minimum value for two integers.
        private int Min(int number1, int number2)
        {
            if (number1 > number2)
                min = number2;
            else
                min = number1;
            return min;
        }

        //This method calculate difference between two integers.
        private int Mod(int number1, int number2)
        {
            if (number1 > number2)
                mod = number1 - number2;
            else
                mod = number2 - number1;
            return mod;
        }

        //This method finds the minimum value for several integers.
        //Used for the first iteration in GCD method.
        private int Min(params int[] numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                    min = numbers[i];
            }
            return min;
        }

        //This method finds the minimum value for several integers.
        //Used for subsequent iteration in GCD method.
        private int Min(List<int> numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (min > numbers[i])
                    min = numbers[i];
            }
            return min;
        }

        //This method calculate difference between the number and the minimum value.
        //Used for the first iteration in GCD method.
        private List<int> Mod(params int[] numbers)
        {
            List<int> mod = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Abs(Math.Abs(numbers[i]) - Min(numbers)) == 0)
                {
                    mod.Add(Min(numbers));
                }
                else
                    mod.Add(Math.Abs(Math.Abs(numbers[i]) - Min(numbers)));
            }
            return mod;
        }

        //This method calculate difference between the number and the minimum value.
        //Used for subsequent iteration in GCD method.
        private List<int> Mod(List<int> numbers)
        {
            List<int> mod = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                mod.Add(Math.Abs(Math.Abs(numbers[i]) - Min(numbers)));
            }
            mod.Add(Min(numbers));
            mod.RemoveAll(item => item == 0);
            return mod;
        }
    }
}
