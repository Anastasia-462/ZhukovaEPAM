using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }

        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GroupId { get; set; }

        public Student() { }

    }
}
