using System;

namespace University
{
    public interface IExam
    {
        //string[] GetSubjectName();
        //DateTime[] GetExamDate();

        //int GetIndexByName(string name);
        //int GetGroupByExamIndex(int id);

        /// <summary>
        /// Adding a new exam to the database.
        /// </summary>
        /// <param name="exam">A exam.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Insert(Exam exam);

        /// <summary>
        /// Getting a list of all exams from the database.
        /// </summary>
        /// <returns>All exams.</returns>
        Exam[] GetExams();

        /// <summary>
        /// Updating the exam to the database.
        /// </summary>
        /// <param name="nowExam">A current exam.</param>
        /// <param name="newExam">A new exam.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Update(Exam nowExam, Exam newExam);

        /// <summary>
        /// Deleting the grade to the database.
        /// </summary>
        /// <param name="exam">A exam.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Delete(Exam exam);

        //string GetGroupByExamIndex(int id);
    }
}
