using System;
using System.Net.Sockets;

namespace Task1_Candidate.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        
        public Person(string name, 
                      string lastName, 
                      Address address
                      )
        {
            Name = name;
            LastName = lastName;
            Address = address;
        }
    }
}