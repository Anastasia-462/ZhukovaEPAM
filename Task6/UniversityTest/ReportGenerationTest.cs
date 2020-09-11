using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University;

namespace UniversityTest
{
    /// <summary>
    /// Test which checks ReportGeneration class.
    /// </summary>
    [TestClass]
    public class ReportGenerationTest
    {
        /// <summary>
        /// Testing method which forms summary table.
        /// </summary>
        [TestMethod]
        public void FormSummaryTableTest()
        {
            Assert.IsTrue(ReportGeneration.FormSummaryTable());
        }

        /// <summary>
        /// Testing method which counts expelled students for the summer session.
        /// </summary>
        [TestMethod]
        public void FormListOfExpelledStudentsSummerTest()
        {
            Assert.AreEqual(3, ReportGeneration.FormListOfExpelledStudents("л").Count);
        }

        /// <summary>
        /// Testing method which counts expelled students for the winter session.
        /// </summary>
        [TestMethod]
        public void FormListOfExpelledStudentsWinterTest()
        {
            Assert.AreEqual(3, ReportGeneration.FormListOfExpelledStudents("з").Count);
        }

        /// <summary>
        /// Testing method which form outcome of session and sort by gender.
        /// </summary>
        [TestMethod]
        public void OutcomeOfSessionGenderSortTest()
        {
            Assert.IsTrue(ReportGeneration.OutcomeOfSession(Sorting.SortGender));
        }

        /// <summary>
        /// Testing method which form outcome of session and sort by surname.
        /// </summary>
        [TestMethod]
        public void OutcomeOfSessionSurnameSortTest()
        {
            Assert.IsTrue(ReportGeneration.OutcomeOfSession(Sorting.SortSurmame));
        }

        /// <summary>
        /// Testing method which form outcome of session and sort by date of birth.
        /// </summary>
        [TestMethod]
        public void OutcomeOfSessionDateOfBirthSortTest()
        {
            Assert.IsTrue(ReportGeneration.OutcomeOfSession(Sorting.SortDateOfBirth));
        }



        /// <summary>
        /// Testing method which form outcome of session and sort by gender.
        /// </summary>
        [TestMethod]
        public void SessionGenderSortTest()
        {
            Assert.IsTrue(ReportGeneration.SpecialtyTable());
        }
    }
}
