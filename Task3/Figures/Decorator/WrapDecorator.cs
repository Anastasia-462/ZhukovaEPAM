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
    public class WrapDecorator : Decorator, IWrap
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="figure">The figure to be decorated.</param>
        public WrapDecorator(Figure figure) : base(figure)
        {
        }
    }
}
