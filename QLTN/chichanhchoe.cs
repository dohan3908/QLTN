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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chichanhchoe_Load(object sender, EventArgs e)
        {

        }

        private void qUẢNLÝGIẢNGVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýGiảngViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void status2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status2.Text  = System.DateTime.Now.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giangvien f = new giangvien();
            f.Show();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sinhvien f = new sinhvien();
            f.Show();
        }
    }
}
