using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Class responsible for figures and working with them.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Method for calculating perimeter.
        /// </summary>
        /// <returns>Perimeter of figure.</returns>
        public abstract double CalculatePerimeter();

        /// <summary>
        /// Method for calculating square.
        /// </summary>
        /// <returns>Square of figure.</returns>
        public abstract double CalculateSquare();
    }
}
