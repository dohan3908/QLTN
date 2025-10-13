namespace QLTN
{
    partial class frmQLSinhVien
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvListTK = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuuThongTin = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTK)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnXem);
            this.panel8.Controls.Add(this.btnXoa);
            this.panel8.Controls.Add(this.btnSua);
            this.panel8.Controls.Add(this.btnThem);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(969, 100);
            this.panel8.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(462, 19);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(102, 59);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(320, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 59);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(178, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 59);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(36, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 59);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvListTK);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(0, 100);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(577, 415);
            this.panel9.TabIndex = 3;
            // 
            // dgvListTK
            // 
            this.dgvListTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTK.Location = new System.Drawing.Point(5, 38);
            this.dgvListTK.Name = "dgvListTK";
            this.dgvListTK.RowHeadersWidth = 62;
            this.dgvListTK.RowTemplate.Height = 28;
            this.dgvListTK.Size = new System.Drawing.Size(569, 377);
            this.dgvListTK.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh sách tài khoản:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuuThongTin);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Location = new System.Drawing.Point(580, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 415);
            this.panel1.TabIndex = 4;
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThongTin.Location = new System.Drawing.Point(224, 331);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(144, 60);
            this.btnLuuThongTin.TabIndex = 5;
            this.btnLuuThongTin.Text = "Lưu thông tin";
            this.btnLuuThongTin.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtTenHienThi);
            this.panel13.Controls.Add(this.label9);
            this.panel13.Location = new System.Drawing.Point(2, 66);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(387, 57);
            this.panel13.TabIndex = 5;
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Location = new System.Drawing.Point(139, 14);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(238, 26);
            this.txtTenHienThi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên hiển thị:";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txtUserID);
            this.panel14.Controls.Add(this.label10);
            this.panel14.Location = new System.Drawing.Point(0, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(387, 57);
            this.panel14.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(141, 14);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(236, 26);
            this.txtUserID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "User ID:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtLop);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Location = new System.Drawing.Point(580, 229);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(387, 57);
            this.panel12.TabIndex = 6;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(141, 14);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(236, 26);
            this.txtLop.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lớp:";
            // 
            // frmQLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 521);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Name = "frmQLSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLSinhVien";
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgvListTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLuuThongTin;
    }
}