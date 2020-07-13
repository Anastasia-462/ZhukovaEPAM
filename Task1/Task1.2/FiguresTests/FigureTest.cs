using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using Figures.Factory;

namespace FiguresTests
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void Test_FormingArrayFigures()
        {
            Parser parser = new Parser("test.txt");
            Figure[] figures = parser.FormingArrayOfFigure();    

            CollectionAssert.Equals("Square : SideA = 10 S = 100 P = 40\n" +
                "Circle: R = 5S = 78, 5398163397448 P = 31, 4159265358979\n" +
                "Circle: R = 6S = 113, 097335529233 P = 37, 6991118430775\n" +
                "Square: SideA = 10 S = 100 P = 40\n" +
                "Polygonum: Side 1: x = 0, 6 y = 2, 1\nSide 2: x = 1, 8 y = 3, 6\n" +
                "Side 3: x = 2, 2 y = 2, 3\nSide 4: x = 3, 6 y = 2, 4\n" +
                "Side 5: x = 3, 1 y = 0, 5\nS = 3, 915 P = 9, 61750389323523\n", figures);
        }

        [TestMethod]
        public void Test_SearchIdenticalFigures()
        {
            Parser parser = new Parser("test.txt");
            var actual = parser.SearchIdenticalFigures();
            Assert.AreEqual("Identical figures: Square : SideA = 10 S = 100 P = 40 AND Square : SideA = 10 S = 100 P = 40\n", actual);
        }

        [TestMethod]
        public void Test_SearchNoIdenticalFigures()
        {
            Parser parser = new Parser("test1.txt");
            var actual = parser.SearchIdenticalFigures();
            Assert.AreEqual("There are no identical figures!\n", actual);
        }

        [TestMethod]
        public void Test_CreatorCircle()
        {
            Creator circle = new CreatorCircle(5);
            bool actual = (circle.CreateFigure()) is Circle;
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_CreatorEllipse()
        {
            Creator ellipse = new CreatorEllipse(5, 6);
            bool actual = (ellipse.CreateFigure()) is Ellipse;
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_CreatorNoEllipse()
        {
            Creator circle = new CreatorCircle(5);
            bool actual = (circle.CreateFigure()) is Ellipse;
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_CreatorPolygonum()
        {
            Point[] points = new Point[] { new Point(1, 2), new Point(2, 4),
                new Point(2, 2), new Point(4, 2), new Point(3, 1) };
            Creator polygonum = new CreatorPolygonum(points);
            bool actual = (polygonum.CreateFigure()) is Polygonum;
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_CreatorRectangle()
        {
            Creator rectangle = new CreatorRectangle(5, 9);
            bool actual = (rectangle.CreateFigure()) is Rectangle;
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_CreatorRhombus()
        {
            Creator rhombus = new CreatorRhombus(5, 9);
            bool actual = (rhombus.CreateFigure()) is Rhombus;
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_CreatorSquare()
        {
            Creator square = new CreatorSquare(2);
            bool actual = (square.CreateFigure()) is Square;
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_CreatorTrapeze()
        {
            Creator trapeze = new CreatorTrapeze(2, 4, 3, 10);
            bool actual = (trapeze.CreateFigure()) is Trapeze;
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_CreatorTriangle()
        {
            Creator triangle = new CreatorTriangle(2, 4, 3);
            bool actual = (triangle.CreateFigure()) is Triangle;
            Assert.IsTrue(actual);
        }
    }
}
