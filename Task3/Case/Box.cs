using Figures;
using System;
using System.Collections.Generic;
using XmlProcessing;

namespace Case
{
    /// <summary>
    /// Class box for figures.
    /// </summary>
    public class Box
    {
        /// <summary>
        /// Array of figures.
        /// </summary>
        public Figure[] Figures { get => figures; }
        private Figure[] figures;

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Box()
        {
            figures = new Figure[20];
        }

        /// <summary>
        /// Mathod to add new figure in the box.
        /// </summary>
        /// <param name="figure">A Figure object.</param>
        public void AddFigure(Figure figure)
        {
            int i = 0;
            while(figures[i] != null)
            {
                if(figures[i].Equals(figure))
                    throw new Exception("This figure already exists.");
                if(i == figures.Length - 1)
                    throw new Exception("You can't add a figure because the box is full.");
                i++;
            }
            figures[i] = figure;
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
        /// Method to search for a figure by pattern.
        /// </summary>
        /// <param name="figure">A Figure object.</param>
        /// <returns>Index of found figure.</returns>
        public int SearchForFigure(Figure figure)
        {
            for(int i = 0; i < figures.Length; i++)
            {
                if ((figures[i] != null) && (figures[i].Equals(figure)))
                    return i;
            }
            return -1;
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
            List<Figure> filmFigures = new List<Figure>();
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] is FilmDecorator)
                    filmFigures.Add(figures[i]);
            }
            return filmFigures.ToArray();
        }

        /// <summary>
        /// Method to save all figures with the help StreamWriter.
        /// </summary>
        public void SaveAllFiguresSW(string path)
        {
            StreamFigureWriter.XmlStreamWriting(figures, path);
        }

        /// <summary>
        /// Method to save only paper figures with the help StreamWriter.
        /// </summary>
        public void SavePaperFiguresSW(string path)
        {
            List<Figure> paperFigure = new List<Figure>();
            for(int i = 0; i < figures.Length; i++)
            {
                if (figures[i] is PaperDecorator)
                    paperFigure.Add(figures[i]);
            }
            StreamFigureWriter.XmlStreamWriting(paperFigure.ToArray(), path);
        }

        /// <summary>
        /// Method to save only film figures with the help StreamWriter.
        /// </summary>
        public void SaveFilmFiguresSW(string path)
        {
            List<Figure> filmFigure = new List<Figure>();
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] is FilmDecorator)
                    filmFigure.Add(figures[i]);
            }
            StreamFigureWriter.XmlStreamWriting(filmFigure.ToArray(), path);
        }

        /// <summary>
        /// Method to save all figures with the help XmlWriter.
        /// </summary>
        public void SaveAllFiguresXW(string path)
        {
            XmlFigureWriter.XmlWriting(figures, path);
        }

        /// <summary>
        /// Method to save only paper figures with the help XmlWriter.
        /// </summary>
        public void SavePaperFiguresXW(string path)
        {
            List<Figure> paperFigure = new List<Figure>();
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] is PaperDecorator)
                    paperFigure.Add(figures[i]);
            }
            XmlFigureWriter.XmlWriting(paperFigure.ToArray(), path);
        }

        /// <summary>
        /// Method to save only film figure with the help XmlWriter.
        /// </summary>
        public void SaveFilmFiguresXW(string path)
        {
            List<Figure> filmFigure = new List<Figure>();
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] is FilmDecorator)
                    filmFigure.Add(figures[i]);
            }
            XmlFigureWriter.XmlWriting(filmFigure.ToArray(), path);
        }

        /// <summary>
        /// Method to download all figures to the box from a xml file with the help StreamReader.
        /// </summary>
        /// <returns>An array of figures.</returns>
        public void DownloadFiguresSR(string path)
        {
            figures = StreamFigureReader.XmlStreamReading(path);
        }

        /// <summary>
        /// Method to download all figures to the box from a xml file with the help XmlReader.
        /// </summary>
        /// <returns>An array of figures.</returns>
        public void DownloadFiguresXR(string path)
        {
            figures = XmlFigureReader.XmlReading(path);
        }

        //Method to compare the arrays.
        private bool ComparisonOfArray(Figure[] figures)
        {
            if (this.figures.Length != figures.Length) return false;
            int amount = 0;
            for (int i = 0; i < this.figures.Length; i++)
            {
                if ((this.figures[i] != null) && (figures[i] != null) && (this.figures[i].Equals(figures[i])))
                    amount++;
                if ((figures[i] == null) && (this.figures[i] == null)) 
                    amount++;
            }
            return (amount == this.figures.Length);
        }

        /// <summary>
        /// A method that determines whether two object instances are equal.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equals, and false if they are not.</returns>
        public override bool Equals(object obj)
        {
            return obj is Box box &&
                   ComparisonOfArray(box.figures);
        }

        /// <summary>
        /// The method that the object hashcode will define.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            return 429526846 + EqualityComparer<Figure[]>.Default.GetHashCode(figures);
        }

        /// <summary>
        /// Overriden method to output a string with the characteristics of the box.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            string result = "Box : Figures - ";
            for(int i = 0; i < figures.Length; i++)
            {
                if(figures[i] != null)
                    result += figures[i].ToString() + "\n";
            }
            return result;
        }
    }
}
