using System;

namespace University
{
    /// <summary>
    /// Class describing the student.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Student name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Student middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Student gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Student date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Student group id.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Student() { }

    }
}
