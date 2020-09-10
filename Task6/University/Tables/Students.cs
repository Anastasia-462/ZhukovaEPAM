using System;
using System.Data.Linq.Mapping;

namespace University
{
    /// <summary>
    /// Class describing the student.
    /// </summary>
    [Table(Name = "Students")]
    public class Students
    {
        /// <summary>
        /// Student id.
        /// </summary>
        [Column(Name = "StudentId", IsPrimaryKey = true, IsDbGenerated = true)]
        public int StudentId { get; set; }

        /// <summary>
        /// Student surname.
        /// </summary>
        [Column(Name = "Surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Student name.
        /// </summary>
        [Column(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Student middle name.
        /// </summary>
        [Column(Name = "MiddleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Student gender.
        /// </summary>
        [Column(Name = "Gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Student date of birth.
        /// </summary>
        [Column(Name = "DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Student group id.
        /// </summary>
        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Students() { }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="studentId">An int number.</param>
        /// <param name="surname">A string value.</param>
        /// <param name="name">A string value.</param>
        /// <param name="middleName">A string value.</param>
        /// <param name="gender">A string value.</param>
        /// <param name="dateOfBirth">A DateTime value.</param>
        /// <param name="groupId">An int number.</param>
        public Students(int studentId, string surname, string name, string middleName, string gender, DateTime dateOfBirth, int groupId)
        {
            StudentId = studentId;
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            GroupId = groupId;
        }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="surname">A string value.</param>
        /// <param name="name">A string value.</param>
        /// <param name="middleName">A string value.</param>
        /// <param name="gender">A string value.</param>
        /// <param name="dateOfBirth">A DateTime value.</param>
        /// <param name="groupId">An int number.</param>
        public Students(string surname, string name, string middleName, string gender, DateTime dateOfBirth, int groupId)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            GroupId = groupId;
        }
    }
}
