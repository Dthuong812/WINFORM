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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Admin" && txtPw.Text == "123456")
            {
                Frm1 frm = new Frm1();
                this.Hide();
                frm.ShowDialog();
            }
            else {
                DialogResult traloi;
                traloi = MessageBox.Show("Thông báo", "Nhập lại đi cưng",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK) Application.Exit();
            }
        }
    }
}
