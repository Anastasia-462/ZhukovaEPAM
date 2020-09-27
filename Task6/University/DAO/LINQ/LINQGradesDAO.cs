﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    /// <summary>
    /// DAO grades for LINQ DBMS.
    /// </summary>
    public class LINQGradesDAO : IGrade
    {
        DataContext dataContext;

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="connectionString">A string value.</param>
        public LINQGradesDAO(string connectionString)
        {
            dataContext = new DataContext(connectionString);
        }

        /// <summary>
        /// Removing a grade from the database.
        /// </summary>
        /// <param name="grade">Grades.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Delete(Grades grade)
        {
            dataContext.GetTable<Grades>().DeleteOnSubmit(GetGradeByIndex(grade.GradeId));
            dataContext.SubmitChanges();
            return true;
        }

        /// <summary>
        /// Method which get grade by index.
        /// </summary>
        /// <param name="id">An int number.</param>
        /// <returns>Grades.</returns>
        public Grades GetGradeByIndex(int id)
        {
            var query = from grd in dataContext.GetTable<Grades>()
                        where grd.GradeId == id
                        select grd;
            return query.First();
        }

        /// <summary>
        /// Getting a list of all grades from the database.
        /// </summary>
        /// <returns>All grades in the database.</returns>
        public Grades[] GetGrades()
        {
            Table<Grades> grades = dataContext.GetTable<Grades>();
            return grades.ToArray();
        }

        /// <summary>
        /// Adding a grade to the MS SQL Server database.
        /// </summary>
        /// <param name="grade">Grades.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Insert(Grades grade)
        {
            dataContext.GetTable<Grades>().InsertOnSubmit(grade);
            dataContext.SubmitChanges();
            return true;
        }

        /// <summary>
        /// Updating the grade in the database.
        /// </summary>
        /// <param name="newGrade">New grade.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Update(Grades newGrade)
        {
            Grades nowGrade = GetGradeByIndex(newGrade.GradeId);
            nowGrade.GradeId = newGrade.GradeId;
            nowGrade.StudentId = newGrade.StudentId;
            nowGrade.Grade = newGrade.Grade;
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception) { }
            return true;
        }

        /// <summary>
        /// Updating the grade in the database.
        /// </summary>
        /// <param name="nowGrade">Grade for renewal.</param>
        /// <param name="newGrade">New grade.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Update(Grades nowGrade, Grades newGrade)
        {
            nowGrade.GradeId = newGrade.GradeId;
            nowGrade.StudentId = newGrade.StudentId;
            nowGrade.Grade = newGrade.Grade;
            dataContext.SubmitChanges();
            return true;
        }
    }
}
