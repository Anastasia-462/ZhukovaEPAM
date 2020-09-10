using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Office.Interop.Excel;

namespace University
{
    /// <summary>
    /// Enum of sorting.
    /// </summary>
    public enum Sorting
    {
        /// <summary>
        /// Sort by surname.
        /// </summary>
        SortSurmame,
        /// <summary>
        /// Sort by gender.
        /// </summary>
        SortGender,
        /// <summary>
        /// Sort by date of birth.
        /// </summary>
        SortDateOfBirth
    }

    /// <summary>
    /// Class for forming reports.
    /// </summary>
    public static class ReportGeneration
    {
        private const string CONNECTIONSTRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";

        /// <summary>
        /// Method which forms summary table. 
        /// </summary>
        /// <returns>True if method works right, false in the opposite case.</returns>
        public static bool FormSummaryTable()
        {
            Application ex = new Application();
            ex.SheetsInNewWorkbook = 1;
            Workbook workBook = ex.Workbooks.Add(Type.Missing);
            ex.DisplayAlerts = false;
            Worksheet sheet = (Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = "Сводная таблица";

            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IGroup group = factory.GetGroup();
            Groups[] groups = group.GetGroups();
            Exam[] exams = factory.GetExam().GetExams();

            IEnumerable<IGrouping<string, Exam>> session = exams.GroupBy(exam => exam.Session);
            int pos = 0;
            sheet.Columns[1].ColumnWidth = 15;
            sheet.Columns[2].ColumnWidth = 15;
            sheet.Columns[3].ColumnWidth = 15;
            sheet.Columns[4].ColumnWidth = 15;
            for (int i = 0; i < session.Count(); i++)
            {
                sheet.Range[sheet.Cells[++pos, 1], sheet.Cells[pos, 4]].Merge();
                sheet.Cells[pos, 1] = FormSessionName(session.ElementAt(i).Key) + " cессия";
                sheet.Cells[pos, 1].Font.Bold = 7;
                sheet.Cells[++pos, 1] = "Группа";
                sheet.Cells[pos, 2] = "Средний";
                sheet.Cells[pos, 3] = "Минимальный";
                sheet.Cells[pos, 4] = "Максимальный";
                for (int j = 0; j < groups.Count(); j++)
                {
                    sheet.Cells[++pos, 1] = groups[j].GroupName;
                    sheet.Cells[pos, 2] = GroupAverageScore(group.GetIdGroup(groups[j]), session.ElementAt(i).Key);
                    sheet.Cells[pos, 3] = GroupMinScore(group.GetIdGroup(groups[j]), session.ElementAt(i).Key);
                    sheet.Cells[pos, 4] = GroupMaxScore(group.GetIdGroup(groups[j]), session.ElementAt(i).Key);
                }
            }
            ex.Application.ActiveWorkbook.SaveCopyAs(Directory.GetCurrentDirectory() + @"\SummaryTable.xlsx");
            return true;
        }

        /// <summary>
        /// Method which forms list of expelled students.
        /// </summary>
        /// <returns>Dictionary.</returns>
        public static Dictionary<string, Students[]> FormListOfExpelledStudents(string session)
        {
            Dictionary<string, Students[]> expelledStudent = new Dictionary<string, Students[]>();

            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IGroup group = factory.GetGroup();
            Groups[] groups = group.GetGroups();
            for (int i = 0; i < groups.Length; i++)
            {
                expelledStudent.Add(groups[i].GroupName, ExpelledStudent(group.GetIdGroup(groups[i]), session));
            }
            return expelledStudent;
        }

        /// <summary>
        /// Method which forms outcome of session.
        /// </summary>
        /// <returns>True if method works right, false in the opposite case.</returns>
        public static bool OutcomeOfSession(Sorting sorting)
        {
            Application ex = new Application();
            ex.SheetsInNewWorkbook = 1;
            Workbook workBook = ex.Workbooks.Add(Type.Missing);
            ex.DisplayAlerts = false;
            Worksheet sheet = (Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = "Итоги сессии";

            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            Groups[] groups = factory.GetGroup().GetGroups();
            IExam exe = factory.GetExam();
            Exam[] exams = exe.GetExams();
            Grades[] grades = factory.GetGrade().GetGrades();
            Students[] students = factory.GetStudent().GetStudents();
            MSSQLStudentDAO st = new MSSQLStudentDAO(CONNECTIONSTRING);

            int pos = 0;
            IEnumerable<IGrouping<string, Exam>> session = exams.GroupBy(exam => exam.Session);
            IEnumerable<IGrouping<string, Exam>> subject = exams.GroupBy(exam => exam.SubjectName);
            sheet.Columns[1].ColumnWidth = 30;
            for (int i = 0; i < session.Count(); i++)
            {
                sheet.Range[sheet.Cells[++pos, 1], sheet.Cells[pos, (subject.Count() + 1) / 2]].Merge();
                sheet.Cells[pos, 1] = FormSessionName(session.ElementAt(i).Key) + " cессия";
                sheet.Cells[pos, 1].Font.Bold = 7;
                IEnumerable<IGrouping<int, Exam>> group = exams.Where(exam => exam.Session == session.ElementAt(i).Key).GroupBy(exam => exam.GroupId);
                for (int j = 0; j < group.Count(); j++)
                {
                    sheet.Range[sheet.Cells[++pos, 1], sheet.Cells[pos, (subject.Count() + 1) / 2]].Merge();
                    sheet.Cells[pos, 1] = "Группа - " + SearchNameById(factory.GetGroup(), groups, group.ElementAt(j).Key);
                    sheet.Cells[pos, 1].Font.Italic = 7;
                    sheet.Cells[pos, 1].Font.Bold = 7;
                    sheet.Cells[++pos, 1] = "Тип";
                    var subjectAmount = group.ElementAt(j).GetEnumerator();
                    int k = 2;
                    while (subjectAmount.MoveNext())
                    {
                        sheet.Cells[pos, k] = subjectAmount.Current.AssessmentForm;
                        sheet.Cells[pos + 1, k] = subjectAmount.Current.SubjectName;
                        sheet.Columns[k].ColumnWidth = 15;
                        k++;
                    }
                    sheet.Cells[++pos, 1] = "ФИО";
                    IEnumerable<Students> studentGroup = SortingStudents(sorting, students.Where(student => student.GroupId == group.ElementAt(j).Key));
                    for (k = 0; k < studentGroup.Count(); k++)
                    {
                        sheet.Cells[++pos, 1] = FormFullName(studentGroup.ElementAt(k));
                        IEnumerable<Grades> gradeStudent = grades.Where(grade => grade.StudentId == st.GetIdStudent(studentGroup.ElementAt(k)));
                        subjectAmount = group.ElementAt(j).GetEnumerator();
                        int z = 2;
                        while (subjectAmount.MoveNext())
                        {
                            Grades studentGrades = grades.Where(grade => grade.StudentId == st.GetIdStudent(studentGroup.ElementAt(k))
                            && grade.ExamId == exe.GetIdExam(subjectAmount.Current) && subjectAmount.Current.Session == session.ElementAt(i).Key).FirstOrDefault();
                            if (studentGrades == null)
                                sheet.Cells[pos, z] = "-";
                            else
                                sheet.Cells[pos, z] = studentGrades.Grade;
                            z++;
                        }
                    }
                }
            }
            ex.Application.ActiveWorkbook.SaveCopyAs(Directory.GetCurrentDirectory() + @"\rep.xlsx");
            return true;
        }

        private static IEnumerable<Students> SortingStudents(Sorting sorting, IEnumerable<Students> students)
        {
            switch(sorting)
            {
                case Sorting.SortSurmame:
                    return students.OrderBy(student => student.Surname);
                case Sorting.SortGender:
                    return students.OrderBy(student => student.Gender);
                case Sorting.SortDateOfBirth:
                    return students.OrderBy(student => student.DateOfBirth);
            }
            throw new Exception("It is impossible to sort.");
        }


        private static string SearchNameById(IGroup group, Groups[] groups, int id)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                if(group.GetIdGroup(groups[i]) == id)
                {
                    return groups[i].GroupName;
                }
            }
            throw new Exception("Not found.");
        }


        private static float GroupMaxScore(int groupId, string session)
        {
            float[] studentsScores = AverageStudentsScore(groupId, session);
            float maxScore = -1;
            if (studentsScores.Length > 0)
            {
                maxScore = studentsScores[0];
            }
            for (int j = 1;  j < studentsScores.Length; j++)
            {
                if(studentsScores[j] > maxScore)
                {
                    maxScore = studentsScores[j];
                }
            }
            return maxScore;
        }

        private static float GroupMinScore(int groupId, string session)
        {
            float[] studentsScores = AverageStudentsScore(groupId, session);
            float minScore = -1;
            if(studentsScores.Length > 0)
            {
                minScore = studentsScores[0];
            }
            for (int j = 1; j < studentsScores.Length; j++)
            {
                if (studentsScores[j] < minScore)
                {
                    minScore = studentsScores[j];
                }
            }
            return minScore;
        }

        private static float GroupAverageScore(int id, string session)
        {
            float averageScore = 0;

            float[] studentsScores = AverageStudentsScore(id, session);
            for (int j = 0; j < studentsScores.Length; j++)
            {
                averageScore += studentsScores[j];
            }
            return averageScore / studentsScores.Length;
        }

        
        private static float[] AverageStudentsScore(int groupId, string session)
        {
            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IStudent student = factory.GetStudent();
            Students[] students = student.GetStudents();
            List<float> averageStudentsScore = new List<float>();
            for (int i = 0; i < students.Length; i++)
            {
                if(students[i].GroupId == groupId)
                {
                    int averageScore = 0;
                    int[] grades = GetStudentsGrades(student.GetIdStudent(students[i]), session);
                    foreach (int score in grades) 
                    {
                        averageScore += score;
                    }
                    averageStudentsScore.Add(averageScore / grades.Length);
                }
            }
            return averageStudentsScore.ToArray();
        }

        
        private static int[] GetStudentsGrades(int id, string session)
        {
            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IGrade grade = factory.GetGrade();            
            Grades[] grades = grade.GetGrades();
            IExam exam = factory.GetExam();
            List<int> gradeStudent = new List<int>();
            for (int i = 0; i < grades.Length; i++)
            {
                if ((grades[i].StudentId == id) && (exam.GetExamByIndex(grades[i].ExamId).Session == session))
                    gradeStudent.Add(grades[i].Grade);
            }
            return gradeStudent.ToArray();
        }

        
        private static Students[] ExpelledStudent(int groupId, string session)
        {
            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, CONNECTIONSTRING);
            IStudent student = factory.GetStudent();
            Students[] students = student.GetStudents();
            List<Students> expelledStudents = new List<Students>();
            
            for (int i = 0; i < students.Length; i++)
            {                
                if (students[i].GroupId == groupId)
                {
                    int[] grades = GetStudentsGrades(student.GetIdStudent(students[i]), session);
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

        private static string FormFullName(Students student)
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
