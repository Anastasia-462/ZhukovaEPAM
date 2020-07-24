using Figures;
using System.IO;

namespace XmlProcessing
{
    /// <summary>
    /// Class which write xml file with the help StreamWriter.
    /// </summary>
    public static class StreamFigureWriter
    {
        /// <summary>
        /// The main method which processing xml file.
        /// </summary>
        public static void XmlStreamWriting(Figure[] figures)
        {
            using (StreamWriter stream = new StreamWriter("Figures.xml"))
            {
                stream.WriteLine("<?xml version=" + "1.0" + " encoding=" + "utf - 8" + "?>");
                stream.WriteLine("<figures>");
                for(int i = 0; i < figures.Length; i++)
                {
                    stream.WriteLine("\t<figure>");
                    SelectingFigure(stream, figures[i]);
                    stream.WriteLine("\t</figure>");
                }
            }
        }

        //Method which sets the method for processing the figure.
        private static void SelectingFigure(StreamWriter stream, Figure figure)
        {
            switch (figure.TypeExist().ToString())
            {
                case "Figures.Circle":
                    FormCircle(stream, figure);
                    break;
                case "Figures.Ellipse":
                    FormEllipse(stream, figure);
                    break;
                case "Figures.Polygonum":
                    FormPolygonum(stream, figure);
                    break;
                case "Figures.Rectangle":
                    FormRectangle(stream, figure);
                    break;
                case "Figures.Triangle":
                    FormTriangle(stream, figure);
                    break;
            }
        }

        //Method which forming circle for xml file.
        private static void FormCircle(StreamWriter stream, Figure figure)
        {
            Circle circle = (Circle)(((Decorator)figure).GetFigure());
            stream.WriteLine("\t\t<type>" + "Circle" + "</type>");
            stream.WriteLine("\t\t<radius>" + circle.Radius + "</radius>");
            FormCharacteristics(stream, figure);
        }

        //Method which forming ellipse for xml file.
        private static void FormEllipse(StreamWriter stream, Figure figure)
        {
            Ellipse ellipse = (Ellipse)(((Decorator)figure).GetFigure());
            stream.WriteLine("\t\t<type>" + "Ellipse" + "</type>");
            stream.WriteLine("\t\t<diagonalA>" + ellipse.DiagonalA + "</diagonalA>");
            stream.WriteLine("\t\t<diagonalB>" + ellipse.DiagonalB + "</diagonalB>");
            FormCharacteristics(stream, figure);
        }

        //Method which forming polygonum for xml file.
        private static void FormPolygonum(StreamWriter stream, Figure figure)
        {
            Polygonum polygonum = (Polygonum)(((Decorator)figure).GetFigure());
            stream.WriteLine("\t\t<type>" + "Polygonum" + "</type>");
            for (int i = 0; i < polygonum.Points.Length; i++)
            {
                stream.Write("\t\t<point" + i + ">");
                stream.Write(polygonum.Points[i].X + " " + polygonum.Points[i].Y);
                stream.Write("</point" + i + ">");
            }
            FormCharacteristics(stream, figure);
        }

        //Method which forming rectangle for xml file.
        private static void FormRectangle(StreamWriter stream, Figure figure)
        {
            Rectangle rectangle = (Rectangle)(((Decorator)figure).GetFigure());
            stream.WriteLine("\t\t<type>" + "Rectangle" + "</type>");
            stream.WriteLine("\t\t<sideA>" + rectangle.A + "</sideA>");
            stream.WriteLine("\t\t<sideB>" + rectangle.B + "</sideB>");
            FormCharacteristics(stream, figure);
        }

        //Method which forming triangle for xml file.
        private static void FormTriangle(StreamWriter stream, Figure figure)
        {
            Triangle triangle = (Triangle)(((Decorator)figure).GetFigure());
            stream.WriteLine("\t\t<type>" + "Triangle" + "</type>");
            stream.WriteLine("\t\t<sideA>" + triangle.A + "</sideA>");
            stream.WriteLine("\t\t<sideB>" + triangle.B + "</sideB>");
            stream.WriteLine("\t\t<sideC>" + triangle.C + "</sideC>");
            FormCharacteristics(stream, figure);
        }

        //Method which forming material and color for the figure.
        private static void FormCharacteristics(StreamWriter stream, Figure figure)
        {
            stream.Write("\t\t<material>");
            if (figure is PaperDecorator)
            {
                stream.Write("Paper" + "</material>");
                if (((IPaper)figure).Color != Colors.None)
                    stream.WriteLine("\t\t<color>" + ((IPaper)figure).Color + "</color>");
            }
            else
                stream.WriteLine("Film" + "</material>");
        }
    }
}
