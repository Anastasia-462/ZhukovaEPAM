using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public interface IExam
    {
        string[] GetSubjectName();
        DateTime[] GetExamDate();

        int GetIndexByName(string name);
        int GetGroupByExamIndex(int id);
    }
}
