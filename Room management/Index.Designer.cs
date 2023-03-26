namespace Room_management
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_room,
            this.Room_price,
            this.In,
            this.Out,
            this.Name_customer,
            this.Phone});
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(805, 480);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID_room
            // 
            this.ID_room.DataPropertyName = "(none)";
            this.ID_room.HeaderText = "เลขห้อง";
            this.ID_room.MinimumWidth = 6;
            this.ID_room.Name = "ID_room";
            this.ID_room.Width = 125;
            // 
            // Room_price
            // 
            this.Room_price.HeaderText = "ราคาห้องพัก";
            this.Room_price.MinimumWidth = 6;
            this.Room_price.Name = "Room_price";
            this.Room_price.Width = 125;
            // 
            // In
            // 
            this.In.HeaderText = "วัน-เดือน-ปี เข้า";
            this.In.MinimumWidth = 6;
            this.In.Name = "In";
            this.In.Width = 125;
            // 
            // Out
            // 
            this.Out.HeaderText = "วัน-เดือน-ปี ออก";
            this.Out.MinimumWidth = 6;
            this.Out.Name = "Out";
            this.Out.Width = 125;
            // 
            // Name_customer
            // 
            this.Name_customer.HeaderText = "ชื่อลูกค้า";
            this.Name_customer.MinimumWidth = 6;
            this.Name_customer.Name = "Name_customer";
            this.Name_customer.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "เบอร์โทร";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flieToolStripMenuItem,
            this.roomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flieToolStripMenuItem
            // 
            this.flieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.sevaToolStripMenuItem});
            this.flieToolStripMenuItem.Name = "flieToolStripMenuItem";
            this.flieToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.flieToolStripMenuItem.Text = "Flie";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // sevaToolStripMenuItem
            // 
            this.sevaToolStripMenuItem.Name = "sevaToolStripMenuItem";
            this.sevaToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.sevaToolStripMenuItem.Text = "Save";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.andRoomToolStripMenuItem});
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.roomToolStripMenuItem.Text = "Room";
            // 
            // andRoomToolStripMenuItem
            // 
            this.andRoomToolStripMenuItem.Name = "andRoomToolStripMenuItem";
            this.andRoomToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.andRoomToolStripMenuItem.Text = "Add room";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 525);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem flieToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem sevaToolStripMenuItem;
        private ToolStripMenuItem roomToolStripMenuItem;
        private ToolStripMenuItem andRoomToolStripMenuItem;
        private DataGridViewTextBoxColumn ID_room;
        private DataGridViewTextBoxColumn Room_price;
        private DataGridViewTextBoxColumn In;
        private DataGridViewTextBoxColumn Out;
        private DataGridViewTextBoxColumn Name_customer;
        private DataGridViewTextBoxColumn Phone;
    }
}