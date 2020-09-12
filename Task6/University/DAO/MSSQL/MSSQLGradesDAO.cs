using System.Collections.Generic;
using System.Data.SqlClient;

namespace University
{
    /// <summary>
    /// DAO grades for MS SQL Server DBMS.
    /// </summary>
    public class MSSQLGradesDAO : IGrade
    {
        /// <summary>
        /// SQL query to add data to the database.
        /// </summary>
        private const string INSERT_EXPRESSION =
            "INSERT INTO Grades(ExamId, StudentId, Grade) VALUES (@examId, @studentId, @grade)";

        /// <summary>
        /// SQL query to get the list of grades from the database.
        /// </summary>
        private const string GET_GRADE_INFORMATION_EXPRESSION
            = "SELECT * FROM Grades";

        /// <summary>
        /// SQL query to update data in the database.
        /// </summary>
        private const string UPDATE_EXPRESSION
            = "UPDATE Grades SET ExamId=@examId, StudentId=@studentId, Grade=@grade WHERE GradeId=@gradeId";

        /// <summary>
        /// SQL query to delete data from the database.
        /// </summary>
        private const string DELETE_EXPRESSION
            = "DELETE FROM Grades WHERE GradeId=@gradeId";

        /// <summary>
        /// Obtaining an grade ID.
        /// </summary>
        private const string GET_GRADE_EXPRESSION
            = "SELECT GradeId FROM Grades WHERE ExamId=@examId AND StudentId=@studentId AND Grade=@grade";


        private string connectionString;


        /// <summary>
        /// Creation of DAO grades for MS SQL Server.
        /// </summary>
        /// <param name="connectionString">The string connecting to the database.</param>
        public MSSQLGradesDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private int GetIdGrade(Grades grade)
        {
            int id = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(GET_GRADE_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@examId", grade.ExamId));
                sqlCommand.Parameters.Add(new SqlParameter("@studentId", grade.StudentId));
                sqlCommand.Parameters.Add(new SqlParameter("@grade", grade.Grade));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = reader.GetInt32(0);
                }
            }
            return id;
        }

        private Grades CreateGrades(SqlDataReader reader)
        {
            Grades grade = new Grades();

            grade.ExamId = reader.GetInt32(1);
            grade.StudentId = reader.GetInt32(2);
            grade.Grade = reader.GetInt32(3);
            return grade;
        }

        /// <summary>
        /// Adding a grade to the MS SQL Server database.
        /// </summary>
        /// <param name="grade">Grade.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Insert(Grades grade)
        {
            int numb;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(INSERT_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@examId", grade.ExamId));
                sqlCommand.Parameters.Add(new SqlParameter("@studentId", grade.StudentId));
                sqlCommand.Parameters.Add(new SqlParameter("@grade", grade.Grade));

                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }

        /// <summary>
        /// Getting a list of all grades from the MS SQL Server database.
        /// </summary>
        /// <returns>All grades in the database.</returns>
        public Grades[] GetGrades()
        {
            List<Grades> grades = new List<Grades>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    GET_GRADE_INFORMATION_EXPRESSION,
                    connection);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        grades.Add(CreateGrades(reader));
            }
            return grades.ToArray();
        }

        /// <summary>
        /// Updating the grade in the MS SQL Server database.
        /// </summary>
        /// <param name="nowGrade">Grade for renewal.</param>
        /// <param name="newGrade">New grade.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Update(Grades nowGrade, Grades newGrade)
        {
            int numb;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int id = GetIdGrade(nowGrade);

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(UPDATE_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@examId", newGrade.ExamId));
                sqlCommand.Parameters.Add(new SqlParameter("@studentId", newGrade.StudentId));
                sqlCommand.Parameters.Add(new SqlParameter("@grade", newGrade.Grade)); 
                sqlCommand.Parameters.Add(new SqlParameter("@gradeId", id));
                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }

        /// <summary>
        /// Removing a grade from the MS SQL Server database.
        /// </summary>
        /// <param name="grade">Grade.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Delete(Grades grade)
        {
            int numb;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int id = GetIdGrade(grade);

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(DELETE_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@gradeId", id));
                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }

        /// <summary>
        /// Updating the grade in the MS SQL Server database.
        /// </summary>
        /// <param name="newGrade">New grade.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Update(Grades newGrade)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Method which get grade by index.
        /// </summary>
        /// <param name="id">An int number.</param>
        /// <returns>Grades.</returns>
        public Grades GetGradeByIndex(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
