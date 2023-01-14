using System;
using System.Runtime.InteropServices;

namespace Task1_Candidate.Classes
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public Address(string city, string street, string house, string apartment)
        {
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }
    }
}