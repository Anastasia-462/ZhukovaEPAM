using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    public class CreatorPolygonum : Creator
    {
        public Point[] Points { get; set; }
        public CreatorPolygonum(Point[] points)
        {
            Points = points;
        }
        
        public override Figure CreateFigure()
        {
            return new Polygonum(Points);
        }
    }
}
