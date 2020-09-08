using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University;

namespace UniversityTest
{
    /// <summary>
    /// Test which checks CRUD methods.
    /// </summary>
    [TestClass]
    public class CRUDTest
    {
        /// <summary>
        /// Testing method which inserts data in the Exam table.
        /// </summary>
        [TestMethod]
        public void InsertExamTest()
        {
           string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Exam exam = new Exam("лит", new DateTime(2020, 6, 13), 2, "э", "л");
            MSSQLExamDAO mSSQLExamDAO = new MSSQLExamDAO(connectionString);
            Assert.IsTrue(mSSQLExamDAO.Insert(exam));
        }

        /// <summary>
        /// Testing method which inserts data in the Student table.
        /// </summary>
        [TestMethod]
        public void InsertStudentTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Student student = new Student("Жукова", "Анастасия", "Александровна", "ж", new DateTime(2001, 02, 19), 2);
            MSSQLStudentDAO mSSQLStudentDAO = new MSSQLStudentDAO(connectionString);
            Assert.IsTrue(mSSQLStudentDAO.Insert(student));
        }

        /// <summary>
        /// Testing method which inserts data in the Group table.
        /// </summary>
        [TestMethod]
        public void InsertGroupTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Group group = new Group("ПЗ-31");
            MSSQLGroupDAO mSSQLGroupDAO = new MSSQLGroupDAO(connectionString);
            Assert.IsTrue(mSSQLGroupDAO.Insert(group));
        }

        /// <summary>
        /// Testing method which inserts data in the Grades table.
        /// </summary>
        [TestMethod]
        public void InsertGradesTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Grades grades = new Grades(9, 1, 6);
            MSSQLGradesDAO mSSQLGradesDAO = new MSSQLGradesDAO(connectionString);
            Assert.IsTrue(mSSQLGradesDAO.Insert(grades));
        }

        /// <summary>
        /// Testing method which updates data in the Exam table.
        /// </summary>
        [TestMethod]
        public void UptadeExamTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Exam oldExam = new Exam("ООП", new DateTime(2020, 1, 11), 1, "э", "з");
            Exam newExam = new Exam("лит", new DateTime(2020, 6, 13), 2, "э", "л");
            MSSQLExamDAO mSSQLExamDAO = new MSSQLExamDAO(connectionString);
            Assert.IsTrue(mSSQLExamDAO.Update(oldExam, newExam));
        }

        /// <summary>
        /// Testing method which updates data in the Student table.
        /// </summary>
        [TestMethod]
        public void UptadeStudentTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Student oldStudent = new Student("Дубровский", "Александр", "Андреев", "м", new DateTime(2001, 4, 25), 1);
            Student newStudent = new Student("Жукова", "Анастасия", "Александровна", "ж", new DateTime(2001, 02, 19), 2);
            MSSQLStudentDAO mSSQLStudentDAO = new MSSQLStudentDAO(connectionString);
            Assert.IsTrue(mSSQLStudentDAO.Update(oldStudent, newStudent));
        }

        /// <summary>
        /// Testing method which updates data in the Group table.
        /// </summary>
        [TestMethod]
        public void UptadeGroupTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Group newGroup = new Group("ПЗ-31");
            Group oldGroup = new Group("ИТИ-31");
            MSSQLGroupDAO mSSQLGroupDAO = new MSSQLGroupDAO(connectionString);
            Assert.IsTrue(mSSQLGroupDAO.Update(oldGroup, newGroup));
        }

        /// <summary>
        /// Testing method which updates data in the Grades table.
        /// </summary>
        [TestMethod]
        public void UptadeGradesTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Grades oldGrades = new Grades(7, 9, 1);
            Grades newGrades = new Grades(9, 9, 1);
            MSSQLGradesDAO mSSQLGradesDAO = new MSSQLGradesDAO(connectionString);
            Assert.IsTrue(mSSQLGradesDAO.Update(oldGrades, newGrades));
        }

        /// <summary>
        /// Testing method which deletes data in the Exam table.
        /// </summary>
        [TestMethod]
        public void DeleteExamTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Exam exam = new Exam("лит", new DateTime(2020, 6, 13), 2, "э", "л");
            MSSQLExamDAO mSSQLExamDAO = new MSSQLExamDAO(connectionString);
            Assert.IsTrue(mSSQLExamDAO.Delete(exam));
        }

        /// <summary>
        /// Testing method which deletes data in the Student table.
        /// </summary>
        [TestMethod]
        public void DeleteStudentTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Student student = new Student("Жукова", "Анастасия", "Александровна", "ж", new DateTime(2001, 02, 19), 2);
            MSSQLStudentDAO mSSQLStudentDAO = new MSSQLStudentDAO(connectionString);
            Assert.IsTrue(mSSQLStudentDAO.Delete(student));
        }

        /// <summary>
        /// Testing method which deletes data in the Group table.
        /// </summary>
        [TestMethod]
        public void DeleteGroupTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Group group = new Group("ПЗ-31");
            MSSQLGroupDAO mSSQLGroupDAO = new MSSQLGroupDAO(connectionString);
            Assert.IsTrue(mSSQLGroupDAO.Delete(group));
        }

        /// <summary>
        /// Testing method which deletes data in the Grades table.
        /// </summary>
        [TestMethod]
        public void DeleteGradesTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            Grades grades = new Grades(9, 1, 6);
            MSSQLGradesDAO mSSQLGradesDAO = new MSSQLGradesDAO(connectionString);
            Assert.IsTrue(mSSQLGradesDAO.Delete(grades));
        }

        /// <summary>
        /// Testing method which reads data from the Exam table.
        /// </summary>
        [TestMethod]
        public void ReadExamTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            MSSQLExamDAO mSSQLExamDAO = new MSSQLExamDAO(connectionString);
            Assert.AreEqual(37, mSSQLExamDAO.GetExams().Length);
        }

        /// <summary>
        /// Testing method which reads data from the Student table.
        /// </summary>
        [TestMethod]
        public void ReadStudentTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            MSSQLStudentDAO mSSQLStudentDAO = new MSSQLStudentDAO(connectionString);
            Assert.AreEqual(16, mSSQLStudentDAO.GetStudents().Length);
        }

        /// <summary>
        /// Testing method which reads data from the Group table.
        /// </summary>
        [TestMethod]
        public void ReadGroupTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            MSSQLGroupDAO mSSQLGroupDAO = new MSSQLGroupDAO(connectionString);
            Assert.AreEqual(4, mSSQLGroupDAO.GetGroups().Length);
        }

        /// <summary>
        /// Testing method which reads data from the Grades table.
        /// </summary>
        [TestMethod]
        public void ReadGradesTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            MSSQLGradesDAO mSSQLGradesDAO = new MSSQLGradesDAO(connectionString);
            Assert.AreEqual(180, mSSQLGradesDAO.GetGrades().Length);
        }
    }
}
