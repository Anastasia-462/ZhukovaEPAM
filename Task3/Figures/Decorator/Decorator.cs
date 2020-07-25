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
        /// Method that checks the class of the decorated object.
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

        /// <summary>
        /// A method that determines whether two object instances are equal.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equals, and false if they are not.</returns>
        public override bool Equals(object obj)
        {
            return obj is Decorator decorator &&
                   figure.Equals(decorator.figure);
        }

        /// <summary>
        /// The method that the object hashcode will define.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            return -1854858383 + figure.GetHashCode();
        }

        /// <summary>
        /// Overriden method to output a string with the characteristics of the decorator.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return "Decorator : Figure = " + figure.ToString();
        }
    }
}
