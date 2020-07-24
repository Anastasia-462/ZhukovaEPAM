using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    /// <summary>
    /// Class box for figures.
    /// </summary>
    public class Box
    {
        Figure[] figures = new Figure[20];

        /// <summary>
        /// Mathod to add new figure in the box.
        /// </summary>
        /// <param name="figure">A Figure object.</param>
        public void AddFigure(Figure figure)
        {
            for(int i = 0; i < figures.Length; i++)
            {
                if (figures[figures.Length - 1] != null)
                    throw new Exception("You can't add a figure because the box is full.");
                if (figures[i] != figure)
                {
                    if (figures[i] == null)
                        figures[i] = figure;
                }
                else
                    throw new Exception("This figure already exists.");
            }
        }

        /// <summary>
        /// Method to view the figure by number.
        /// </summary>
        /// <param name="number">An int number.</param>
        /// <returns>Information about figure.</returns>
        public string ViewFigure(int number)
        {
            if (figures[number] == null)
                throw new Exception("There is no figure for this number.");
            else
                return figures[number].ToString();
        }

        /// <summary>
        /// Method to extract a figure by number.
        /// </summary>
        /// <param name="number">An int number.</param>
        public void ExtractFigure(int number)
        {
            if (figures[number] == null)
                throw new Exception("There is no figure for this number.");
            else
                figures[number] = null;
        }

        /// <summary>
        /// Method to replace figure by number. 
        /// </summary>
        /// <param name="figure">A Figure object.</param>
        /// <param name="number">An int number.</param>
        public void ReplaceFigure(Figure figure, int number)
        {
            if (figures[number] == null)
                throw new Exception("There is no figure for this number.");
            else
                figures[number] = figure;
        }

        /// <summary>
        /// Method to show the available number of figures.
        /// </summary>
        /// <returns>A number of figures.</returns>
        public int NumberOfFigures()
        {
            int amount = 0;
            for(int i = 0; i < figures.Length; i++)
            {
                if (figures[i] != null)
                    amount++;
            }
            return amount;
        }

        /// <summary>
        /// Method to calculate total square.
        /// </summary>
        /// <returns>A double number.</returns>
        public double TotalSquare()
        {
            double totalSquare = 0;
            for(int i = 0; i < figures.Length; i++)
            {
                if (figures[i] != null)
                    totalSquare += figures[i].CalculateSquare();
            }
            return totalSquare;
        }

        /// <summary>
        /// Method to calculate total perimeter.
        /// </summary>
        /// <returns>A double number.</returns>
        public double TotalPerimeter()
        {
            double totalPerimeter = 0;
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] != null)
                    totalPerimeter += figures[i].CalculatePerimeter();
            }
            return totalPerimeter;
        }

        /// <summary>
        /// Method to get all the circles.
        /// </summary>
        /// <returns>Array of circles.</returns>
        public Figure[] GetCircle()
        {
            List<Figure> figures = new List<Figure>();
            for(int i = 0; i < figures.Count; i++)
            {
                if (figures[i].TypeExist() == typeof(Circle))
                    figures.Add(figures[i]);
            }
            return figures.ToArray();
        }

        /// <summary>
        /// Method to get all film figures.
        /// </summary>
        /// <returns>Array of film figures.</returns>
        public Figure[] GetFilmFigures()
        {
            List<Figure> filmFigures = null;
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] is FilmDecorator)
                    filmFigures.Add(figures[i]);
            }
            return filmFigures.ToArray();
        }
    }
}
