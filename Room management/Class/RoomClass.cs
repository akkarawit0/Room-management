using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_management.Class
{
    public class RoomClass
    {
        protected string Room_number { get; set; }
        protected Bitmap Room_Image { get; set; }
        protected string Room_price { get; set; }
        public string Get_Room_Number() { return Room_number; }
        public string Get_Room_Price() { return Room_price; }
        public Bitmap Get_Room_Image() { return Room_Image; }
    }
}
