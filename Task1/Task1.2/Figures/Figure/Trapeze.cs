using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Trapeze : Figure
    {
        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }
        double SideD { get; set; }
        public Trapeze(double sideA, double sideB, double sideC, double sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }

        public override double CalcP()
        {
            return SideA + SideB + SideC + SideD;
        }

        public override double CalcS()
        {
            return (SideA + SideB) / 2 * Math.Sqrt(Math.Pow(SideC, 2) - Math.Pow((Math.Pow(SideB - SideA, 2) +
                Math.Pow(SideC, 2) - Math.Pow(SideD, 2)) / 2 * (SideB - SideA), 2));
        }

        public override string ToString()
        {
            return "Trapeze : SideA = " + Convert.ToString(SideA) + "SideB = " + Convert.ToString(SideB) +
                "SideC = " + Convert.ToString(SideC) + "SideD = " + Convert.ToString(SideD) +
                " S = " + Convert.ToString(CalcS()) + " P = " + Convert.ToString(CalcP());
        }
        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + SideA.GetHashCode();
            hashCode = hashCode * -1521134295 + SideB.GetHashCode();
            hashCode = hashCode * -1521134295 + SideC.GetHashCode();
            hashCode = hashCode * -1521134295 + SideD.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Trapeze trapeze = (Trapeze)obj;
            return (this.SideA == trapeze.SideA &&
                this.SideB == trapeze.SideB &&
                this.SideC == trapeze.SideC &&
                this.SideD == trapeze.SideD);
        }
    }
}

