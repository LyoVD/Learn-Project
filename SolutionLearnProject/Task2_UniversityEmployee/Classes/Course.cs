using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_UniversityEmployee.Classes
{
    public class Course 
    {
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }

        public Course(string name, string description)
        {
            CourseName = name;
            CourseDescription = description;
        }
    
    }
}
