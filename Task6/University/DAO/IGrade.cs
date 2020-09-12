namespace University
{
    /// <summary>
    /// The interface of the grade access object.
    /// </summary>
    public interface IGrade
    {
        //int[] GetGrades();

        //string GetExamByGradeIndex(int id);
        //string GetStudentByGradeIndex(int id);

        /// <summary>
        /// Adding a new grade to the database.
        /// </summary>
        /// <param name="grade">A grade.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Insert(Grades grade);

        /// <summary>
        /// Getting a list of all grades from the database.
        /// </summary>
        /// <returns>All grades.</returns>
        Grades[] GetGrades();

        /// <summary>
        /// Updating the grade to the database.
        /// </summary>
        /// <param name="nowGrade">A current grade.</param>
        /// <param name="newGrade">A new grade.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Update(Grades nowGrade, Grades newGrade);

        /// <summary>
        /// Updating the grade to the database.
        /// </summary>
        /// <param name="newGrade">A new grade.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Update(Grades newGrade);

        /// <summary>
        /// Deleting the grade to the database.
        /// </summary>
        /// <param name="grade">A grade.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Delete(Grades grade);

        /// <summary>
        /// Method which get grade by index.
        /// </summary>
        /// <param name="id">An int number.</param>
        /// <returns>Grades.</returns>
        Grades GetGradeByIndex(int id);
    }
}
