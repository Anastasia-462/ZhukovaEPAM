using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public interface IGrade
    {
        int[] GetGrades();

        string GetExamByGradeIndex(int id);
        string GetStudentByGradeIndex(int id);
    }
}
