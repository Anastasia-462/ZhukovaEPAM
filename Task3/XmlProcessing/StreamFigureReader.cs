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
        public static Figure[] XmlStreamReading(string path)
        {
            string strline;
            List<Figure> figures = new List<Figure>();
            using (StreamReader stream = new StreamReader(path))
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
            string match = Regex.Match(strline, @"(<type>)(.*)(</type>)").ToString();
            string pattern = Regex.Replace(match, "<type>", "");
            string result = Regex.Replace(pattern, "</type>", "");
            switch (result)
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
        private static class Parser
        {
            /// <summary>
            /// Method which processing circle.
            /// </summary>
            /// <param name="stream">A StreamReader object.</param>
            /// <returns>Decorated circle.</returns>
            public static Figure CircleParser(StreamReader stream)
            {
                string strline = stream.ReadLine();
                string radius = Regex.Match(strline, @"(<radius>)(.*)(</radius>)").ToString();
                string pattern = Regex.Replace(radius, "<radius>", "");
                string result = Regex.Replace(pattern, "</radius>", "");
                Circle circle = new Circle(Double.Parse(result));
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
                string d1 = Regex.Match(strline, @"(<diagonalA>)(.*)(</diagonalA>)").ToString();
                string pattern1 = Regex.Replace(d1, "<diagonalA>", "");
                string result1 = Regex.Replace(pattern1, "</diagonalA>", "");
                strline = stream.ReadLine();
                string d2 = Regex.Match(strline, @"(<diagonalB>)(.*)(</diagonalB>)").ToString();
                string pattern2 = Regex.Replace(d2, "<diagonalB>", "");
                string result2 = Regex.Replace(pattern2, "</diagonalB>", "");
                Ellipse ellipse = new Ellipse(Double.Parse(result1), Double.Parse(result2));
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
                while (!Regex.IsMatch(strline, @"<material>"))
                {                    
                    point = Regex.Match(strline, @"(<point" + (i + 1) + @">)(.*)(</point" + (i + 1) + @">)").ToString();
                    string pattern = Regex.Replace(point, "<point" + (i + 1) + ">", "");
                    string result = Regex.Replace(pattern, "</point" + (i + 1) + ">", "");
                    string[] words = (result).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    points.Add(new Point(Double.Parse(words[0]), Double.Parse(words[1])));
                    i++;
                    strline = stream.ReadLine();
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
                string a = Regex.Match(strline, @"(<sideA>)(.*)(</sideA>)").ToString();
                string pattern1 = Regex.Replace(a, "<sideA>", "");
                string result1 = Regex.Replace(pattern1, "</sideA>", "");
                strline = stream.ReadLine();
                string b = Regex.Match(strline, @"(<sideB>)(.*)(</sideB>)").ToString();
                string pattern2 = Regex.Replace(b, "<sideB>", "");
                string result2 = Regex.Replace(pattern2, "</sideB>", "");
                Rectangle rectangle = new Rectangle(Double.Parse(result1), Double.Parse(result2));
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
                string a = Regex.Match(strline, @"(<sideA>)(.*)(</sideA>)").ToString();
                string pattern1 = Regex.Replace(a, "<sideA>", "");
                string result1 = Regex.Replace(pattern1, "</sideA>", "");
                strline = stream.ReadLine();
                string b = Regex.Match(strline, @"(<sideB>)(.*)(</sideB>)").ToString();
                string pattern2 = Regex.Replace(b, "<sideB>", "");
                string result2 = Regex.Replace(pattern2, "</sideB>", "");
                strline = stream.ReadLine();
                string c = Regex.Match(strline, @"(<sideC>)(.*)(</sideC>)").ToString();
                string pattern3 = Regex.Replace(c, "<sideC>", "");
                string result3 = Regex.Replace(pattern3, "</sideC>", "");
                Triangle triangle = new Triangle(Double.Parse(result1), Double.Parse(result2), Double.Parse(result3));
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
                string material = Regex.Match(strline, @"(<material>)(.*)(</material>)").ToString();
                string pattern1 = Regex.Replace(material, "<material>", "");
                string result1 = Regex.Replace(pattern1, "</material>", "");
                strline = stream.ReadLine();
                string color = Regex.Match(strline, @"(<color>)(.*)(</color>)").ToString();
                string pattern2 = Regex.Replace(color, "<color>", "");
                string result2 = Regex.Replace(pattern2, "</color>", "");
                if (result1 == "Paper")
                {
                    if (result2 != "")
                        return new PaperDecorator(figure, ConvertToColors(result2));
                    return new PaperDecorator(figure);
                }
                else
                    return new FilmDecorator(figure);
            }

        }


    }
}
