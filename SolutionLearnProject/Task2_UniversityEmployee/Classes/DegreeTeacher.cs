using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_UniversityEmployee.Classes
{
    public class DegreeTeacher: Teacher
    {
        public string ScienceDegree;
        public string TitleOfTeacher;

        public DegreeTeacher(Person person, string taxID, Course course, string degree, string title) : base(person, taxID, course)
        {
            ScienceDegree = degree;
            TitleOfTeacher = title;
        }
       
    }
}
