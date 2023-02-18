using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_UniversityEmployee.Classes
{
    public class DegreeTeacher: Teacher
    {
        public string ScienceDegree { get; set; }
        public string TitleOfTeacher { get; set; }

        public DegreeTeacher(Person person, 
                             int taxID, 
                             Course course, 
                             string degree,
                             string title
                             ) : 
            base(person, taxID, course)
        {
            ScienceDegree = degree;
            TitleOfTeacher = title;
        }

        public override string GetOfficialDuties()
        {
            return Person.Name + " " + Person.LastName +
                ". This person is teacher. Course: " +
                Course.CourseName + " " + Course.CourseDescription + 
                " (" + ScienceDegree + ", " + TitleOfTeacher + ")";
        }

    }
}
