using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_UniversityEmployee.Classes
{
    public class Teacher: UniversityEmployee
    {    
        private Course Course { get; set; }
        public Teacher(Person person, string taxID, Course course) : base(person, taxID)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return base.GetOfficialDuties() + "teacher. Course: " + Course.CourseName + " " + Course.CourseDescription;
        }


    }
}
