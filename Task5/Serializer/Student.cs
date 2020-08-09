using System;
using System.Collections.Generic;

namespace Serializer
{
    /// <summary>
    /// Student class.
    /// </summary>
    [Serializable]
    public class Student
    {
        /// <summary>
        /// Student name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Subject name.
        /// </summary>
        public string TestName { get; set; }

        /// <summary>
        /// Date of writing the test.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The score.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="name">A string.</param>
        /// <param name="testName">A string.</param>
        /// <param name="date">A DateTime.</param>
        /// <param name="score">An int number.</param>
        public Student(string name, string testName, DateTime date, int score)
        {
            Name = name;
            TestName = testName;
            Date = date;
            Score = score;
            if ((score > 10) && (score < 0))
                throw new Exception("Score can't be more than 10 and less than 0.");
        }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Student() { }


        /// <summary>
        /// Overriden method to output a string with student.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return "Name: " + Name + " Subject: " + TestName + " Date: " + Date.ToString("dd-MM-yyyy") + " Score: " + Score + "\n";
        }

        /// <summary>
        /// Overriden method to compare objects.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equal and false in the opposite case.</returns>
        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   TestName == student.TestName &&
                   Date == student.Date &&
                   Score == student.Score;
        }

        /// <summary>
        /// Method to get hashcode.
        /// </summary>
        /// <returns>Hashcode.</returns>
        public override int GetHashCode()
        {
            int hashCode = -329935982;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TestName);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + Score.GetHashCode();
            return hashCode;
        }
    }
}
