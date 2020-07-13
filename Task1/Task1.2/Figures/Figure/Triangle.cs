using System;

namespace Figures
{
    public class Triangle : Figure
    {
        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalcP()
        {
            return SideA + SideB + SideC;
        }

        public override double CalcS()
        {
            double p = CalcP() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override string ToString()
        {
            return "Triangle : SideA = " + Convert.ToString(SideA) + "SideB = " + Convert.ToString(SideB) +
                "SideC = " + Convert.ToString(SideC) + " S = " + Convert.ToString(CalcS()) +
                " P = " + Convert.ToString(CalcP());
        }
        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + SideA.GetHashCode();
            hashCode = hashCode * -1521134295 + SideB.GetHashCode();
            hashCode = hashCode * -1521134295 + SideC.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Triangle triangle = (Triangle)obj;
            return (this.SideA == triangle.SideA &&
                this.SideB == triangle.SideB &&
                this.SideC == triangle.SideC);
        }
    }
}
