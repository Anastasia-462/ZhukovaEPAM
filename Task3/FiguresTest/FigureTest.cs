using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresTest
{
    /// <summary>
    /// Class which tests exeptions in the Figures library.
    /// </summary>
    [TestClass]
    public class FigureTest
    {
        /// <summary>
        /// Methos tests painting colored figure with the help PaintFigure method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "The figure is already colored.")]
        public void Test_PaintedColoredFigure()
        {
            Figure circle = new PaperDecorator(new Circle(6), Colors.Green);
            Figure.PaintFigure(circle, Colors.Blue);
        }

        /// <summary>
        /// Methos tests painting film figure with the help PaintFigure method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "The figure of the wrap cannot be colored.")]
        public void Test_PaintedFilmFigure()
        {
            Figure circle = new FilmDecorator(new Circle(6));
            Figure.PaintFigure(circle, Colors.Blue);
        }

        /// <summary>
        /// Methos tests painting figure with the help PaintFigure method.
        /// </summary>
        [TestMethod]
        public void Test_PaintedFigure()
        {
            Figure circle = new PaperDecorator(new Circle(6));
            //Figure.PaintFigure(circle, Colors.Blue);
            Assert.AreEqual(new PaperDecorator(new Circle(6), Colors.Blue), Figure.PaintFigure(circle, Colors.Blue));
        }

        /// <summary>
        /// Methos tests cutting big circle from small triangle.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "It's not possible to cut a figure from this one.")]
        public void Test_CutCircleFromTriangle()
        {
            Circle circle = new Circle(60);
            Triangle triangle = new Triangle(1, 1, 1);
            triangle = new Triangle(circle);
        }

        /// <summary>
        /// Method tests PaperDecorator.
        /// </summary>
        [TestMethod]
        public void Test_PaperFigureDecoration()
        {
            Figure circle1 = new Circle(6);
            Figure circle2 = new Circle(6);
            PaperDecorator paperDecorator = new PaperDecorator(circle2);
            Assert.AreEqual(circle1, paperDecorator.GetFigure());
        }

        /// <summary>
        /// Method tests FilmDecorator.
        /// </summary>
        [TestMethod]
        public void Test_FilmFigureDecoration()
        {
            Figure circle1 = new Circle(6);
            Figure circle2 = new Circle(6);
            FilmDecorator filmDecorator = new FilmDecorator(circle2);
            Assert.AreEqual(circle1, filmDecorator.GetFigure());
        }
    }
}
