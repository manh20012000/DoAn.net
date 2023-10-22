using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace form1
{
    public partial class ThemKhachHang : UserControl
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        public void getdata()
        {
            string query = " select * from  KhachHang ";
            DataSet ds = kn.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void Clear()
        {

            txtTenKhachHang.Text = "";
            txtSDT.Text = "";
            txtQueQuan.Text = "";
            txtMaKhachHang.Text = "";
          
        }
       

        private void btXoa_Click(object sender, EventArgs e)
        {

            DialogResult thongbao;
            thongbao = MessageBox.Show("Ban co muon xoa khong ?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(Ketnoi.constr);
                conn.Open();
                string query = string.Format("delete from KhachHang WHERE MaKhachHang = {0}", txtMaKhachHang.Text);
                bool kt = kn.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Xóa thành công ");
                    getdata();
                    btclear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }

            }
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            Clear();
            getdata();
        }

    

        private void btSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Ketnoi.constr);
            try
            {
                conn.Open();
                string query = string.Format("update KhachHang set HoTen = '{0}', Gioitinh = N'{1}', SDT = '{2}', QueQuan = '{3}', NgaySinh = '{4}' where MaKhachHang = N'{5}'",
                txtTenKhachHang.Text, cbGioiTinh.Text, txtSDT.Text, txtQueQuan.Text, DateTimeNgaySinh.Value.ToString("yyyy/MM/dd"), txtMaKhachHang.Text);
                bool kt = kn.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Sua thanh cong!");
                    getdata();
                    btclear.PerformClick();

                }
                else
                    MessageBox.Show("Sua that bai");
                    conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi :" + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ScrollBars = ScrollBars.Both;
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtMaKhachHang.Text = dataGridView1.Rows[r].Cells["MaKhachHang"].Value.ToString();
                txtTenKhachHang.Text = dataGridView1.Rows[r].Cells["HoTen"].Value.ToString();
                cbGioiTinh.SelectedValue = dataGridView1.Rows[r].Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[r].Cells["SDT"].Value.ToString();
                txtQueQuan.Text = dataGridView1.Rows[r].Cells["QueQuan"].Value.ToString();
                DateTimeNgaySinh.Text = dataGridView1.Rows[r].Cells["NgaySinh"].Value.ToString();

            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string query = string.Format(" select * from KhachHang where SDT like N'%{0}%'", textTim.Text);
            DataSet ds = kn.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
