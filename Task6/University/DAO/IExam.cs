﻿namespace University
{
    /// <summary>
    /// The interface of the grade access object.
    /// </summary>
    public interface IExam
    {
        /// <summary>
        /// Method which get index by exam.
        /// </summary>
        /// <param name="exam">Exam.</param>
        /// <returns>An int number.</returns>
        int GetIdExam(Exam exam);

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

        /// <summary>
        /// Method which get exam by index.
        /// </summary>
        /// <param name="id">An int number.</param>
        /// <returns>Exam.</returns>
        Exam GetExamByIndex(int id);
    }
}
