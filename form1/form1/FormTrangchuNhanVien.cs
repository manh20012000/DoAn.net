using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class FormTrangchuNhanVien : Form
    {
        public FormTrangchuNhanVien()
        {
            InitializeComponent();

        }
        private void ShowUserControl(UserControl userControl)
        {
            // Xóa UserControl hiện tại (nếu có)
            panelUserControl.Controls.Clear();

            // Thêm UserControl mới vào Panel
            userControl.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(userControl);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowUserControl(new HomeU());
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            ShowUserControl(new DangKiTourU());
        }

        private void btnThme_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ThemThongTinU());
        }

        private void btnttcanhan_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ThemThongTinU());
        }

        private void homeU1_Load(object sender, EventArgs e)
        {

        }

        private void FormTrangchuNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void panelUserControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
