using System;
using System.Runtime.InteropServices;

namespace Task1_Candidate.Classes
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        private int _house;
        public int House 
        { 
            get
            {
                return _house;
            }
            set
            {
                if (value > 0)
                {
                    _house = value;
                }
            }
        }
        private int _apartment;
        public int Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                if (value > 0)
                {
                    _apartment = value;
                }
            }
        }
        
        public Address(string city, 
                       string street, 
                       int house, 
                       int apartment
                       )
        {
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }
    }
}