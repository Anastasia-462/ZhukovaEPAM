using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace University
{
    /// <summary>
    /// Class for forming reports.
    /// </summary>
    public static class ReportGeneration
    {
        private const string CONNECTIONSTRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
        private static void CreateExcel()
        {
            Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.Visible = true;
            ex.SheetsInNewWorkbook = 2;
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            ex.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
        }

        /// <summary>
        /// Method which forms list of expelled students.
        /// </summary>
        /// <returns>Dictionary.</returns>
        public static Dictionary<string, Student[]> FormListOfExpelledStudents()
        {
            Dictionary<string, Student[]> expelledStudent = new Dictionary<string, Student[]>();

            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IGroup group = factory.GetGroup();
            Group[] groups = group.GetGroups();
            string[] groupName = new string[groups.Length];
            for (int i = 0; i < groups.Length; i++)
            {
                groupName[i] = groups[i].GroupName;
                expelledStudent.Add(groupName[i], ExpelledStudent(i));
            }
            return expelledStudent;
        }

        private static int[] GetStudentsGrades(int id)
        {
            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IGrade grade = factory.GetGrade();
            IExam exam = factory.GetExam();
            Exam[] exams = exam.GetExams();
            Grades[] grades = grade.GetGrades();
            List<int> gradeStudent = new List<int>();
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i].StudentId == id)
                    gradeStudent.Add(grades[i].Grade);
            }
            return gradeStudent.ToArray();
        }

        private static Student[] ExpelledStudent(int groupId)
        {
            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IStudent student = factory.GetStudent();
            Student[] students = student.GetStudents();
            List<Student> expelledStudents = new List<Student>();
            
            for (int i = 0; i < students.Length; i++)
            {                
                if (students[i].GroupId == groupId)
                {
                    int[] grades = GetStudentsGrades(student.GetIdStudent(students[i]));
                    int score = 0;
                    for (int j = 0; j < grades.Length; j++)
                    {
                        if (grades[j] < 4)
                            score++;
                    }
                    if (score == 3)
                        expelledStudents.Add(students[i]);
                }
            }
            return expelledStudents.ToArray();
        }
    }
}
