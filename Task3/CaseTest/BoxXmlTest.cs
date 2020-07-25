using System;
using System.Collections.Generic;
using System.IO;
using Case;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaseTest
{
    /// <summary>
    /// Class which tests work with xml file in the Box class.
    /// </summary>
    [TestClass]
    public class BoxXmlTest
    {
        /// <summary>
        /// Method tests saving array of figures with the help StreamWriter.
        /// </summary>
        [TestMethod]
        public void Test_SaveAllFiguresSW()
        {
            Box box = new Box();
            Point[] points = new Point[]
            { 
                new Point(0.6, 2.1), new Point(1.8, 3.6),
                new Point(2.2, 2.3), new Point(3.6, 2.4),
                new Point(3.1, 0.5) 
            };
            box.AddFigure(new PaperDecorator(new Circle(3), Colors.Blue));
            box.AddFigure(new PaperDecorator(new Triangle(3, 2, 1)));
            box.AddFigure(new FilmDecorator(new Rectangle(5, 7)));
            box.AddFigure(new PaperDecorator(new Ellipse(3, 6), Colors.Red));
            box.AddFigure(new FilmDecorator(new Ellipse(8, 4)));
            box.AddFigure(new FilmDecorator(new Circle(6)));
            box.AddFigure(new FilmDecorator(new Polygonum(points)));
            box.SaveAllFiguresSW("Test.xml");
            StreamReader sr1 = new StreamReader("Test.xml");            
            StreamReader sr2 = new StreamReader("Figures1.xml");
            
            Assert.AreEqual(sr1.ReadToEnd(), sr2.ReadToEnd());
            sr1.Close();
            sr2.Close();
        }

        /// <summary>
        /// Method tests saving only paper figures with the help StreamWriter.
        /// </summary>
        [TestMethod]
        public void Test_SavePaperFiguresSW()
        {
            Box box = new Box();
            Point[] points = new Point[]
            {
                new Point(0.6, 2.1), new Point(1.8, 3.6),
                new Point(2.2, 2.3), new Point(3.6, 2.4),
                new Point(3.1, 0.5)
            };
            box.AddFigure(new PaperDecorator(new Circle(3), Colors.Blue));
            box.AddFigure(new PaperDecorator(new Triangle(3, 2, 1)));
            box.AddFigure(new FilmDecorator(new Rectangle(5, 7)));
            box.AddFigure(new PaperDecorator(new Ellipse(3, 6), Colors.Red));
            box.AddFigure(new FilmDecorator(new Ellipse(8, 4)));
            box.AddFigure(new FilmDecorator(new Circle(6)));
            box.AddFigure(new FilmDecorator(new Polygonum(points)));
            box.SavePaperFiguresSW("Test.xml");
            StreamReader sr1 = new StreamReader("Test.xml");
            StreamReader sr2 = new StreamReader("PaperFigures.xml");

            Assert.AreEqual(sr1.ReadToEnd(), sr2.ReadToEnd());
            sr1.Close();
            sr2.Close();
        }

        /// <summary>
        /// Method tests saving only film figures with the help StreamWriter.
        /// </summary>
        [TestMethod]
        public void Test_SaveFilmFiguresSW()
        {
            Box box = new Box();
            Point[] points = new Point[]
            {
                new Point(0.6, 2.1), new Point(1.8, 3.6),
                new Point(2.2, 2.3), new Point(3.6, 2.4),
                new Point(3.1, 0.5)
            };
            box.AddFigure(new PaperDecorator(new Circle(3), Colors.Blue));
            box.AddFigure(new PaperDecorator(new Triangle(3, 2, 1)));
            box.AddFigure(new FilmDecorator(new Rectangle(5, 7)));
            box.AddFigure(new PaperDecorator(new Ellipse(3, 6), Colors.Red));
            box.AddFigure(new FilmDecorator(new Ellipse(8, 4)));
            box.AddFigure(new FilmDecorator(new Circle(6)));
            box.AddFigure(new FilmDecorator(new Polygonum(points)));
            box.SaveFilmFiguresSW("Test.xml");
            StreamReader sr1 = new StreamReader("Test.xml");
            StreamReader sr2 = new StreamReader("FilmFigures.xml");

            Assert.AreEqual(sr1.ReadToEnd(), sr2.ReadToEnd());
            sr1.Close();
            sr2.Close();
        }

        /// <summary>
        /// Method tests saving array of figures with the help XmlWriter.
        /// </summary>
        [TestMethod]
        public void Test_SaveAllFiguresXW()
        {
            Box box = new Box();
            Point[] points = new Point[]
            {
                new Point(0.6, 2.1), new Point(1.8, 3.6),
                new Point(2.2, 2.3), new Point(3.6, 2.4),
                new Point(3.1, 0.5)
            };
            box.AddFigure(new PaperDecorator(new Circle(3), Colors.Blue));
            box.AddFigure(new PaperDecorator(new Triangle(3, 2, 1)));
            box.AddFigure(new FilmDecorator(new Rectangle(5, 7)));
            box.AddFigure(new PaperDecorator(new Ellipse(3, 6), Colors.Red));
            box.AddFigure(new FilmDecorator(new Ellipse(8, 4)));
            box.AddFigure(new FilmDecorator(new Circle(6)));
            box.AddFigure(new FilmDecorator(new Polygonum(points)));
            box.SaveAllFiguresXW("Test.xml");
            StreamReader sr1 = new StreamReader("Test.xml");
            StreamReader sr2 = new StreamReader("Figures1.xml");

            Assert.AreEqual(sr1.ReadToEnd(), sr2.ReadToEnd());
            sr1.Close();
            sr2.Close();
        }

        /// <summary>
        /// Method tests saving only paper figures with the help XmlWriter.
        /// </summary>
        [TestMethod]
        public void Test_SavePaperFiguresXW()
        {
            Box box = new Box();
            Point[] points = new Point[]
            {
                new Point(0.6, 2.1), new Point(1.8, 3.6),
                new Point(2.2, 2.3), new Point(3.6, 2.4),
                new Point(3.1, 0.5)
            };
            box.AddFigure(new PaperDecorator(new Circle(3), Colors.Blue));
            box.AddFigure(new PaperDecorator(new Triangle(3, 2, 1)));
            box.AddFigure(new FilmDecorator(new Rectangle(5, 7)));
            box.AddFigure(new PaperDecorator(new Ellipse(3, 6), Colors.Red));
            box.AddFigure(new FilmDecorator(new Ellipse(8, 4)));
            box.AddFigure(new FilmDecorator(new Circle(6)));
            box.AddFigure(new FilmDecorator(new Polygonum(points)));
            box.SavePaperFiguresXW("Test.xml");
            StreamReader sr1 = new StreamReader("Test.xml");
            StreamReader sr2 = new StreamReader("PaperFigures.xml");

            Assert.AreEqual(sr1.ReadToEnd(), sr2.ReadToEnd());
            sr1.Close();
            sr2.Close();
        }

        /// <summary>
        /// Method tests saving only film figures with the help XmlWriter.
        /// </summary>
        [TestMethod]
        public void Test_SaveFilmFiguresXW()
        {
            Box box = new Box();
            Point[] points = new Point[]
            {
                new Point(0.6, 2.1), new Point(1.8, 3.6),
                new Point(2.2, 2.3), new Point(3.6, 2.4),
                new Point(3.1, 0.5)
            };
            box.AddFigure(new PaperDecorator(new Circle(3), Colors.Blue));
            box.AddFigure(new PaperDecorator(new Triangle(3, 2, 1)));
            box.AddFigure(new FilmDecorator(new Rectangle(5, 7)));
            box.AddFigure(new PaperDecorator(new Ellipse(3, 6), Colors.Red));
            box.AddFigure(new FilmDecorator(new Ellipse(8, 4)));
            box.AddFigure(new FilmDecorator(new Circle(6)));
            box.AddFigure(new FilmDecorator(new Polygonum(points)));
            box.SaveFilmFiguresXW("Test.xml");
            StreamReader sr1 = new StreamReader("Test.xml");
            StreamReader sr2 = new StreamReader("FilmFigures.xml");

            Assert.AreEqual(sr1.ReadToEnd(), sr2.ReadToEnd());
            sr1.Close();
            sr2.Close();
        }

        /// <summary>
        /// Method tests downloading figures to the xml file with the help StreamReader.
        /// </summary>
        [TestMethod]
        public void Test_DownloadFiguresSR()
        {
            Box box1 = new Box();
            box1.DownloadFiguresSR("Figures1.xml");
            Box box2 = new Box();
            Point[] points = new Point[]
            {
                new Point(0.6, 2.1), new Point(1.8, 3.6),
                new Point(2.2, 2.3), new Point(3.6, 2.4),
                new Point(3.1, 0.5)
            };
            box2.AddFigure(new PaperDecorator(new Circle(3), Colors.Blue));
            box2.AddFigure(new PaperDecorator(new Triangle(3, 2, 1)));
            box2.AddFigure(new FilmDecorator(new Rectangle(5, 7)));
            box2.AddFigure(new PaperDecorator(new Ellipse(3, 6), Colors.Red));
            box2.AddFigure(new FilmDecorator(new Ellipse(8, 4)));
            box2.AddFigure(new FilmDecorator(new Circle(6)));
            box2.AddFigure(new FilmDecorator(new Polygonum(points)));

            Assert.AreEqual(box2.ToString(), box1.ToString());
        }

        /// <summary>
        /// Method tests downloading figures to the xml file with the help XmlReader.
        /// </summary>
        [TestMethod]
        public void Test_DownloadFiguresXR()
        {
            Box box1 = new Box();
            box1.DownloadFiguresXR("Figures1.xml");
            Box box2 = new Box();
            Point[] points = new Point[]
            {
                new Point(0.6, 2.1), new Point(1.8, 3.6),
                new Point(2.2, 2.3), new Point(3.6, 2.4),
                new Point(3.1, 0.5)
            };
            box2.AddFigure(new PaperDecorator(new Circle(3), Colors.Blue));
            box2.AddFigure(new PaperDecorator(new Triangle(3, 2, 1)));
            box2.AddFigure(new FilmDecorator(new Rectangle(5, 7)));
            box2.AddFigure(new PaperDecorator(new Ellipse(3, 6), Colors.Red));
            box2.AddFigure(new FilmDecorator(new Ellipse(8, 4)));
            box2.AddFigure(new FilmDecorator(new Circle(6)));
            box2.AddFigure(new FilmDecorator(new Polygonum(points)));

            Assert.AreEqual(box2.ToString(), box1.ToString());
        }
    }
}
