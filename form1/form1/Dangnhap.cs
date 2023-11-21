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
    public partial class Dangnhap : UserControl
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        private void btDangnhap1_Click(object sender, EventArgs e)
        {
            string check_nhanvien = string.Format("select * from TaiKhoan where TenDangNhap = '{0}' and MatKhau = '{1}' and chucvu = 'NhanVien'", txtEmail.Text, txtMatkhau.Text);
            string check_quanly = string.Format("select * from TaiKhoan where TenDangNhap = '{0}' and MatKhau = '{1}' and chucvu = 'QuanLy'", txtEmail.Text, txtMatkhau.Text);
            DataSet ds_quanly = kn.selectData(check_quanly);
            DataSet ds_nhanvien = kn.selectData(check_nhanvien);
            if (ds_nhanvien.Tables[0].Rows.Count == 1)
            {
                txtEmail.Text = "";
                txtMatkhau.Text = "";
                MessageBox.Show("Đăng nhập thành công ");
                Form1 frm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (frm != null) frm.Hide();


                FormTrangchuNhanVien frm_nhanvien = new FormTrangchuNhanVien(frm);
                frm_nhanvien.Show();

            }
            else if(ds_quanly.Tables[0].Rows.Count == 1)
            {
                txtEmail.Text = "";
                txtMatkhau.Text = "";
                MessageBox.Show("Đăng nhập thành công ");
                Form1 frm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (frm != null) frm.Hide();


                    quanlynhanvien quanly = new quanlynhanvien(frm);
                    quanly.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại ");
            }
        }

       
    }
 }
 
