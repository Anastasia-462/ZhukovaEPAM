using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// A specific figure decorator.
    /// </summary>
    public class PaperDecorator : Decorator, IPaper
    {
        private Colors color;

        // The color of the figure.
        Colors IPaper.Color { get => color; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="figure">The figure to be decorated.</param>
        /// <param name="color">Color of the figure.</param>
        public PaperDecorator(Figure figure, Colors color = Colors.None) : base(figure)
        {
            this.color = color;
        }
    }
}
