using Figures;
using System;
using System.Collections.Generic;
using System.Xml;

namespace XmlProcessing
{
    /// <summary>
    /// Class which read xml file with the help XmlReader.
    /// </summary>
    public class XmlFigureReader
    {        
        /// <summary>
        /// The main method which processing xml file.
        /// </summary>
        public void XmlReading()
        {
            List<Figure> figure = new List<Figure>();
            using (XmlReader xml = XmlReader.Create("Figures.xml"))
            {
                while(xml.Read())
                {
                    if((xml.NodeType == XmlNodeType.Element) && (xml.Name == "figure"))
                    {
                        figure.Add(SelectingFigure(xml));
                    }    

                }
            }
        }

        //Method which processing circle.
        private Figure CircleParser(XmlReader xml)
        {
            double radius = 0;
            while((xml.NodeType == XmlNodeType.Element) && (xml.Name != "material"))
            {
                xml.Read();
                if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "radius"))
                {
                    xml.Read();
                    radius = Double.Parse(xml.Value);
                }
            }
            Circle circle = new Circle(radius);
            return Decorating(xml, circle);
        }

        //Method which processing rectangle.
        private Figure RectangleParser(XmlReader xml)
        {
            double a = 0;
            double b = 0;
            while ((xml.NodeType == XmlNodeType.Element) && (xml.Name != "material"))
            {
                xml.Read();
                if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "sideA"))
                {
                    xml.Read();
                    a = Double.Parse(xml.Value);
                }
                if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "sideB"))
                {
                    xml.Read();
                    b = Double.Parse(xml.Value);
                }
            }
            Rectangle rectangle = new Rectangle(a, b);
            return Decorating(xml, rectangle);
        }

        ////Method which processing ellipse.
        private Figure EllipseParser(XmlReader xml)
        {
            double d1 = 0;
            double d2 = 0;
            while ((xml.NodeType == XmlNodeType.Element) && (xml.Name != "material"))
            {
                xml.Read();
                if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "diagonalA"))
                {
                    xml.Read();
                    d1 = Double.Parse(xml.Value);
                }
                if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "diagonalB"))
                {
                    xml.Read();
                    d2 = Double.Parse(xml.Value);
                }
            }
            Ellipse ellipse = new Ellipse(d1, d2);
            return Decorating(xml, ellipse);
        }

        ////Method which processing triangle.
        private Figure TriangleParser(XmlReader xml)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            while ((xml.NodeType == XmlNodeType.Element) && (xml.Name != "material"))
            {
                xml.Read();
                if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "sideA"))
                {
                    xml.Read();
                    a = Double.Parse(xml.Value);
                }
                if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "sideB"))
                {
                    xml.Read();
                    b = Double.Parse(xml.Value);
                }
                if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "sideC"))
                {
                    xml.Read();
                    c = Double.Parse(xml.Value);
                }
            }
            Triangle triangle = new Triangle(a, b, c);
            return Decorating(xml, triangle);
        }

        ////Method which processing polygonum.
        private Figure PolygonumParser(XmlReader xml)
        {
            List<Point> points = new List<Point>();
            int i = 0;
            while ((xml.NodeType == XmlNodeType.Element) && (xml.Name != "material"))
            {
                xml.Read();
                if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "point" + i))
                {
                    xml.Read();
                    string[] words = (xml.Value).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    points.Add(new Point(Double.Parse(words[0]), Double.Parse(words[1])));
                    i++;
                }                              
            }
            Polygonum polygonum = new Polygonum(points.ToArray());
            return Decorating(xml, polygonum);
        }

        //Method which sets the method for processing the figure.
        private Figure SelectingFigure(XmlReader xml)
        {
            xml.Read();
            xml.Read();
            switch (xml.Value)
            {
                case "Circle":
                    return CircleParser(xml);
                case "Ellipse":
                    return EllipseParser(xml);
                case "Polygonum":
                    return PolygonumParser(xml);
                case "Rectangle":
                    return RectangleParser(xml);
                case "Triangle":
                    return TriangleParser(xml);
                default:
                    return null;
            }
        }

        //Method which converts a string to an element of enum.
        private Colors ConvertToColors(string color)
        {
            switch(color)
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
        private Decorator Decorating(XmlReader xml, Figure figure)
        {
            string material = "";
            string color = "";
            if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "material"))
            {
                xml.Read();
                material = xml.Value;
            }
            xml.Read();
            xml.Read();
            if ((xml.NodeType == XmlNodeType.Element) && (xml.Name == "color"))
            {
                xml.Read();
                color = xml.Value;
                xml.Read();
                xml.Read();
            }            
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
