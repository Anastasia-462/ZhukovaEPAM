using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle : Figure
    {
        double SideA { get; set; }
        double SideB { get; set; }
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override double CalcP()
        {
            return 2 * (SideA + SideB);
        }

        public override double CalcS()
        {
            return SideA * SideB;
        }
        public override string ToString()
        {
            return "Rectangle : SideA = " + Convert.ToString(SideA) + "SideB = " + Convert.ToString(SideB) +
                " S = " + Convert.ToString(CalcS()) + " P = " + Convert.ToString(CalcP());
        }

        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + SideA.GetHashCode();
            hashCode = hashCode * -1521134295 + SideB.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Rectangle rectangle = (Rectangle)obj;
            return (this.SideA == rectangle.SideA &&
                this.SideB == rectangle.SideB);
        }
    }
}
