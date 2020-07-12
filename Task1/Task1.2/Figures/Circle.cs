using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalcP()
        {
            return 2 * Math.PI * Radius;
        }

        public override double CalcS()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle : R = " + Convert.ToString(Radius) + "S = " + Convert.ToString(CalcS()) + "P = " + Convert.ToString(CalcP());
        }
    }
}
