using System;

namespace BinaryTree
{
    /// <summary>
    /// Student class.
    /// </summary>
    [Serializable]
    public class Student : IComparable<Student>
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
        /// Mathod to compare Student objects.
        /// </summary>
        /// <param name="student">A Student object.</param>
        /// <returns>An int number.</returns>
        public int CompareTo(Student student)
        {
            if (student != null)
                return Score.CompareTo(student.Score);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

        /// <summary>
        /// Overriden method to output a string with the score of student.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return Score + "";
        }
    }
}
