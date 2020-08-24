using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public interface IGroup
    {
        string[] GetGroupName();

        int GetIndexByName(string name);
        string GetGroupByIndex(int id);
    }
}
