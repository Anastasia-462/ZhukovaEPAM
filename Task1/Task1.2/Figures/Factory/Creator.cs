using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    public abstract class Creator
    {
        public abstract Figure CreateFigure();
    }
}
