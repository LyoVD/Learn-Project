using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task2_UniversityEmployee.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Person(string name, string lastName, Address address)
        {
            Name = name;
            LastName = lastName;
            Address = address;
        }
    }
}
