using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square : Figure
    {
        public double SideA { get; set; }
        public Square(double sideA)
        {
            this.SideA = sideA;
        }

        public override double CalcP()
        {
            return 4 * SideA;
        }

        public override double CalcS()
        {
            return SideA * SideA;
        }

        public override string ToString()
        {
            return "Square : SideA = " + Convert.ToString(SideA) +
                " S = " + Convert.ToString(CalcS()) + " P = " + Convert.ToString(CalcP());
        }
        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + SideA.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Square square = (Square)obj;
            return (this.SideA == square.SideA);
        }
    }
}
