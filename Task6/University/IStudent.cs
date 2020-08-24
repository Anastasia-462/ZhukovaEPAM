namespace University
{
    /// <summary>
    /// The interface of the student access object.
    /// </summary>
    public interface IStudent
    {
        /// <summary>
        /// Adding a new student to the database.
        /// </summary>
        /// <param name="student">A student.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Insert(Student student);

        /// <summary>
        /// Getting a list of all students from the database.
        /// </summary>
        /// <returns>All students.</returns>
        Student[] GetStudents();

        /// <summary>
        /// Updating the student to the database.
        /// </summary>
        /// <param name="nowStudent">A current student.</param>
        /// <param name="newStudent">A new student.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Update(Student nowStudent, Student newStudent);

        /// <summary>
        /// Deleting the student to the database.
        /// </summary>
        /// <param name="student">A student.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Delete(Student student);
    }
}
