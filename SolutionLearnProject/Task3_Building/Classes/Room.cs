using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Building.Classes
{
    public class Room
    {
        public int RoomNumber;
        public string Purpose;

        public Room (int roomNumber, string purpose)
        {
            RoomNumber = roomNumber;
            Purpose = purpose;
        }
    }
}
