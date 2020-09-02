using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    /// <summary>
    /// Class describing the exam.
    /// </summary>
    public class Exam
    {
        /// <summary>
        /// Exam name.
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// Date of the exam.
        /// </summary>
        public DateTime ExamDate { get; set; }

        /// <summary>
        /// Group id.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Assessment form.
        /// </summary>
        public string AssessmentForm { get; set; }

        /// <summary>
        /// Type if session.
        /// </summary>
        public string Session { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Exam() { }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="subjectName">A string value.</param>
        /// <param name="examDate">A DateTime.</param>
        /// <param name="groupId">A int value.</param>
        /// <param name="assessmentForm">A string value.</param>
        /// <param name="session">A string value.</param>
        public Exam(string subjectName, DateTime examDate, int groupId, string assessmentForm, string session)
        {
            SubjectName = subjectName;
            ExamDate = examDate;
            GroupId = groupId;
            AssessmentForm = assessmentForm;
            Session = session;
        }
    }
}
