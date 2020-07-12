using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    public class CreatorTriangle : Creator
    {
        public double SizeA { get; set; }
        public double SizeB { get; set; }
        public double SizeC { get; set; }

        public CreatorTriangle(double sizeA, double sizeB, double sizeC)
        {
            SizeA = sizeA;
            SizeB = sizeB;
            SizeC = sizeC;
        }
        public override Figure CreateFigure()
        {
            return new Triangle(SizeA, SizeB, SizeC);
        }
    }
}
