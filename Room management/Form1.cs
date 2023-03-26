using System.Windows.Forms;

namespace Room_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void chkShoeHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            txtPassword.UseSystemPasswordChar = !ch.Checked;
        }

        //ปุ่ม Login 
        private void button1_Click(object sender, EventArgs e)
        {
            string u = txtUsername.Text;
            string p = txtPassword.Text;
            Index index = new Index();
            if (u == "Admin" && p == "012345")
            {
                index.ShowDialog();
                this.DialogResult= DialogResult.OK;
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือพาสเวิร์ดไม่ถูกต้อง");
            }
            
        }
    }
}