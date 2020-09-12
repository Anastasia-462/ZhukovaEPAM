using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace University
{
    /// <summary>
    /// Class describing the student.
    /// </summary>
    [Table(Name = "Students")]
    public class Students : IComparable<Students>
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

        /// <summary>
        /// Method to compare objects.
        /// </summary>
        /// <param name="other">Students.</param>
        /// <returns>An int number.</returns>
        public int CompareTo(Students other)
        {
            return StudentId.CompareTo(other.StudentId);
        }

        /// <summary>
        /// Method to compare objects.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equal,  false in the opposite case.</returns>
        public override bool Equals(object obj)
        {
            return obj is Students students &&
                   StudentId == students.StudentId &&
                   Surname == students.Surname &&
                   Name == students.Name &&
                   MiddleName == students.MiddleName &&
                   Gender == students.Gender &&
                   DateOfBirth == students.DateOfBirth &&
                   GroupId == students.GroupId;
        }

        /// <summary>
        /// Method which gets hash code.
        /// </summary>
        /// <returns>An int number.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1959153046;
            hashCode = hashCode * -1521134295 + StudentId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MiddleName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Gender);
            hashCode = hashCode * -1521134295 + DateOfBirth.GetHashCode();
            hashCode = hashCode * -1521134295 + GroupId.GetHashCode();
            return hashCode;
        }
    }
}
