using System;
using System.Data.Linq.Mapping;

namespace University
{
    /// <summary>
    /// Class describing the grade.
    /// </summary>
    [Table(Name = "Grades")]
    public class Grades : IComparable<Grades>
    {
        /// <summary>
        /// Grade id.
        /// </summary>
        [Column(Name = "GradeId", IsPrimaryKey = true, IsDbGenerated = true)]
        public int GradeId { get; set; }
        /// <summary>
        /// Grade.
        /// </summary>
        [Column(Name = "Grade")]
        public int Grade { get; set; }

        /// <summary>
        /// Exam id.
        /// </summary>
        [Column(Name = "ExamId")]
        public int ExamId { get; set; }

        /// <summary>
        /// Student id.
        /// </summary>
        [Column(Name = "StudentId")]
        public int StudentId { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Grades() { }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="gradeId">An int number.</param>
        /// <param name="grade">An int number.</param>
        /// <param name="examId">An int number.</param>
        /// <param name="studentId">An int number.</param>
        public Grades(int gradeId, int grade, int examId, int studentId)
        {
            GradeId = gradeId;
            Grade = grade;
            ExamId = examId;
            StudentId = studentId;
        }

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

        public int CompareTo(Grades other)
        {
            return GradeId.CompareTo(other.GradeId);
        }

        public override bool Equals(object obj)
        {
            return obj is Grades grades &&
                   GradeId == grades.GradeId &&
                   Grade == grades.Grade &&
                   ExamId == grades.ExamId &&
                   StudentId == grades.StudentId;
        }

        public override int GetHashCode()
        {
            int hashCode = -1992022823;
            hashCode = hashCode * -1521134295 + GradeId.GetHashCode();
            hashCode = hashCode * -1521134295 + Grade.GetHashCode();
            hashCode = hashCode * -1521134295 + ExamId.GetHashCode();
            hashCode = hashCode * -1521134295 + StudentId.GetHashCode();
            return hashCode;
        }
    }
}
