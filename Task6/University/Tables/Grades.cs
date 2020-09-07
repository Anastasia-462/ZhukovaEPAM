namespace University
{
    /// <summary>
    /// Class describing the grade.
    /// </summary>
    public class Grades
    {
        /// <summary>
        /// Grade.
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// Exam id.
        /// </summary>
        public int ExamId { get; set; }

        /// <summary>
        /// Student id.
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Grades() { }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="grade">An int number.</param>
        /// <param name="examId">An int number.</param>
        /// <param name="studentId">An int number.</param>
        public Grades(int grade, int examId, int studentId)
        {
            Grade = grade;
            ExamId = examId;
            StudentId = studentId;
        }
    }
}
