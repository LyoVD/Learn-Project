using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_UniversityEmployee.Classes
{
    public class Teacher: UniversityEmployee
    {    
        public Course Course { get; set; }
        
        public Teacher(Person person, int taxID, Course course) : 
            base(person, taxID)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return Person.Name + " " + Person.LastName +
                ". This person is teacher. Course: " +
                Course.CourseName + " " + Course.CourseDescription;
        }


    }
}
