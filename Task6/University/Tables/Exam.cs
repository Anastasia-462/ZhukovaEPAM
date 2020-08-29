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
        /// Constructor of this class.
        /// </summary>
        public Exam() { }
    }
}
