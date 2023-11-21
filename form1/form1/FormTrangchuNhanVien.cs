using System;
using System.Windows.Forms;

namespace form1
{
    public partial class FormTrangchuNhanVien : Form
    {
        private Form1 frm_dangnhap;
        public FormTrangchuNhanVien()
        {
            InitializeComponent();

        }
        public FormTrangchuNhanVien(Form1 frm_dangnhap)
        {
            InitializeComponent();
            this.frm_dangnhap = frm_dangnhap;
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


        private void FormTrangchuNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void panelUserControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeU1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_dangnhap.Show();

            this.Hide();
        }
    }
}
