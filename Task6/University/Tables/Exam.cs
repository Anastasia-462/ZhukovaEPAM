using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace University
{
    /// <summary>
    /// Class describing the exam.
    /// </summary>
    [Table(Name = "Exams")]
    public class Exam : IComparable<Exam>
    {
        /// <summary>
        /// Exam id.
        /// </summary>
        [Column(Name = "ExamId", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ExamId { get; set; }
        /// <summary>
        /// Exam name.
        /// </summary>
        [Column(Name = "SubjectName")]
        public string SubjectName { get; set; }

        /// <summary>
        /// Date of the exam.
        /// </summary>
        [Column(Name = "ExamDate")]
        public DateTime ExamDate { get; set; }

        /// <summary>
        /// Group id.
        /// </summary>
        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        /// <summary>
        /// Assessment form.
        /// </summary>
        [Column(Name = "AssessmentForm")]
        public string AssessmentForm { get; set; }

        /// <summary>
        /// Type if session.
        /// </summary>
        [Column(Name = "Session")]
        public string Session { get; set; }

        /// <summary>
        /// Teacher surname.
        /// </summary>
        [Column(Name = "TeacherSurname")]
        public string TeacherSurname { get; set; }

        /// <summary>
        /// Teacher name.
        /// </summary>
        [Column(Name = "TeacherName")]
        public string TeacherName { get; set; }

        /// <summary>
        /// Teacher middle name.
        /// </summary>
        [Column(Name = "TeacherMiddleName")]
        public string TeacherMiddleName { get; set; }

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
        public Exam(string subjectName, DateTime examDate, int groupId, string assessmentForm,
            string session)
        {
            SubjectName = subjectName;
            ExamDate = examDate;
            GroupId = groupId;
            AssessmentForm = assessmentForm;
            Session = session;
        }


        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="subjectName">A string value.</param>
        /// <param name="examDate">A DateTime.</param>
        /// <param name="groupId">A int value.</param>
        /// <param name="assessmentForm">A string value.</param>
        /// <param name="session">A string value.</param>
        /// <param name="surnameTeacher">A string value.</param>
        /// <param name="nameTeacher">A string value.</param>
        /// <param name="middleNameTeacher">A string value.</param>
        public Exam(string subjectName, DateTime examDate, int groupId, string assessmentForm,
            string session, string surnameTeacher, string nameTeacher, string middleNameTeacher)
        {
            SubjectName = subjectName;
            ExamDate = examDate;
            GroupId = groupId;
            AssessmentForm = assessmentForm;
            Session = session;
            TeacherSurname = surnameTeacher;
            TeacherName = nameTeacher;
            TeacherMiddleName = middleNameTeacher;
        }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="examId">An int number.</param>
        /// <param name="subjectName">A string value.</param>
        /// <param name="examDate">A DateTime.</param>
        /// <param name="groupId">A int value.</param>
        /// <param name="assessmentForm">A string value.</param>
        /// <param name="session">A string value.</param>
        /// <param name="surnameTeacher">A string value.</param>
        /// <param name="nameTeacher">A string value.</param>
        /// <param name="middleNameTeacher">A string value.</param>
        public Exam(int examId, string subjectName, DateTime examDate, int groupId, string assessmentForm,
            string session, string surnameTeacher, string nameTeacher, string middleNameTeacher)
        {
            ExamId = examId;
            SubjectName = subjectName;
            ExamDate = examDate;
            GroupId = groupId;
            AssessmentForm = assessmentForm;
            Session = session;
            TeacherSurname = surnameTeacher;
            TeacherName = nameTeacher;
            TeacherMiddleName = middleNameTeacher;
        }

        /// <summary>
        /// Method to compare objects.
        /// </summary>
        /// <param name="other">Exams.</param>
        /// <returns>An int number.</returns>
        public int CompareTo(Exam other)
        {
            return ExamId.CompareTo(other.ExamId);
        }

        /// <summary>
        /// Method to compare objects.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equal,  false in the opposite case.</returns>
        public override bool Equals(object obj)
        {
            return obj is Exam exam &&
                   ExamId == exam.ExamId &&
                   SubjectName == exam.SubjectName &&
                   ExamDate == exam.ExamDate &&
                   GroupId == exam.GroupId &&
                   AssessmentForm == exam.AssessmentForm &&
                   Session == exam.Session &&
                   TeacherSurname == exam.TeacherSurname &&
                   TeacherName == exam.TeacherName &&
                   TeacherMiddleName == exam.TeacherMiddleName;
        }

        /// <summary>
        /// Method which gets hash code.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            int hashCode = 1698072773;
            hashCode = hashCode * -1521134295 + ExamId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SubjectName);
            hashCode = hashCode * -1521134295 + ExamDate.GetHashCode();
            hashCode = hashCode * -1521134295 + GroupId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AssessmentForm);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Session);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TeacherSurname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TeacherName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TeacherMiddleName);
            return hashCode;
        }
    }
}
