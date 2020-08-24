using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    /// <summary>
    /// An object factory for accessing data from a database.
    /// </summary>
    public abstract class FactoryDAO
    {
        /// <summary>
        /// Enumeration of various different database management systems.
        /// </summary>
        public enum DBMS
        {
            /// <summary>
            /// MSSQL is database management system.
            /// </summary>
            MSSQL
        }

        /// <summary>
        /// Obtaining an object for accessing exams.
        /// </summary>
        /// <returns></returns>
        public abstract IExam GetExam();

        public abstract IGrade GetGrade();

        public abstract IGroup GetGroup();

        public abstract IStudent GetStudent();

        public static FactoryDAO GetFactoryDAO(DBMS typeFactory, string connectionString)
        {
            switch (typeFactory)
            {
                case DBMS.MSSQL:
                    return null;
                default:
                    return null;
            }
        }
    }
}
