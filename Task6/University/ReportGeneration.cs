using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace University
{
    /// <summary>
    /// Class for forming reports.
    /// </summary>
    public static class ReportGeneration
    {
        private const string CONNECTIONSTRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";

        /// <summary>
        /// Method which forms outcome of session.
        /// </summary>
        public static void OutcomeOfSession()
        {
            Application ex = new Application();
            ex.SheetsInNewWorkbook = 1;
            Workbook workBook = ex.Workbooks.Add(Type.Missing);
            ex.DisplayAlerts = false;
            Worksheet sheet = (Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = "Итоги сессии";

            //FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            //Group[] groups = factory.GetGroup().GetGroups();
            //Exam[] exams = factory.GetExam().GetExams();
            //Grades[] grades = factory.GetGrade().GetGrades();
            //Student[] students = factory.GetStudent().GetStudents();
            MSSQLStudentDAO st = new MSSQLStudentDAO(CONNECTIONSTRING);


            //(string subjectName, DateTime examDate, int groupId, string assessmentForm, string session)
            Group[] groups = new Group[] { new Group("ИТИ-21"), new Group("ИТП-21") };
            Exam[] exams = new Exam[]
            { 
                new Exam("Math", new DateTime(2019, 01, 15), 1, "э", "з"),
                new Exam("1", new DateTime(2019, 01, 22), 1, "з", "л"),
                new Exam("2", new DateTime(2019, 01, 23), 2, "э", "л"),
                new Exam("3", new DateTime(2019, 01, 24), 1, "з", "з"),
                new Exam("4", new DateTime(2019, 01, 25), 2, "э", "л"),
                new Exam("5", new DateTime(2019, 01, 26), 1, "з", "л"),
                new Exam("6", new DateTime(2019, 01, 27), 2, "э", "з")
            };
            Grades[] grades = new Grades[]
            {
                new Grades(9, 1, 1),
                new Grades(7, 2, 1),

                new Grades(9, 3, 2),
                new Grades(9, 4, 2),

                new Grades(9, 1, 3),
                new Grades(9, 2, 3),

                new Grades(9, 1, 4),
                new Grades(9, 2, 4),

                new Grades(9, 1, 5),
                new Grades(9, 2, 5),

                new Grades(9, 1, 6),
                new Grades(9, 2, 6)
            };
            Student[] students = new Student[]
            {
                new Student("Akyla1", "Artemon", "Pavlovich", "f", new DateTime(2000, 07, 21), 1),
                new Student("Akyla2", "Artemon", "Pavlovich", "m", new DateTime(2000, 06, 21), 1),
                new Student("Akyla3", "Artemon", "Pavlovich", "m", new DateTime(2000, 05, 21), 1),

                new Student("Akyla4", "Artemon", "Pavlovich", "f", new DateTime(2000, 04, 21), 2),
                new Student("Akyla5", "Artemon", "Pavlovich", "f", new DateTime(2000, 03, 21), 2),
                new Student("Akyla6", "Artemon", "Pavlovich", "m", new DateTime(2000, 02, 21), 2)
            };

            int pos = 0; // po vertikali
            IEnumerable<IGrouping<string,Exam>> session = exams.GroupBy(exam => exam.Session);
            IEnumerable<IGrouping<string, Exam>> subject = exams.GroupBy(exam => exam.SubjectName);
            //IEnumerable<IGrouping<string, Exam>> student = exams.GroupBy(exam => exam.SubjectName);
            for (int i = 0; i < session.Count(); i++)
            {
                sheet.Range[sheet.Cells[++pos, 1], sheet.Cells[pos, subject.Count() + 1]].Merge();
                sheet.Cells[pos, 1] = FormSessionName(session.ElementAt(i).Key) + " cессия";
                IEnumerable<IGrouping<int, Exam>> group = exams.Where(exam => exam.Session == session.ElementAt(i).Key).GroupBy(exam => exam.GroupId);
                for (int j = 0; j < group.Count(); j++)
                {
                    sheet.Range[sheet.Cells[++pos, 1], sheet.Cells[pos, subject.Count() + 1]].Merge();
                    sheet.Cells[pos, 1] = "Группа - " + group.ElementAt(j).Key; // группа неправильная
                    sheet.Cells[++pos, 1] = "Тип";
                    var subjectAmount = group.ElementAt(j).GetEnumerator();
                    int k = 2;
                    while (subjectAmount.MoveNext())
                    {
                        sheet.Cells[pos, k] = subjectAmount.Current.AssessmentForm;
                        sheet.Cells[pos + 1, k] = subjectAmount.Current.SubjectName;
                        k++;
                    }                   
                    sheet.Cells[++pos, 1] = "ФИО";
                    IEnumerable<Student> studentGroup = students.Where(student => student.GroupId == group.ElementAt(j).Key);
                    //grades.GroupBy(grade => grade.StudentId);
                    for (k = 0; k < studentGroup.Count(); k++)
                    {
                        sheet.Cells[++pos, 1] = FormFullName(studentGroup.ElementAt(k));
                        IEnumerable<Grades> gradeStudent = grades.Where(grade => grade.StudentId == st.GetIdStudent(studentGroup.ElementAt(k)));
                        for (int m = 0; m < studentGroup.Count(); m++)
                        {
                            sheet.Cells[++pos, 1] = FormFullName(studentGroup.ElementAt(m));
                        }
                    }
                }
            }
            //ex.Application.ActiveWorkbook.SaveAs(Directory.GetCurrentDirectory() + @"\Report.xlsx");
            ex.Application.ActiveWorkbook.SaveCopyAs(Directory.GetCurrentDirectory() + @"\1.xlsx");
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

        private static float[] GroupMaxScore()
        {
            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IGroup group = factory.GetGroup();
            Group[] groups = group.GetGroups();
            float max = -1;
            float[] maxScore = new float[groups.Length];

            for(int i = 0; i < groups.Length; i++)
            {
                float[] studentsScores = AverageStudentsScore(i);
                for (int j = 0;  j < studentsScores.Length; j++)
                {
                    if(studentsScores[j] > max)
                    {
                        maxScore[i] = studentsScores[j];
                    }
                }
            }
            return maxScore;
        }

        private static float[] GroupMinScore()
        {
            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IGroup group = factory.GetGroup();
            Group[] groups = group.GetGroups();
            float min = 1000;
            float[] minScore = new float[groups.Length];

            for (int i = 0; i < groups.Length; i++)
            {
                float[] studentsScores = AverageStudentsScore(i);
                for (int j = 0; j < studentsScores.Length; j++)
                {
                    if (studentsScores[j] < min)
                    {
                        minScore[i] = studentsScores[j];
                    }
                }
            }
            return minScore;
        }

        private static float[] GroupAverageScore()
        {
            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IGroup group = factory.GetGroup();
            Group[] groups = group.GetGroups();
            float[] averageScore = new float[groups.Length];

            for (int i = 0; i < groups.Length; i++)
            {
                float[] studentsScores = AverageStudentsScore(i);
                for (int j = 0; j < studentsScores.Length; j++)
                {
                    averageScore[i] += studentsScores[j];
                }
                averageScore[i] = averageScore[i] / studentsScores.Length;
            }
            return averageScore;
        }

        private static float[] AverageStudentsScore(int groupId)
        {
            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IStudent student = factory.GetStudent();
            Student[] students = student.GetStudents();
            List<float> averageStudentsScore = new List<float>();
            for (int i = 0; i < students.Length; i++)
            {
                if(students[i].GroupId == groupId)
                {
                    int averageScore = 0;
                    int count = GetStudentsGrades(i).Length;
                    foreach (int score in GetStudentsGrades(i))
                    {
                        averageScore += score;
                    }
                    averageStudentsScore.Add(averageScore / count);
                }
            }
            return averageStudentsScore.ToArray();
        }

        private static int[] GetStudentsGrades(int id)
        {
            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IGrade grade = factory.GetGrade();            
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

        private static string FormSessionName(string session)
        {
            switch (session)
            {
                case "л":
                    return "Летняя";
                case "з":
                    return "Зимняя";
                default:
                    return null;
            }
        }

        private static string FormFullName(Student student)
        {
            return student.Surname + " " + student.Name + " " + student.MiddleName;
        }

        private static string FormGroupName(string session)
        {
            switch (session)
            {
                case "л":
                    return "Летняя";
                case "з":
                    return "Зимняя";
                default:
                    return null;
            }
        }
    }
}
