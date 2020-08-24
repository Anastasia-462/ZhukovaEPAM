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
    public class MSSQLFactoryDAO : FactoryDAO
    {
        private string connectionString;

        private static MSSQLFactoryDAO _instance;
        private MSSQLFactoryDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// A method that returns an object stored in a static field.
        /// </summary>
        /// <param name="connectionString">The string connecting to the database.</param>
        /// <returns>An object of this class.</returns>
        public static MSSQLFactoryDAO GetInstance(string connectionString)
        {
            if(_instance == null)
            {
                _instance = new MSSQLFactoryDAO(connectionString);
            }
            return _instance;
        }

        public override IExam GetExam()
        {
            return new MSSQLExamDAO(connectionString);
        }

        public override IGrade GetGrade()
        {
            return new MSSQLGradeDAO(connectionString);
        }

        public override IGroup GetGroup()
        {
            return new MSSQLGroupDAO(connectionString);
        }

        public override IStudent GetStudent()
        {
            return new MSSQLStudentDAO(connectionString);
        }
    }
}
