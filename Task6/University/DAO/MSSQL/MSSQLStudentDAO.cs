using System.Collections.Generic;
using System.Data.SqlClient;

namespace University
{
    /// <summary>
    /// DAO students for MS SQL Server DBMS.
    /// </summary>
    public class MSSQLStudentDAO : IStudent
    {
        /// <summary>
        /// SQL query to add data to the database.
        /// </summary>
        private const string INSERT_EXPRESSION =
            "INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId) VALUES (@surname, @name, @middleName, @gender, @dateOfBirth, @groupId)";

        /// <summary>
        /// SQL query to get the list of students from the database.
        /// </summary>
        private const string GET_STUDENT_INFORMATION_EXPRESSION
            = "SELECT * FROM Students";

        /// <summary>
        /// SQL query to update data in the database.
        /// </summary>
        private const string UPDATE_EXPRESSION
            = "UPDATE Students SET Surname=@surname, Name=@name, MiddleName=@middleName, Gender=@gender, DateOfBirth=@dateOfBirth, GroupId=@groupId WHERE StudentId=@studentId";

        /// <summary>
        /// SQL query to delete data from the database.
        /// </summary>
        private const string DELETE_EXPRESSION
            = "DELETE FROM Students WHERE StudentId=@studentId";

        /// <summary>
        /// Obtaining an student ID.
        /// </summary>
        private const string GET_STUDENT_EXPRESSION
            = "SELECT StudentId FROM Students WHERE Surname=@surname AND Name=@name AND MiddleName=@middleName AND Gender=@gender AND DateOfBirth=@dateOfBirth AND GroupId=@groupId";


        private string connectionString;


        /// <summary>
        /// Creation of DAO students for MS SQL Server.
        /// </summary>
        /// <param name="connectionString">The string connecting to the database.</param>
        public MSSQLStudentDAO(string connectionString)
        {
            this.connectionString = connectionString;

            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, connectionString);
        }

        /// <summary>
        /// Method which gets student id.
        /// </summary>
        /// <param name="student">Student.</param>
        /// <returns>An int value.</returns>
        public int GetIdStudent(Student student)
        {
            int id = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(GET_STUDENT_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@surname", student.Surname));
                sqlCommand.Parameters.Add(new SqlParameter("@name", student.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@middleName", student.MiddleName));
                sqlCommand.Parameters.Add(new SqlParameter("@gender", student.Gender));
                sqlCommand.Parameters.Add(new SqlParameter("@dateOfBirth", student.DateOfBirth));
                sqlCommand.Parameters.Add(new SqlParameter("@groupId", student.GroupId));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = reader.GetInt32(0);
                }
            }
            return id;
        }

        private Student CreateGrades(SqlDataReader reader)
        {
            Student student = new Student();

            student.Surname = reader.GetString(1);
            student.Name = reader.GetString(2);
            student.MiddleName = reader.GetString(3);
            student.Gender = reader.GetString(4);
            student.DateOfBirth = reader.GetDateTime(5);
            student.GroupId = reader.GetInt32(6);

            return student;
        }

        /// <summary>
        /// Adding a student to the MS SQL Server database.
        /// </summary>
        /// <param name="student">Student.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Insert(Student student)
        {
            int numb;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(INSERT_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@surname", student.Surname));
                sqlCommand.Parameters.Add(new SqlParameter("@name", student.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@middleName", student.MiddleName));
                sqlCommand.Parameters.Add(new SqlParameter("@gender", student.Gender));
                sqlCommand.Parameters.Add(new SqlParameter("@dateOfBirth", student.DateOfBirth));
                sqlCommand.Parameters.Add(new SqlParameter("@groupId", student.GroupId));

                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }

        /// <summary>
        /// Getting a list of all students from the MS SQL Server database.
        /// </summary>
        /// <returns>All students in the database.</returns>
        public Student[] GetStudents()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    GET_STUDENT_INFORMATION_EXPRESSION,
                    connection);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        students.Add(CreateGrades(reader));
            }
            return students.ToArray();
        }

        /// <summary>
        /// Updating the student in the MS SQL Server database.
        /// </summary>
        /// <param name="nowStudent">Student for renewal.</param>
        /// <param name="newStudent">New student.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Update(Student nowStudent, Student newStudent)
        {
            int numb;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int id = GetIdStudent(nowStudent);

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(UPDATE_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@surname", newStudent.Surname));
                sqlCommand.Parameters.Add(new SqlParameter("@name", newStudent.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@middleName", newStudent.MiddleName));
                sqlCommand.Parameters.Add(new SqlParameter("@gender", newStudent.Gender));
                sqlCommand.Parameters.Add(new SqlParameter("@dateOfBirth", newStudent.DateOfBirth.ToString("yyyy-MM-dd")));
                sqlCommand.Parameters.Add(new SqlParameter("@groupId", newStudent.GroupId));
                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }

        /// <summary>
        /// Removing a student from the MS SQL Server database.
        /// </summary>
        /// <param name="student">Student.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Delete(Student student)
        {
            int numb;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int id = GetIdStudent(student);

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(DELETE_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@studentId", id));
                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }
    }
}
