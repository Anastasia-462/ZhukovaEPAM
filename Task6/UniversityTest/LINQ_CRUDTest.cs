using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University;

namespace UniversityTest
{
    /// <summary>
    /// Test which checks CRUD methods.
    /// </summary>
    [TestClass]
    public class LINQ_CRUDTest
    {
        /// <summary>
        /// Testing method which reads data from the Exam table.
        /// </summary>
        [TestMethod]
        public void ReadExamTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            LINQExamDAO lINQExam = new LINQExamDAO(connectionString);
            Assert.AreEqual(36, lINQExam.GetExams().Length);
        }

        /// <summary>
        /// Testing method which inserts data in the Exam table.
        /// </summary>
        [TestMethod]
        public void InsertExamTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Exam exam = new Exam("лит", new DateTime(2020, 6, 13), 2, "э", "л", "RH", "TY", "TR");
            LINQExamDAO lINQExam = new LINQExamDAO(connectionString);
            Assert.IsTrue(lINQExam.Insert(exam));
        }

        /// <summary>
        /// Testing method which updates data in the Exam table.
        /// </summary>
        [TestMethod]
        public void UptadeExamTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Exam newExam = new Exam(36, "история", new DateTime(2020, 6, 14), 3, "э", "л", "Мешкин", "Петр", "Эдуардович");
            LINQExamDAO lINQExam = new LINQExamDAO(connectionString);
            Assert.IsTrue(lINQExam.Update(newExam));
        }

        /// <summary>
        /// Testing method which deletes data in the Exam table.
        /// </summary>
        [TestMethod]
        public void DeleteExamTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Exam exam = new Exam(1002, "лит", new DateTime(2020, 6, 13), 2, "э", "л", "RH", "TY", "TR");
            LINQExamDAO lINQExam = new LINQExamDAO(connectionString);
            Assert.IsTrue(lINQExam.Delete(exam));
        }


        /// <summary>
        /// Testing method which reads data from the Group table.
        /// </summary>
        [TestMethod]
        public void ReadGroupTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            LINQGroupDAO lINQGroup = new LINQGroupDAO(connectionString);
            Assert.AreEqual(5, lINQGroup.GetGroups().Length);
        }

        /// <summary>
        /// Testing method which inserts data in the Group table.
        /// </summary>
        [TestMethod]
        public void InsertGroupTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Groups group = new Groups("ПИ-11", "Игровая индустрия");
            LINQGroupDAO lINQGroup = new LINQGroupDAO(connectionString);
            Assert.IsTrue(lINQGroup.Insert(group));
        }

        /// <summary>
        /// Testing method which updates data in the Group table.
        /// </summary>
        [TestMethod]
        public void UptadeGroupTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Groups newGroup = new Groups(3, "ИТИ-11", "Игровая индустрия");
            LINQGroupDAO lINQGroup = new LINQGroupDAO(connectionString);
            Assert.IsTrue(lINQGroup.Update(newGroup));
        }

        /// <summary>
        /// Testing method which deletes data in the Group table.
        /// </summary>
        [TestMethod]
        public void DeleteGroupTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Groups group = new Groups(1002, "ПИ-11", "Игровая индустрия");
            LINQGroupDAO lINQGroup = new LINQGroupDAO(connectionString);
            Assert.IsTrue(lINQGroup.Delete(group));
        }



        /// <summary>
        /// Testing method which reads data from the Grades table.
        /// </summary>
        [TestMethod]
        public void ReadGradesTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            LINQGradesDAO lINQGrades = new LINQGradesDAO(connectionString);
            Assert.AreEqual(181, lINQGrades.GetGrades().Length);
        }

        /// <summary>
        /// Testing method which inserts data in the Grades table.
        /// </summary>
        [TestMethod]
        public void InsertGradesTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Grades grade = new Grades(9, 1, 1);
            LINQGradesDAO lINQGrades = new LINQGradesDAO(connectionString);
            Assert.IsTrue(lINQGrades.Insert(grade));
        }

        /// <summary>
        /// Testing method which updates data in the Grades table.
        /// </summary>
        [TestMethod]
        public void UptadeGradesTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Grades newGrades = new Grades(1, 10, 1, 1);
            LINQGradesDAO lINQGrades = new LINQGradesDAO(connectionString);
            Assert.IsTrue(lINQGrades.Update(newGrades));
        }

        /// <summary>
        /// Testing method which deletes data in the Grades table.
        /// </summary>
        [TestMethod]
        public void DeleteGradesTests()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Grades grade = new Grades(181, 9, 1, 1);
            LINQGradesDAO lINQGrades = new LINQGradesDAO(connectionString);
            Assert.IsTrue(lINQGrades.Delete(grade));
        }


        /// <summary>
        /// Testing method which reads data from the Students table.
        /// </summary>
        [TestMethod]
        public void ReadStudentTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            LINQStudentDAO lINQStudent = new LINQStudentDAO(connectionString);
            Assert.AreEqual(16, lINQStudent.GetStudents().Length);
        }

        /// <summary>
        /// Testing method which inserts data in the Students table.
        /// </summary>
        [TestMethod]
        public void InsertStudentTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Students students = new Students("Шерон", "Андрей", "Даниилович", "м", new DateTime(2001, 12, 5), 4);
            LINQStudentDAO lINQStudent = new LINQStudentDAO(connectionString);
            Assert.IsTrue(lINQStudent.Insert(students));
        }

        /// <summary>
        /// Testing method which updates data in the Students table.
        /// </summary>
        [TestMethod]
        public void UptadeStudentTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Students newStudents = new Students(1002, "Митрохон", "Антон", "Даниилович", "м", new DateTime(2001, 12, 5), 4);
            LINQStudentDAO lINQStudent = new LINQStudentDAO(connectionString);
            Assert.IsTrue(lINQStudent.Update(newStudents));
        }

        /// <summary>
        /// Testing method which deletes data in the Students table.
        /// </summary>
        [TestMethod]
        public void DeleteStudentTest()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityNew;Integrated Security=True";
            Students student = new Students(1002, "Митрохон", "Антон", "Даниилович", "м", new DateTime(2001, 12, 5), 4);
            LINQStudentDAO lINQStudent = new LINQStudentDAO(connectionString);
            Assert.IsTrue(lINQStudent.Delete(student));
        }
        
    }
}
