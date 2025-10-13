namespace QLTN
{
    partial class frmMainAdmin
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qUANLYNGƯƠIDUNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quanLyGiangViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hÊTHÔNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.status2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quanLyKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hÊTHÔNGToolStripMenuItem,
            this.qUANLYNGƯƠIDUNGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qUANLYNGƯƠIDUNGToolStripMenuItem
            // 
            this.qUANLYNGƯƠIDUNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.toolStripSeparator1,
            this.quanLyGiangViênToolStripMenuItem,
            this.toolStripSeparator3,
            this.quanLyKhoaToolStripMenuItem});
            this.qUANLYNGƯƠIDUNGToolStripMenuItem.Name = "qUANLYNGƯƠIDUNGToolStripMenuItem";
            this.qUANLYNGƯƠIDUNGToolStripMenuItem.Size = new System.Drawing.Size(283, 36);
            this.qUANLYNGƯƠIDUNGToolStripMenuItem.Text = "QUẢN LÝ NGƯỜI DÙNG";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(320, 40);
            this.quanLyToolStripMenuItem.Text = "Quản lý sinh viên";
            this.quanLyToolStripMenuItem.Click += new System.EventHandler(this.quanLyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(317, 6);
            // 
            // quanLyGiangViênToolStripMenuItem
            // 
            this.quanLyGiangViênToolStripMenuItem.Name = "quanLyGiangViênToolStripMenuItem";
            this.quanLyGiangViênToolStripMenuItem.Size = new System.Drawing.Size(320, 40);
            this.quanLyGiangViênToolStripMenuItem.Text = "Quản lý giảng viên";
            this.quanLyGiangViênToolStripMenuItem.Click += new System.EventHandler(this.quanLyGiangViênToolStripMenuItem_Click);
            // 
            // hÊTHÔNGToolStripMenuItem
            // 
            this.hÊTHÔNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTaiKhoanToolStripMenuItem,
            this.toolStripSeparator2,
            this.đăngXuâtToolStripMenuItem});
            this.hÊTHÔNGToolStripMenuItem.Name = "hÊTHÔNGToolStripMenuItem";
            this.hÊTHÔNGToolStripMenuItem.Size = new System.Drawing.Size(148, 36);
            this.hÊTHÔNGToolStripMenuItem.Text = "HỆ THỐNG";
            // 
            // thôngTinTaiKhoanToolStripMenuItem
            // 
            this.thôngTinTaiKhoanToolStripMenuItem.Name = "thôngTinTaiKhoanToolStripMenuItem";
            this.thôngTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(328, 40);
            this.thôngTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(325, 6);
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(328, 40);
            this.đăngXuâtToolStripMenuItem.Text = "Thoát chương trình";
            this.đăngXuâtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuâtToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status1,
            this.toolStripProgressBar1,
            this.status2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1027, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status1
            // 
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(65, 25);
            this.status1.Text = "Ready!";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            // 
            // status2
            // 
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(50, 25);
            this.status2.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(317, 6);
            // 
            // quanLyKhoaToolStripMenuItem
            // 
            this.quanLyKhoaToolStripMenuItem.Name = "quanLyKhoaToolStripMenuItem";
            this.quanLyKhoaToolStripMenuItem.Size = new System.Drawing.Size(320, 40);
            this.quanLyKhoaToolStripMenuItem.Text = "Quản lý khoa";
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 549);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainAdmin";
            this.Text = "frmMainAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUANLYNGƯƠIDUNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quanLyGiangViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hÊTHÔNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel status2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem quanLyKhoaToolStripMenuItem;
    }
}