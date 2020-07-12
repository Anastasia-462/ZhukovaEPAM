using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Polygonum : Figure
    {
        public Point[] Points { get; set; }

        public Polygonum(Point[] points)
        {
            Points = points;
        }

        public override double CalcP()
        {
            double perimeter = 0;
            for (int i = 0; i < Points.Length - 1; i++)
            {
                perimeter += Points[i].DistanceTo(Points[i + 1]);
            }
            perimeter += Points[Points.Length - 1].DistanceTo(Points[0]);
            return perimeter;
        }

        public override double CalcS()
        {
            double square = 0;
            for (int i = 0; i < Points.Length - 1; i++)
            {
                square += Points[i].Square(Points[i + 1]);
            }
            square += Points[Points.Length - 1].Square(Points[0]);
            return Math.Abs(square);
        }

        public override string ToString()
        {
            string result = "Polygonum : ";
            for (int i = 0; i < Points.Length; i++)
            {
                result += "Side " + (i + 1) + ": " + "x = " + Convert.ToString(Points[i].X) + "y = " + Convert.ToString(Points[i].Y) + "\n";
            }
            result += " S = " + Convert.ToString(CalcS()) + " P = " + Convert.ToString(CalcP());
            return result;
        }
        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            for(int i = 0; i < Points.Length; i++)
            {
                hashCode = hashCode * -1521134295 + Points[i].GetHashCode();
            }
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Polygonum polygonum = (Polygonum)obj;
            int amount = 0;
            for (int i = 0; i < Points.Length; i++)
            {
                if(this.Points[i] == polygonum.Points[i])
                {
                    amount++;
                }
            }
            return (amount == Points.Length);
        }
    }
}
