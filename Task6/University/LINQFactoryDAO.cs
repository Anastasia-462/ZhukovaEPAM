using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    /// <summary>
    /// Object for getting data from MS SQL SERVER database.
    /// </summary>
    public class LINQFactoryDAO : FactoryDAO
    {
        private string connectionString;

        private static LINQFactoryDAO _instance;
        private LINQFactoryDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// A method that returns an object stored in a static field.
        /// </summary>
        /// <param name="connectionString">The string connecting to the database.</param>
        /// <returns>An object of this class.</returns>
        public static LINQFactoryDAO GetInstance(string connectionString)
        {
            if (_instance == null)
            {
                _instance = new LINQFactoryDAO(connectionString);
            }
            return _instance;
        }


        /// <summary>
        /// Getting an object to access the university database.
        /// </summary>
        /// <returns>DAO exam.</returns>
        public override IExam GetExam()
        {
            return new LINQExamDAO(connectionString);
        }

        /// <summary>
        /// Getting an object to access the university database.
        /// </summary>
        /// <returns>DAO grade.</returns>
        public override IGrade GetGrade()
        {
            return new LINQGradesDAO(connectionString);
        }

        /// <summary>
        /// Getting an object to access the university database.
        /// </summary>
        /// <returns>DAO group.</returns>
        public override IGroup GetGroup()
        {
            return new LINQGroupDAO(connectionString);
        }

        /// <summary>
        /// Getting an object to access the university database.
        /// </summary>
        /// <returns>DAO student.</returns>
        public override IStudent GetStudent()
        {
            return new LINQStudentDAO(connectionString);
        }

    }
}
