namespace University
{
    /// <summary>
    /// The interface of the student access object.
    /// </summary>
    public interface IStudent
    {
        /// <summary>
        /// Method which gets student id.
        /// </summary>
        /// <param name="student">Student.</param>
        /// <returns>An int value.</returns>
        int GetIdStudent(Students student);

        /// <summary>
        /// Adding a new student to the database.
        /// </summary>
        /// <param name="student">A student.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Insert(Students student);

        /// <summary>
        /// Getting a list of all students from the database.
        /// </summary>
        /// <returns>All students.</returns>
        Students[] GetStudents();

        /// <summary>
        /// Updating the student to the database.
        /// </summary>
        /// <param name="nowStudent">A current student.</param>
        /// <param name="newStudent">A new student.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Update(Students nowStudent, Students newStudent);

        /// <summary>
        /// Updating the student to the database.
        /// </summary>
        /// <param name="newStudent">A new student.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Update(Students newStudent);

        /// <summary>
        /// Deleting the student to the database.
        /// </summary>
        /// <param name="student">A student.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Delete(Students student);

        /// <summary>
        /// Method which get student by index.
        /// </summary>
        /// <param name="id">An int number.</param>
        /// <returns>Students.</returns>
        Students GetStudentByIndex(int id);
    }
}
