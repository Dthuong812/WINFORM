using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = a + b;
            txtSum.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Thông báo", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void rdoSum_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c= int.Parse(txtC.Text);
            int d = int.Parse(txtD.Text);
            int sum = a + b + c + d;
            txtSum.Text = sum.ToString();
        }

        private void rdoTru_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            int d = int.Parse(txtD.Text);
            int sum = a - b - c - d;
            txtSum.Text = sum.ToString();
        }

        private void rdoTich_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            int d = int.Parse(txtD.Text);
            int sum = a * b * c * d;
            txtSum.Text = sum.ToString();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            frm2 frm = new frm2();
            this.Hide();
            frm.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 frm = new frm2();
            this.Hide();
            frm.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecurityPanel securityPanel = new SecurityPanel();
            this.Hide();
           securityPanel.ShowDialog();
        }
    }
    
}
