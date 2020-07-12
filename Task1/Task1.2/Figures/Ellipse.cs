using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Ellipse : Figure
    {
        public double DiagonalA { get; set; }
        public double DiagonalB { get; set; }
        public Ellipse(double diagonalA, double diagonalB)
        {
            DiagonalA = diagonalA;
            DiagonalB = diagonalB;
        }

        public override double CalcP()
        {
            return 4 * (Math.PI * DiagonalA * DiagonalB + (DiagonalA - DiagonalB)) / (DiagonalA + DiagonalB);
        }

        public override double CalcS()
        {
            return Math.PI * DiagonalA * DiagonalB;
        }

        public override string ToString()
        {
            return "Ellipse : DiagonalA = " + Convert.ToString(DiagonalA) + "DiagonalB = " + Convert.ToString(DiagonalB) +
                " S = " + Convert.ToString(CalcS()) + " P = " + Convert.ToString(CalcP());
        }
    }
}
