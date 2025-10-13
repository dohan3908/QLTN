namespace QLTN
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoGiangVien = new System.Windows.Forms.RadioButton();
            this.rdoSinhVien = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(92, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 353);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(88, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(190, 43);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(354, 292);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(190, 43);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "Thoát";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(146, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "GIAO DIỆN ĐĂNG NHẬP";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdoAdmin);
            this.panel4.Controls.Add(this.rdoGiangVien);
            this.panel4.Controls.Add(this.rdoSinhVien);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(31, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 88);
            this.panel4.TabIndex = 3;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdmin.Location = new System.Drawing.Point(413, 49);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(100, 30);
            this.rdoAdmin.TabIndex = 4;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Admin";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // rdoGiangVien
            // 
            this.rdoGiangVien.AutoSize = true;
            this.rdoGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGiangVien.Location = new System.Drawing.Point(229, 49);
            this.rdoGiangVien.Name = "rdoGiangVien";
            this.rdoGiangVien.Size = new System.Drawing.Size(141, 30);
            this.rdoGiangVien.TabIndex = 3;
            this.rdoGiangVien.TabStop = true;
            this.rdoGiangVien.Text = "Giảng viên";
            this.rdoGiangVien.UseVisualStyleBackColor = true;
            // 
            // rdoSinhVien
            // 
            this.rdoSinhVien.AutoSize = true;
            this.rdoSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSinhVien.Location = new System.Drawing.Point(57, 49);
            this.rdoSinhVien.Name = "rdoSinhVien";
            this.rdoSinhVien.Size = new System.Drawing.Size(127, 30);
            this.rdoSinhVien.TabIndex = 2;
            this.rdoSinhVien.TabStop = true;
            this.rdoSinhVien.Text = "Sinh viên";
            this.rdoSinhVien.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đăng nhập với tư cách:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(31, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 58);
            this.panel3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(190, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(31, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 55);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(190, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTN.Properties.Resources.abstract_light_blue_curve_background_blue_beauty_dynamic_wallpaper_with_wave_shapes_suitable_for_business_selling_banners_ads_events_templates_pages_webs_and_others_vector;
            this.ClientSize = new System.Drawing.Size(795, 437);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.RadioButton rdoGiangVien;
        private System.Windows.Forms.RadioButton rdoSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnLogin;
    }
}

