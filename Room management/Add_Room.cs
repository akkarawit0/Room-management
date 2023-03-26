using Room_management.Class;
using Room_management.Class.Rooms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room_management
{
    public partial class Add_Room : Form
    {
        List<RoomClass> rooms = new List<RoomClass>();
        public Add_Room()
        {
            InitializeComponent();
            rooms.Add(new Room_1());
            rooms.Add(new Room_2());
            rooms.Add(new Room_3());
            rooms.Add(new Room_4());
            rooms.Add(new Room_5());
            foreach (RoomClass room in rooms)
            {
                comboBox2.Items.Add($"ห้องหมายเลขที่ {room.Get_Room_Number()}");
            }
        }

        private void On_Combobox_Change(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            pictureBox1.Image = rooms[cb.SelectedIndex].Get_Room_Image();
            txt_Room_number.Text = rooms[cb.SelectedIndex].Get_Room_Number();
            txtRoom_price.Text = rooms[cb.SelectedIndex].Get_Room_Price();
        }
    }
}
