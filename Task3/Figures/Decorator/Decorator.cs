using System;

namespace Figures
{
    /// <summary>
    /// Class that decorates the figure.
    /// </summary>
    public abstract class Decorator : Figure
    {
        Figure figure;

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="figure">The figure to be decorated.</param>
        public Decorator(Figure figure)
        {
            this.figure = figure;
        }

        /// <summary>
        /// Method for getting a decorated figure.
        /// </summary>
        /// <returns>The figure to be decorated.</returns>
        public Figure GetFigure()
        {
            return figure;
        }

        /// <summary>
        /// Method that checks the class of the decorated object
        /// </summary>
        /// <returns>Object type.</returns>
        public override Type TypeExist()
        {
            return figure.TypeExist();
        }

        /// <summary>
        /// Overriden method to calculate perimeter.
        /// </summary>
        /// <returns>A perimeter.</returns>
        public override double CalculatePerimeter()
        {
            return figure.CalculatePerimeter();
        }

        /// <summary>
        /// Overriden method to calculate square.
        /// </summary>
        /// <returns>A square.</returns>
        public override double CalculateSquare()
        {
            return figure.CalculateSquare();
        }
    }
}
