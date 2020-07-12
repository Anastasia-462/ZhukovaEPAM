using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    public class CreatorRectangle : Creator
    {
        public double SizeA { get; set; }
        public double SizeB { get; set; }
        public CreatorRectangle(double sizeA, double sizeB)
        {
            SizeA = sizeA;
            SizeB = sizeB;
        }
        
        public override Figure CreateFigure()
        {
            return new Rectangle(SizeA, SizeB);
        }
    }
}
