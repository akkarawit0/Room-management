using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_management.Class
{
    public class Database
    {
        public RoomClass Room { get; set; }
        public Person Room_Roomleader { get; set; }
        public string Room_checkin { get; set; }
        public string Room_checkout { get; set; }
    }
}
