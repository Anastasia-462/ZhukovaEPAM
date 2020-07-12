using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    public class CreatorRhombus : Creator
    {
        public double DiagonalA { get; set; }
        public double DiagonalB { get; set; }
        public CreatorRhombus(double diagonalA, double diagonalB)
        {
            DiagonalA = diagonalA;
            DiagonalB = diagonalB;
        }
        public override Figure CreateFigure()
        {
            return new Rhombus(DiagonalA, DiagonalB);
        }
    }
}
