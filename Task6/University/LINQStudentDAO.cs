using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class LINQStudentDAO : IStudent
    {
        DataContext dataContext;

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="connectionString">A string value.</param>
        public LINQStudentDAO(string connectionString)
        {
            dataContext = new DataContext(connectionString);
        }


        /// <summary>
        /// Removing a exam from the database.
        /// </summary>
        /// <param name="student">Exam.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Delete(Students student)
        {
            dataContext.GetTable<Students>().DeleteOnSubmit(student);
            dataContext.SubmitChanges();
            return true;
        }

        /// <summary>
        /// Method which get index by student.
        /// </summary>
        /// <param name="student">Students.</param>
        /// <returns>An int number.</returns>
        public int GetIdStudent(Students student)
        {
            var query = from st in dataContext.GetTable<Students>()
                        where st.Surname == student.Surname &&
                        st.DateOfBirth == student.DateOfBirth && st.GroupId == student.GroupId
                        select st.StudentId;
            return query.First();
        }

        /// <summary>
        /// Getting a list of all students from the database.
        /// </summary>
        /// <returns>All students in the database.</returns>
        public Students[] GetStudents()
        {
            Table<Students> students = dataContext.GetTable<Students>();
            return students.ToArray();
        }

        /// <summary>
        /// Adding a student to the database.
        /// </summary>
        /// <param name="student">Students.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Insert(Students student)
        {
            dataContext.GetTable<Students>().InsertOnSubmit(student);
            dataContext.SubmitChanges();
            return true;
        }

        /// <summary>
        /// Updating the student in the database.
        /// </summary>
        /// <param name="nowStudent">Student for renewal.</param>
        /// <param name="newStudent">New student.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Update(Students nowStudent, Students newStudent)
        {
            nowStudent.Surname = newStudent.Surname;
            nowStudent.Name = newStudent.Name;
            nowStudent.MiddleName = newStudent.MiddleName;
            nowStudent.Gender = newStudent.Gender;
            nowStudent.DateOfBirth = newStudent.DateOfBirth;
            nowStudent.GroupId = newStudent.GroupId;
            dataContext.SubmitChanges();
            return true;
        }
    }
}
