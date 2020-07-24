using Figures;
using System.Xml;

namespace XmlProcessing
{
    /// <summary>
    /// Class which write xml file with the help XmlWriter.
    /// </summary>
    public static class XmlFigureWriter
    {
        /// <summary>
        /// The main method which processing xml file.
        /// </summary>
        public static void XmlWriting(Figure[] figures)
        {
            using (XmlWriter xml = XmlWriter.Create("Figures.xml"))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("figures");
                for (int i = 0; i < figures.Length; i++)
                {
                    SelectingFigure(xml, figures[i]);
                }
                xml.WriteEndDocument();
            }
        }

        //Method which sets the method for processing the figure.
        private static void SelectingFigure(XmlWriter xml, Figure figure)
        {
            switch (figure.TypeExist().ToString())
            {
                case "Figures.Circle":
                    FormCircle(xml, figure);
                    break;
                case "Figures.Ellipse":
                    FormEllipse(xml, figure);
                    break;
                case "Figures.Polygonum":
                    FormPolygonum(xml, figure);
                    break;
                case "Figures.Rectangle":
                    FormRectangle(xml, figure);
                    break;
                case "Figures.Triangle":
                    FormTriangle(xml, figure);
                    break;
            }
        }

        //Method which forming circle for xml file.
        private static void FormCircle(XmlWriter xml, Figure figure)
        {
            Circle circle = (Circle)(((Decorator)figure).GetFigure());
            xml.WriteStartElement("figure");

            xml.WriteStartElement("type");
            xml.WriteString("Circle");
            xml.WriteEndElement();
            xml.WriteStartElement("radius");
            xml.WriteString($"{ circle.Radius}");
            xml.WriteEndElement();
            xml.WriteStartElement("material");
            if(figure is PaperDecorator)
            {
                xml.WriteString("Paper");
                if(((IPaper)figure).Color != Colors.None)
                {
                    xml.WriteStartElement("color");
                    xml.WriteString($"{ ((IPaper)figure).Color }");
                    xml.WriteEndElement();
                }                    
            }                
            else
                xml.WriteString("Film");
            xml.WriteEndElement();
            xml.WriteEndElement();
        }

        //Method which forming ellipse for xml file.
        private static void FormEllipse(XmlWriter xml, Figure figure)
        {
            Ellipse ellipse = (Ellipse)(((Decorator)figure).GetFigure());
            xml.WriteStartElement("figure");

            xml.WriteStartElement("type");
            xml.WriteString("Ellipse");
            xml.WriteEndElement();
            xml.WriteStartElement("diagonalA");
            xml.WriteString($"{ ellipse.DiagonalA }");
            xml.WriteEndElement();
            xml.WriteStartElement("diagonalB");
            xml.WriteString($"{ ellipse.DiagonalB }");
            xml.WriteEndElement();
            xml.WriteStartElement("material");
            if (figure is PaperDecorator)
            {
                xml.WriteString("Paper");
                if (((IPaper)figure).Color != Colors.None)
                {
                    xml.WriteStartElement("color");
                    xml.WriteString($"{ ((IPaper)figure).Color }");
                    xml.WriteEndElement();
                }
            }
            else
                xml.WriteString("Film");
            xml.WriteEndElement();
            xml.WriteEndElement();
        }

        //Method which forming polygonum for xml file.
        private static void FormPolygonum(XmlWriter xml, Figure figure)
        {
            Polygonum polygonum = (Polygonum)(((Decorator)figure).GetFigure());
            xml.WriteStartElement("figure");

            xml.WriteStartElement("type");
            xml.WriteString("Polygonum");
            xml.WriteEndElement();
            for(int i = 0; i < polygonum.Points.Length; i++)
            {
                xml.WriteStartElement("point" + i);
                xml.WriteString(polygonum.Points[i].X + " " + polygonum.Points[i].Y);
                xml.WriteEndElement();
            }
            xml.WriteStartElement("material");
            if (figure is PaperDecorator)
            {
                xml.WriteString("Paper");
                if (((IPaper)figure).Color != Colors.None)
                {
                    xml.WriteStartElement("color");
                    xml.WriteString($"{ ((IPaper)figure).Color }");
                    xml.WriteEndElement();
                }
            }
            else
                xml.WriteString("Film");
            xml.WriteEndElement();
            xml.WriteEndElement();
        }

        //Method which forming triangle for xml file.
        private static void FormTriangle(XmlWriter xml, Figure figure)
        {
            Triangle triangle = (Triangle)(((Decorator)figure).GetFigure());
            xml.WriteStartElement("figure");

            xml.WriteStartElement("type");
            xml.WriteString("Triangle");
            xml.WriteEndElement();
            xml.WriteStartElement("sideA");
            xml.WriteString($"{ triangle.A }");
            xml.WriteEndElement();
            xml.WriteStartElement("sideB");
            xml.WriteString($"{ triangle.B }");
            xml.WriteEndElement();
            xml.WriteStartElement("sideC");
            xml.WriteString($"{ triangle.C }");
            xml.WriteEndElement();
            xml.WriteStartElement("material");
            if (figure is PaperDecorator)
            {
                xml.WriteString("Paper");
                if (((IPaper)figure).Color != Colors.None)
                {
                    xml.WriteStartElement("color");
                    xml.WriteString($"{ ((IPaper)figure).Color }");
                    xml.WriteEndElement();
                }
            }
            else
                xml.WriteString("Film");
            xml.WriteEndElement();
            xml.WriteEndElement();
        }

        //Method which forming rectangle for xml file.
        private static void FormRectangle(XmlWriter xml, Figure figure)
        {
            Rectangle rectangle = (Rectangle)(((Decorator)figure).GetFigure());
            xml.WriteStartElement("figure");

            xml.WriteStartElement("type");
            xml.WriteString("Rectangle");
            xml.WriteEndElement();
            xml.WriteStartElement("sideA");
            xml.WriteString($"{ rectangle.A }");
            xml.WriteEndElement();
            xml.WriteStartElement("sideB");
            xml.WriteString($"{ rectangle.B }");
            xml.WriteEndElement();
            xml.WriteStartElement("material");
            if (figure is PaperDecorator)
            {
                xml.WriteString("Paper");
                if (((IPaper)figure).Color != Colors.None)
                {
                    xml.WriteStartElement("color");
                    xml.WriteString($"{ ((IPaper)figure).Color }");
                    xml.WriteEndElement();
                }
            }
            else
                xml.WriteString("Film");
            xml.WriteEndElement();
            xml.WriteEndElement();
        }
    }
}
