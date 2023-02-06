using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Building.Classes
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public Address(string city, string street, string house)
        {
            City = city;
            Street = street;
            House = house;
        }
    }
}
