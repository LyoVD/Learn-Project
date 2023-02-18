using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_UniversityEmployee.Classes
{
    public class SupportStaff : UniversityEmployee
    {
        public string JobTitle { get; set; }
        
        public SupportStaff(Person person, int taxID, string jobTitle) : 
            base(person, taxID)
        {
           JobTitle = jobTitle;
        }

        public override string GetOfficialDuties()
        {
            return Person.Name + " " + Person.LastName +
               ". This person is " + JobTitle;
        }

    }
}
