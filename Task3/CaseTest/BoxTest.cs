using Case;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaseTest
{
    /// <summary>
    /// Class which tests Box class.
    /// </summary>
    [TestClass]
    public class BoxTest
    {
        /// <summary>
        /// Method tests adding figure with the help AddFigure method.
        /// </summary>
        [TestMethod]
        public void Test_AddFigure()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            Assert.AreEqual(new Circle(3), box.Figures[0]);
        }

        /// <summary>
        /// Method tests viewing figure by number with the help ViewFigure method.
        /// </summary>
        [TestMethod]
        public void Test_ViewFigure()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.AddFigure(new Rectangle(3, 10));
            Assert.AreEqual((new Rectangle(3, 10)).ToString(), box.ViewFigure(1));
        }

        /// <summary>
        /// Method tests extracting figure by number with the help ExtractFigure method.
        /// </summary>
        [TestMethod]
        public void Test_ExtractFigure()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.AddFigure(new Rectangle(3, 10));
            box.AddFigure(new Triangle(5, 3, 2));
            box.ExtractFigure(1);
            Assert.AreEqual(null, box.Figures[1]);
        }

        /// <summary>
        /// Method tests replacing figure by number with the help ReplaceFigure method.
        /// </summary>
        [TestMethod]
        public void Test_ReplaceFigure()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.AddFigure(new Rectangle(3, 10));
            box.AddFigure(new Triangle(5, 3, 2));
            box.ReplaceFigure(new Ellipse(3, 5), 2);
            Assert.AreEqual(new Ellipse(3, 5), box.Figures[2]);
        }

        /// <summary>
        /// Method tests searching for existing figure with the help SearchForFigure method.
        /// </summary>
        [TestMethod]
        public void Test_SearchForExistingFigure()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.AddFigure(new Rectangle(3, 10));
            box.AddFigure(new Triangle(5, 3, 2));
            Assert.AreEqual(0, box.SearchForFigure(new Circle(3)));
        }

        /// <summary>
        /// Method tests searching for nonexistent figure with the help SearchForFigure method.
        /// </summary>
        [TestMethod]
        public void Test_SearchForNonexistentFigure()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.AddFigure(new Rectangle(3, 10));
            box.AddFigure(new Triangle(5, 3, 2));
            Assert.AreEqual(-1, box.SearchForFigure(new Circle(10)));
        }

        /// <summary>
        /// Method tests showing the number of figures available with the help NumberOfFigures method.
        /// </summary>
        [TestMethod]
        public void Test_NumberOfFigures()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.AddFigure(new Rectangle(3, 10));
            box.AddFigure(new Triangle(5, 3, 2));
            box.ExtractFigure(2);
            box.AddFigure(new Ellipse(4, 2));
            Assert.AreEqual(3, box.NumberOfFigures());
        }

        /// <summary>
        /// Method tests calculating total square of figures with the help TotalSquare method.
        /// </summary>
        [TestMethod]
        public void Test_CalculateTotalSquare()
        {
            Box box = new Box();
            box.AddFigure(new Circle(2));
            box.AddFigure(new Rectangle(2, 10));
            box.AddFigure(new Triangle(5, 4, 3));
            Assert.AreEqual("38,57", box.TotalSquare().ToString("F"));
        }

        /// <summary>
        /// Method tests calculating total perimeter of figures with the help TotalPerimeter method.
        /// </summary>
        [TestMethod]
        public void Test_CalculateTotalPerimeter()
        {
            Box box = new Box();
            box.AddFigure(new Circle(2));
            box.AddFigure(new Rectangle(2, 10));
            box.AddFigure(new Triangle(5, 4, 3));
            Assert.AreEqual("48,57", box.TotalPerimeter().ToString("F")); 
        }

        /// <summary>
        /// Method tests geting all circles from box of figures with the help GetCircle method.
        /// </summary>
        [TestMethod]
        public void Test_GetCircle()
        {
            Box box = new Box();
            box.AddFigure(new Circle(2));
            box.AddFigure(new Rectangle(2, 10));
            box.AddFigure(new Triangle(5, 4, 3));
            box.AddFigure(new Circle(6));
            box.AddFigure(new Triangle(3, 3, 3));
            CollectionAssert.Equals(new Figure[] { new Circle(2), new Circle(6) }, box.GetCircle());
        }

        /// <summary>
        /// Method tests geting all film figures from box of figures with the help GetFilmFigures method.
        /// </summary>
        [TestMethod]
        public void Test_GetFilmFigures()
        {
            Box box = new Box();
            box.AddFigure(new PaperDecorator(new Circle(2), Colors.Blue));
            box.AddFigure(new FilmDecorator(new Rectangle(2, 10)));
            box.AddFigure(new PaperDecorator(new Triangle(5, 4, 3)));
            box.AddFigure(new FilmDecorator(new Circle(6)));
            box.AddFigure(new FilmDecorator(new Triangle(3, 3, 3)));
            CollectionAssert.Equals(new Figure[] { new FilmDecorator(new Rectangle(2, 10)),
                new FilmDecorator(new Circle(6)),
                new FilmDecorator(new Triangle(3, 3, 3)) }, box.GetFilmFigures());
        }
    }
}
