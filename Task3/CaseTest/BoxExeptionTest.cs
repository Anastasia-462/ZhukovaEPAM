using System;
using Case;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaseTest
{
    /// <summary>
    /// Class which tests exeptions in the Box class.
    /// </summary>
    [TestClass]
    public class BoxExeptionTest
    {
        /// <summary>
        /// Method tests catching an exeption when adding the same figures in AddFigure method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "This figure already exists.")]
        public void Test_AddExistingFigure()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.AddFigure(new Circle(3));
        }

        /// <summary>
        /// Method tests catching an exeption when trying to add a figure to a full box in AddFigure method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "You can't add a figure because the box is full.")]
        public void Test_AddFigureToFullBox()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.AddFigure(new Circle(2));            
            box.AddFigure(new Rectangle(3, 10));
            box.AddFigure(new Circle(10));
            box.AddFigure(new Triangle(5, 3, 2));
            box.AddFigure(new Triangle(3, 3, 3));
            box.AddFigure(new Rectangle(3, 10));
            box.AddFigure(new Circle(5));
            box.AddFigure(new Triangle(5, 3, 3));
            box.AddFigure(new Triangle(6, 6, 6));

            box.AddFigure(new Circle(1));
            box.AddFigure(new Circle(4.2));
            box.AddFigure(new Rectangle(81, 10));
            box.AddFigure(new Circle(15));
            box.AddFigure(new Triangle(6, 4, 3));
            box.AddFigure(new Triangle(7, 6, 3));
            box.AddFigure(new Rectangle(5, 2));
            box.AddFigure(new Circle(21));
            box.AddFigure(new Triangle(8, 6, 4));
            box.AddFigure(new Triangle(3, 3, 1));

            box.AddFigure(new Circle(16));
        }

        /// <summary>
        /// Method tests catching an exeption when trying to view a nonexistent figure in ViewFigure method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "There is no figure for this number.")]
        public void Test_ViewNonexistentFigure()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.ViewFigure(1);
        }

        /// <summary>
        /// Method tests catching an exeption when trying to extract a nonexistent figure in ExtractFigure method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "There is no figure for this number.")]
        public void Test_ExtractNonexistentFigure()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.ExtractFigure(1);
        }

        /// <summary>
        /// Method tests catching an exeption when trying to replace a nonexistent figure in ReplaceFigure method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "There is no figure for this number.")]
        public void Test_ReplaceNonexistentFigure()
        {
            Box box = new Box();
            box.AddFigure(new Circle(3));
            box.ReplaceFigure(new Rectangle(5, 7), 1);
        }
    }
}
