using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Building.Classes
{
    public class University
    {
        public string Name; 
        public string Rector;
        public UniversityEmployee[] UniversityEmployees;       
        public Building[] Buildings { get; set; }

        public University(string name, string rector, UniversityEmployee[] employees, Building[] buildings)
        {
            Name = name;
            Rector = rector;
            UniversityEmployee = employees;
            Buildings = buildings;
        }

    }
}
