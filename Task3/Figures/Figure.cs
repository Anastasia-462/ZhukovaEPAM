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

        /// <summary>
        /// Method that colors the figure.
        /// </summary>
        /// <param name="figure">A Figure object.</param>
        /// <param name="color">A color.</param>
        /// <returns>A colored figure.</returns>
        public static Figure PaintFigure(Figure figure, Colors color)
        {            
            if (figure is PaperDecorator)
            {
                if (((IPaper)figure).Color == Colors.None)
                {
                    Figure figureNew = ((Decorator)figure).GetFigure();
                    return new PaperDecorator(figureNew, color);
                }
                else
                    throw new Exception("The figure is already colored.");
            }
            else
                throw new Exception("The figure of the wrap cannot be colored.");
        }

        /// <summary>
        /// Method comparing the type and type of the current object
        /// </summary>
        /// <returns>Object type.</returns>
        public virtual Type TypeExist()
        {
            return GetType();
        }
    }
}
