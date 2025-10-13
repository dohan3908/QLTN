using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTN
{
    public partial class frmMainAdmin : Form
    {
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status2.Text = System.DateTime.Now.ToString();
        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSinhVien f = new frmQLSinhVien();
            f.ShowDialog();
        }

        private void quanLyGiangViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLGiangVien f = new frmQLGiangVien();
            f.ShowDialog();
        }
    }
}
