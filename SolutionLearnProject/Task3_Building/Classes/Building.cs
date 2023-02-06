using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Building.Classes
{
    public class Building
    {
        public Address Address;
        public Room[] Room;

        public Building(Address address, Room[] room)
        {
            Address = address;
            Room = room;
        }
    }
}
