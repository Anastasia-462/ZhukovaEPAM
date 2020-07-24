using Figures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace XmlProcessing
{
    /// <summary>
    /// Class which read xml file with the help StreamReader.
    /// </summary>
    public static class StreamFigureReader
    {
        /// <summary>
        /// The main method which processing xml file.
        /// </summary>
        public static Figure[] XmlStreamReading()
        {
            string strline;
            List<Figure> figures = new List<Figure>();
            using (StreamReader stream = new StreamReader("Figures.xml"))
            {
                while ((strline = stream.ReadLine()) != null)
                {
                    if(Regex.IsMatch(strline, @"type"))
                        figures.Add(SelectingFigure(stream, strline));
                }                
            }
            return figures.ToArray();
        }

        //Method which sets the method for processing the figure.
        private static Figure SelectingFigure(StreamReader stream, string strline)
        {
            string match = Regex.Match(strline, @"(?<=<type>)(.*)(?<=</type>)").ToString();
            switch (match)
            {
                case "Circle":
                    return Parser.CircleParser(stream);
                case "Ellipse":
                    return Parser.EllipseParser(stream);
                case "Polygonum":
                    return Parser.PolygonumParser(stream);
                case "Rectangle":
                    return Parser.RectangleParser(stream);
                case "Triangle":
                    return Parser.TriangleParser(stream);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Inner class for parsing xml file.
        /// </summary>
        public static class Parser
        {
            /// <summary>
            /// Method which processing circle.
            /// </summary>
            /// <param name="stream">A StreamReader object.</param>
            /// <returns>Decorated circle.</returns>
            public static Figure CircleParser(StreamReader stream)
            {
                string strline = stream.ReadLine();
                string radius = Regex.Match(strline, @"(?<=<radius>)(.*)(?<=</radius>)").ToString();
                Circle circle = new Circle(Double.Parse(radius));
                return Decorating(circle, stream);
            }

            /// <summary>
            /// Method which processing ellipse.
            /// </summary>
            /// <param name="stream">A StreamReader object.</param>
            /// <returns>Decorated ellipse.</returns>
            public static Figure EllipseParser(StreamReader stream)
            {
                string strline = stream.ReadLine();
                string d1 = Regex.Match(strline, @"(?<=<diagonalA>)(.*)(?<=</diagonalA>)").ToString();
                strline = stream.ReadLine();
                string d2 = Regex.Match(strline, @"(?<=<diagonalB>)(.*)(?<=</diagonalB>)").ToString();
                Ellipse ellipse = new Ellipse(Double.Parse(d1), Double.Parse(d2));
                return Decorating(ellipse, stream);
            }

            /// <summary>
            /// Method which processing polygonum.
            /// </summary>
            /// <param name="stream">A StreamReader object.</param>
            /// <returns>Decorated polygonum.</returns>
            public static Figure PolygonumParser(StreamReader stream)
            {
                string strline = stream.ReadLine();
                int i = 0;
                string point;
                List<Point> points = new List<Point>();
                while(!Regex.IsMatch(strline, @"<material>"))
                {
                    strline = stream.ReadLine();
                    point = Regex.Match(strline, @"(?<=<point" + i + @">)(.*)(?<=</point" + i + @">)").ToString();
                    string[] words = (point).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    points.Add(new Point(Double.Parse(words[0]), Double.Parse(words[1])));
                    i++;

                }
                Polygonum polygonum = new Polygonum(points.ToArray());
                return Decorating(polygonum, stream);
            }

            /// <summary>
            /// Method which processing rectangle.
            /// </summary>
            /// <param name="stream">A StreamReader object.</param>
            /// <returns>Decorated rectangle.</returns>
            public static Figure RectangleParser(StreamReader stream)
            {
                string strline = stream.ReadLine();
                string a = Regex.Match(strline, @"(?<=<sideA>)(.*)(?<=</sideA>)").ToString();
                strline = stream.ReadLine();
                string b = Regex.Match(strline, @"(?<=<sideB>)(.*)(?<=</sideB>)").ToString();
                Rectangle rectangle = new Rectangle(Double.Parse(a), Double.Parse(b));
                return Decorating(rectangle, stream);
            }

            /// <summary>
            /// Method which processing triangle.
            /// </summary>
            /// <param name="stream">A StreamReader object.</param>
            /// <returns>Decorated triangle.</returns>
            public static Figure TriangleParser(StreamReader stream)
            {
                string strline = stream.ReadLine();
                string a = Regex.Match(strline, @"(?<=<sideA>)(.*)(?<=</sideA>)").ToString();
                strline = stream.ReadLine();
                string b = Regex.Match(strline, @"(?<=<sideB>)(.*)(?<=</sideB>)").ToString();
                strline = stream.ReadLine();
                string c = Regex.Match(strline, @"(?<=<sideC>)(.*)(?<=</sideC>)").ToString();
                Triangle triangle = new Triangle(Double.Parse(a), Double.Parse(b), Double.Parse(c));
                return Decorating(triangle, stream);
            }

            //Method which converts a string to an element of enum.
            private static Colors ConvertToColors(string color)
            {
                switch (color)
                {
                    case "Blue":
                        return Colors.Blue;
                    case "Black":
                        return Colors.Black;
                    case "Gray":
                        return Colors.Gray;
                    case "Green":
                        return Colors.Green;
                    case "None":
                        return Colors.None;
                    case "Red":
                        return Colors.Red;
                    case "White":
                        return Colors.White;
                    case "Yellow":
                        return Colors.Yellow;
                    default:
                        return Colors.None;
                }
            }

            //Method which decorates the figure depending on the material.
            private static Decorator Decorating(Figure figure, StreamReader stream)
            {
                string strline = stream.ReadLine();
                string material = Regex.Match(strline, @"(?<=<material>)(.*)(?<=</material>)").ToString();
                strline = stream.ReadLine();
                string color = Regex.Match(strline, @"(?<=<material>)(.*)(?<=</material>)").ToString();
                if (material == "Paper")
                {
                    if (color != "")
                        return new PaperDecorator(figure, ConvertToColors(color));
                    return new PaperDecorator(figure);
                }
                else
                    return new FilmDecorator(figure);
            }

        }


    }
}
