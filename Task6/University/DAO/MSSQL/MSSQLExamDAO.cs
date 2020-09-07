using System.Collections.Generic;
using System.Data.SqlClient;

namespace University
{
    /// <summary>
    /// DAO exams for MS SQL Server DBMS.
    /// </summary>
    public class MSSQLExamDAO : IExam
    {
        /// <summary>
        /// SQL query to add data to the database.
        /// </summary>
        private const string INSERT_EXPRESSION =
            "INSERT INTO Exams(SubjectName, AssessmentForm, ExamDate, Session, GroupId) VALUES (@subjectName, @assessmentForm, @examDate, @session, @groupId)";

        /// <summary>
        /// SQL query to get the list of exams from the database.
        /// </summary>
        private const string GET_EXAM_INFORMATION_EXPRESSION
            = "SELECT * FROM Exams";

        /// <summary>
        /// SQL query to update data in the database.
        /// </summary>
        private const string UPDATE_EXPRESSION
            = "UPDATE Exams SET SubjectName=@subjectName, AssessmentForm=@assessmentForm, ExamDate=@examDate, Session=@session, GroupId=@groupId WHERE ExamId=@examId";

        /// <summary>
        /// SQL query to delete data from the database.
        /// </summary>
        private const string DELETE_EXPRESSION
            = "DELETE FROM Exams WHERE ExamId=@examId";

        /// <summary>
        /// Obtaining an exam ID.
        /// </summary>
        private const string GET_EXAM_EXPRESSION
            = "SELECT ExamId FROM Exams WHERE SubjectName=@subjectName AND AssessmentForm=@assessmentForm AND ExamDate=@examDate AND Session=@session AND GroupId=@groupId";

        private const string GET_EXAM_BY_ID
            = "SELECT * FROM Exams WHERE ExamId = @examId";
        
        private string connectionString;

        /// <summary>
        /// Creation of DAO exams for MS SQL Server.
        /// </summary>
        /// <param name="connectionString">The string connecting to the database.</param>
        public MSSQLExamDAO(string connectionString)
        {
            this.connectionString = connectionString;

            //FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, connectionString);
        }

        /// <summary>
        /// Method which get index by exam.
        /// </summary>
        /// <param name="exam">Exam.</param>
        /// <returns>An int number.</returns>
        public int GetIdExam(Exam exam)
        {
            int id = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(GET_EXAM_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@subjectName", exam.SubjectName));
                sqlCommand.Parameters.Add(new SqlParameter("@assessmentForm", exam.AssessmentForm));
                sqlCommand.Parameters.Add(new SqlParameter("@examDate", exam.ExamDate));
                sqlCommand.Parameters.Add(new SqlParameter("@session", exam.Session));
                sqlCommand.Parameters.Add(new SqlParameter("@groupId", exam.GroupId));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = reader.GetInt32(0);
                }
            }
            return id;
        }

        private Exam CreateExam(SqlDataReader reader)
        {
            Exam exam = new Exam();
                        
            exam.AssessmentForm = reader.GetString(1);
            exam.SubjectName = reader.GetString(2);
            exam.ExamDate = reader.GetDateTime(3);
            exam.Session = reader.GetString(4);
            exam.GroupId = reader.GetInt32(5);
            return exam;
        }

        /// <summary>
        /// Adding a exam to the MS SQL Server database.
        /// </summary>
        /// <param name="exam">Exam.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Insert(Exam exam)
        {
            int numb;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(INSERT_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@subjectName", exam.SubjectName));
                sqlCommand.Parameters.Add(new SqlParameter("@assessmentForm", exam.AssessmentForm));
                sqlCommand.Parameters.Add(new SqlParameter("@examDate", exam.ExamDate));
                sqlCommand.Parameters.Add(new SqlParameter("@session", exam.Session));
                sqlCommand.Parameters.Add(new SqlParameter("@groupId", exam.GroupId));

                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }

        /// <summary>
        /// Getting a list of all exams from the MS SQL Server database.
        /// </summary>
        /// <returns>All exams in the database.</returns>
        public Exam[] GetExams()
        {
            List<Exam> exams = new List<Exam>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    GET_EXAM_INFORMATION_EXPRESSION,
                    connection);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        exams.Add(CreateExam(reader));
            }
            return exams.ToArray();
        }

        /// <summary>
        /// Updating the exam in the MS SQL Server database.
        /// </summary>
        /// <param name="nowExam">Exam for renewal.</param>
        /// <param name="newExam">New exam.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Update(Exam nowExam, Exam newExam)
        {
            int numb;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int id = GetIdExam(nowExam);

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(UPDATE_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@subjectName", newExam.SubjectName));
                sqlCommand.Parameters.Add(new SqlParameter("@assessmentForm", newExam.AssessmentForm));
                sqlCommand.Parameters.Add(new SqlParameter("@examDate", newExam.ExamDate.ToString("yyyy-MM-dd")));
                sqlCommand.Parameters.Add(new SqlParameter("@session", newExam.Session));
                sqlCommand.Parameters.Add(new SqlParameter("@groupId", newExam.GroupId));
                sqlCommand.Parameters.Add(new SqlParameter("@examId", id));
                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }

        /// <summary>
        /// Removing a exam from the MS SQL Server database.
        /// </summary>
        /// <param name="exam">Exam.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Delete(Exam exam)
        {
            int numb;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int id = GetIdExam(exam);

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(DELETE_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@examId", id));
                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }

        /// <summary>
        /// Method which get exam by index.
        /// </summary>
        /// <param name="id">An int number.</param>
        /// <returns>Exam.</returns>
        public Exam GetExamByIndex(int id)
        {
            Exam exam = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(GET_EXAM_BY_ID, connection);
                sqlCommand.Parameters.Add(new SqlParameter("@examId", id));

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    exam = new Exam(reader.GetString(2), reader.GetDateTime(3), reader.GetInt32(5), reader.GetString(1), reader.GetString(4));
                }
            }
            return exam;
        }
    }
}
