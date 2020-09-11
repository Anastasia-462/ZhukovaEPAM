using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Linq;

namespace University
{
    /// <summary>
    /// DAO exams for LINQ DBMS.
    /// </summary>
    public class LINQExamDAO : IExam
    {
        DataContext dataContext;

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="connectionString">A string value.</param>
        public LINQExamDAO(string connectionString)
        {
            dataContext = new DataContext(connectionString);
        }

        /// <summary>
        /// Removing a exam from the database.
        /// </summary>
        /// <param name="exam">Exam.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Delete(Exam exam)
        {
            dataContext.GetTable<Exam>().DeleteOnSubmit(exam);
            dataContext.SubmitChanges();
            return true;
        }

        /// <summary>
        /// Method which get exam by index.
        /// </summary>
        /// <param name="id">An int number.</param>
        /// <returns>Exam.</returns>
        public Exam GetExamByIndex(int id)
        {
            var query = from ex in dataContext.GetTable<Exam>()
                        where ex.ExamId == id
                        select ex;
            return query.First();
        }

        /// <summary>
        /// Getting a list of all exams from the database.
        /// </summary>
        /// <returns>All exams in the database.</returns>
        public Exam[] GetExams()
        {
            Table<Exam> exams = dataContext.GetTable<Exam>();
            return exams.ToArray();
        }

        /// <summary>
        /// Method which get index by exam.
        /// </summary>
        /// <param name="exam">Exam.</param>
        /// <returns>An int number.</returns>
        public int GetIdExam(Exam exam)
        {
            var query = from ex in dataContext.GetTable<Exam>()
                        where ex.SubjectName == exam.SubjectName &&
                        ex.GroupId == exam.GroupId && ex.TeacherSurname == exam.TeacherSurname
                        select ex.ExamId;
            return query.First();
        }

        /// <summary>
        /// Adding a exam to the database.
        /// </summary>
        /// <param name="exam">Exam.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Insert(Exam exam)
        {
            dataContext.GetTable<Exam>().InsertOnSubmit(exam);
            dataContext.SubmitChanges();
            return true;
        }

        /// <summary>
        /// Updating the exam in the database.
        /// </summary>
        /// <param name="nowExam">Exam for renewal.</param>
        /// <param name="newExam">New exam.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Update(Exam nowExam, Exam newExam)
        {
            nowExam.AssessmentForm = newExam.AssessmentForm;
            nowExam.SubjectName = newExam.SubjectName;
            nowExam.ExamDate = newExam.ExamDate;
            nowExam.Session = newExam.Session;
            nowExam.GroupId = newExam.GroupId;
            nowExam.TeacherSurname = newExam.TeacherSurname;
            nowExam.TeacherName = newExam.TeacherName;
            nowExam.TeacherMiddleName = newExam.TeacherMiddleName;
            dataContext.SubmitChanges();
            return true;
        }
    }
}
