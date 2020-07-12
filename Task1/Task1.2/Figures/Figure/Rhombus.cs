using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rhombus : Figure
    {
        public double DiagonalA { get; set; }
        public double DiagonalB { get; set; }
        public Rhombus(double diagonalA, double diagonalB)
        {
            DiagonalA = diagonalA;
            DiagonalB = diagonalB;
        }

        public override double CalcP()
        {
            return 4 * Math.Sqrt(0.5 * Math.Pow(DiagonalA, 2) + 0.5 * Math.Pow(DiagonalB, 2));
        }

        public override double CalcS()
        {
            return 0.5 * DiagonalA * DiagonalB;
        }

        public override string ToString()
        {
            return "Rhombus : DiagonalA = " + Convert.ToString(DiagonalA) + "DiagonalB = " + Convert.ToString(DiagonalB) +
                " S = " + Convert.ToString(CalcS()) + " P = " + Convert.ToString(CalcP());
        }
        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + DiagonalA.GetHashCode();
            hashCode = hashCode * -1521134295 + DiagonalB.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Rhombus rhombus = (Rhombus)obj;
            return (this.DiagonalA == rhombus.DiagonalA &&
                this.DiagonalB == rhombus.DiagonalB);
        }
    }
}
