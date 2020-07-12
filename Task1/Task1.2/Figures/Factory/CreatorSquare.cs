using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    public class CreatorSquare : Creator
    {
        public double SideA { get; set; }

        public CreatorSquare(double sideA)
        {
            SideA = sideA;
        }
        public override Figure CreateFigure()
        {
            return new Square(SideA);
        }
    }
}
