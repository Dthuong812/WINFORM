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


        // Xử lý khi nhấn nút `C` (xoá code)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                txtSecurityCode.Text += btn.Text;
            }
        }
        // Xử lý khi nhấn nút `#` (kiểm tra quyền truy cập)

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            string code = txtSecurityCode.Text;
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string group;

            switch (code)
            {
                case "1645":
                case "1689":
                    group = "Technicians";
                    break;
                case "8345":
                    group = "Custodians";
                    break;
                case "9998":
                case "1006":
                case "1008":
                    group = "Scientists";
                    break;
                default:
                    group = "Restricted Access!";
                    break;
            }

            // Lưu vào ListBox
            listBoxAccessLog.Items.Add($"{currentTime} {group}");

            // Xoá code nhập vào
            txtSecurityCode.Clear();
        }
    }
}
