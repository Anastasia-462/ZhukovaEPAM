using Figures.Factory;
using System;
using System.IO;
using System.Text;

namespace Figures
{
    /// <summary>
    /// Class for working with a text file.
    /// </summary>
    public class Parser
    {
        string text;

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="text">The text file.</param>
        public Parser(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Method for reading the text file and forming an array of figures.
        /// </summary>
        /// <returns>Array of figures.</returns>
        public Figure[] FormingArrayOfFigure()
        {
            string file = File.ReadAllText(text, Encoding.GetEncoding(1251));
            string[] sentences = file.Split('\n');
            Figure[] figure = new Figure[sentences.Length];
            string[] words;
            for (int i = 0; i < sentences.Length; i++)
            {
                words = sentences[i].Split(' ');
                figure[i] = GetCreater(words).CreateFigure();
            }
            return figure;
        }

        /// <summary>
        /// The method searches for identical figures.
        /// </summary>
        /// <returns>A string with identical figures or a string indicating the the are not there.</returns>
        public string SearchIdenticalFigures()
        {
            Figure[] figure = FormingArrayOfFigure();
            string result = "";
            for (int i = 0; i < figure.Length; i++)
            {
                for (int j = i + 1; j < figure.Length; j++)
                {
                    if ((figure[i].CalcS() == figure[j].CalcS()) &&
                        (figure[i].CalcP() == figure[j].CalcP()))
                        result += "Identical figures: " + figure[i].ToString() + " AND " + figure[j].ToString() + "\n";
                }
            }
            if (result == "")
                result = "There are no identical figures!\n";
            return result;
        }

        //Creating a factory on call.
        private Creator GetCreater(string[] words)
        {
            int length = words.Length;
            switch (words[0])
            {
                case "Circle":
                    return new CreatorCircle(Double.Parse(words[1]));
                case "Square":
                    return new CreatorSquare(Double.Parse(words[1]));
                case "Polygonum":
                    Point[] points = new Point[length / 2];
                    for (int i = 0, j = 1; i < length / 2; i++, j += 2)
                    {
                        points[i] = new Point(Double.Parse(words[j]), Double.Parse(words[j + 1]));
                    }
                    return new CreatorPolygonum(points);
                case "Ellipse":
                    return new CreatorEllipse(Double.Parse(words[1]), Double.Parse(words[2]));
                case "Rectangle":
                    return new CreatorRectangle(Double.Parse(words[1]), Double.Parse(words[2]));
                case "Rhombus":
                    return new CreatorRhombus(Double.Parse(words[1]), Double.Parse(words[2]));
                case "Trapeze":
                    return new CreatorTrapeze(Double.Parse(words[1]), Double.Parse(words[2]),
                        Double.Parse(words[3]), Double.Parse(words[4]));
                case "Triangle":
                    return new CreatorTriangle(Double.Parse(words[1]), Double.Parse(words[2]), 
                        Double.Parse(words[3]));
            }
            return null;
        }
    }
}

