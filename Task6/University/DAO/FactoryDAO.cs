﻿namespace University
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
            MSSQL,
            /// <summary>
            /// LINQ is database management system.
            /// </summary>
            LINQ
        }

        /// <summary>
        /// Obtaining an object for accessing exams.
        /// </summary>
        /// <returns>DAO of exams.</returns>
        public abstract IExam GetExam();

        /// <summary>
        /// Obtaining an object for accessing grades.
        /// </summary>
        /// <returns>DAO of grades.</returns>
        public abstract IGrade GetGrade();

        /// <summary>
        /// Obtaining an object for accessing groups.
        /// </summary>
        /// <returns>DAO of groups.</returns>
        public abstract IGroup GetGroup();

        /// <summary>
        /// Obtaining an object for accessing students.
        /// </summary>
        /// <returns>DAO of students.</returns>
        public abstract IStudent GetStudent();

        /// <summary>
        /// Getting a factory for a specific DBMS.
        /// </summary>
        /// <param name="typeFactory">DBMS.</param>
        /// <param name="connectionString">Database connection string.</param>
        /// <returns>Concrete factory.</returns>
        public static FactoryDAO GetFactoryDAO(DBMS typeFactory, string connectionString)
        {
            switch (typeFactory)
            {
                case DBMS.MSSQL:
                    return MSSQLFactoryDAO.GetInstance(connectionString);
                case DBMS.LINQ:
                    return LINQFactoryDAO.GetInstance(connectionString);
                default:
                    return null;
            }
        }
    }
}
