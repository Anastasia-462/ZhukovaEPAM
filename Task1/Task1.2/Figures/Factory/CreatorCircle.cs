using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    public class CreatorCircle : Creator
    {
        public double Radius { get; set; }

        public CreatorCircle(double radius)
        {
            Radius = radius;
        }
        public override Figure CreateFigure()
        {
            return new Circle(Radius);
        }
    }
}
