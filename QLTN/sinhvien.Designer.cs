namespace QLTN
{
    partial class sinhvien
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
            this.lblSua2 = new System.Windows.Forms.Button();
            this.lblXoa2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblLopchuyennganh = new System.Windows.Forms.Label();
            this.txtHotenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtLopchuyennganh = new System.Windows.Forms.TextBox();
            this.lblLuu2 = new System.Windows.Forms.Button();
            this.lblTTSV = new System.Windows.Forms.Label();
            this.lblThem2 = new System.Windows.Forms.Button();
            this.grdTTSV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdTTSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSua2
            // 
            this.lblSua2.Location = new System.Drawing.Point(221, 545);
            this.lblSua2.Name = "lblSua2";
            this.lblSua2.Size = new System.Drawing.Size(114, 39);
            this.lblSua2.TabIndex = 1;
            this.lblSua2.Text = "Sửa";
            this.lblSua2.UseVisualStyleBackColor = true;
            this.lblSua2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblXoa2
            // 
            this.lblXoa2.Location = new System.Drawing.Point(417, 545);
            this.lblXoa2.Name = "lblXoa2";
            this.lblXoa2.Size = new System.Drawing.Size(114, 39);
            this.lblXoa2.TabIndex = 2;
            this.lblXoa2.Text = "Xóa";
            this.lblXoa2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ và tên :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(23, 136);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(100, 20);
            this.lblMaSV.TabIndex = 4;
            this.lblMaSV.Text = "Mã sinh viên:";
            this.lblMaSV.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLopchuyennganh
            // 
            this.lblLopchuyennganh.AutoSize = true;
            this.lblLopchuyennganh.Location = new System.Drawing.Point(23, 190);
            this.lblLopchuyennganh.Name = "lblLopchuyennganh";
            this.lblLopchuyennganh.Size = new System.Drawing.Size(148, 20);
            this.lblLopchuyennganh.TabIndex = 6;
            this.lblLopchuyennganh.Text = "Lớp chuyên ngành :";
            // 
            // txtHotenSV
            // 
            this.txtHotenSV.Location = new System.Drawing.Point(202, 83);
            this.txtHotenSV.Name = "txtHotenSV";
            this.txtHotenSV.Size = new System.Drawing.Size(247, 26);
            this.txtHotenSV.TabIndex = 7;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(202, 130);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(247, 26);
            this.txtMaSV.TabIndex = 8;
            // 
            // txtLopchuyennganh
            // 
            this.txtLopchuyennganh.Location = new System.Drawing.Point(202, 184);
            this.txtLopchuyennganh.Name = "txtLopchuyennganh";
            this.txtLopchuyennganh.Size = new System.Drawing.Size(247, 26);
            this.txtLopchuyennganh.TabIndex = 9;
            // 
            // lblLuu2
            // 
            this.lblLuu2.Location = new System.Drawing.Point(656, 545);
            this.lblLuu2.Name = "lblLuu2";
            this.lblLuu2.Size = new System.Drawing.Size(114, 39);
            this.lblLuu2.TabIndex = 10;
            this.lblLuu2.Text = "Lưu";
            this.lblLuu2.UseVisualStyleBackColor = true;
            // 
            // lblTTSV
            // 
            this.lblTTSV.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTSV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTTSV.Location = new System.Drawing.Point(241, 33);
            this.lblTTSV.Name = "lblTTSV";
            this.lblTTSV.Size = new System.Drawing.Size(339, 43);
            this.lblTTSV.TabIndex = 0;
            this.lblTTSV.Text = "THÔNG TIN SINH VIÊN";
            // 
            // lblThem2
            // 
            this.lblThem2.Location = new System.Drawing.Point(27, 545);
            this.lblThem2.Name = "lblThem2";
            this.lblThem2.Size = new System.Drawing.Size(114, 39);
            this.lblThem2.TabIndex = 11;
            this.lblThem2.Text = "Thêm";
            this.lblThem2.UseVisualStyleBackColor = true;
            this.lblThem2.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdTTSV
            // 
            this.grdTTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTTSV.Location = new System.Drawing.Point(26, 252);
            this.grdTTSV.Name = "grdTTSV";
            this.grdTTSV.RowHeadersWidth = 62;
            this.grdTTSV.RowTemplate.Height = 28;
            this.grdTTSV.Size = new System.Drawing.Size(743, 242);
            this.grdTTSV.TabIndex = 12;
            // 
            // sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.grdTTSV);
            this.Controls.Add(this.lblThem2);
            this.Controls.Add(this.lblTTSV);
            this.Controls.Add(this.lblLuu2);
            this.Controls.Add(this.txtLopchuyennganh);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtHotenSV);
            this.Controls.Add(this.lblLopchuyennganh);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblXoa2);
            this.Controls.Add(this.lblSua2);
            this.Name = "sinhvien";
            this.Text = "sinhvien";
            this.Load += new System.EventHandler(this.sinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTTSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button lblSua2;
        private System.Windows.Forms.Button lblXoa2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblLopchuyennganh;
        private System.Windows.Forms.TextBox txtHotenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtLopchuyennganh;
        private System.Windows.Forms.Button lblLuu2;
        private System.Windows.Forms.Label lblTTSV;
        private System.Windows.Forms.Button lblThem2;
        private System.Windows.Forms.DataGridView grdTTSV;
    }
}