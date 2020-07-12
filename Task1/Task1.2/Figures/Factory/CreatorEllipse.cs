using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    public class CreatorEllipse : Creator
    {
        public double DialonalA { get; set; }
        public double DialonalB { get; set; }

        public CreatorEllipse(double dialonalA, double dialonalB)
        {
            DialonalA = dialonalA;
            DialonalB = dialonalB;
        }
        public override Figure CreateFigure()
        {
            return new Ellipse(DialonalA, DialonalB);
        }
    }
}
