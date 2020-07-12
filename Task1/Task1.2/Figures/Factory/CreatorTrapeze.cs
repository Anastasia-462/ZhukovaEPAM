using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    public class CreatorTrapeze : Creator
    {
        public double SizeA { get; set; }
        public double SizeB { get; set; }
        public double SizeC { get; set; }
        public double SizeD { get; set; }
        public CreatorTrapeze(double sizeA, double sizeB, double sizeC, double sizeD)
        {
            SizeA = sizeA;
            SizeB = sizeB;
            SizeC = sizeC;
            SizeD = sizeD;
        }
        public override Figure CreateFigure()
        {
            return new Trapeze(SizeA, SizeB, SizeC, SizeD);
        }
    }
}
