using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class SecurityPanel : Form
    {
        public SecurityPanel()
        {
            InitializeComponent();
        }

        private void SecurityPanel_Load(object sender, EventArgs e)
        {

        }

        //Xử lý khi nhấn các nút số
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                txtAccessCode.Text += btn.Text;
            }
        }

        private void CheckAccessCode(string code)
        {
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string group = "";
            string status = "Access Denied";

            if (code == "1645" || code == "1689")
            {
                group = "Technicians";
                status = "Access Granted";
            }
            else if (code == "8345")
            {
                group = "Custodians";
                status = "Access Granted";
            }
            else if (code == "9998" || (int.TryParse(code, out int num) && num >= 1006 && num <= 1008))
            {
                group = "Scientists";
                status = "Access Granted";
            }
            else if (code.Length == 1)
            {
                status = "Restricted Access";
            }

            DisplayResult(currentTime, group, status);
        }

        private void DisplayResult(string time, string group, string status)
        {
            textBox1.AppendText($"Time: {time} | Group: {group} | Status: {status}\r\n");
        }

        private void btnCheckAccess_Click_1(object sender, EventArgs e)
        {
            CheckAccessCode(txtAccessCode.Text);
            txtAccessCode.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccessCode.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
