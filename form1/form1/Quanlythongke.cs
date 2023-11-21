using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{

    public partial class QuanlyThongKe : Form
    {
       // Form ql;
        Ketnoi kn = new Ketnoi();
        public QuanlyThongKe()
        {
           
            InitializeComponent();
            thongke();
           

        }


        public void getdata()
        {
            string query = "select Row_number() over(ORDER BY MaThongKe) STT, * from ThongKe";
            DataSet ds = kn.selectData(query);
            dgvThongke.DataSource = ds.Tables[0];
        }

        private void thongke()
        {
            DateTime now = DateTime.Now;
            int thang = now.Month; // Lấy tháng hiện tại
            int nam = now.Year;
            string sql = string.Format("select * from Thongke WHERE DATEPART(yyyy, NgayThongKe) ={0} AND DATEPART(mm, NgayThongKe) ={1}", nam, thang);
            DataSet gtr = kn.selectData(sql);
            if (gtr.Tables[0].Rows.Count > 0)
            {
                getdata();
            }
            else
            {
                ThucHienThongKe(nam, thang);
            }


        }

        private void ThucHienThongKe(int nam, int month)
        {
            // Thực hiện chức năng thống kê ở đây
            // Lấy dữ liệu, tính toán tổng tiền, sau đó thêm vào bảng thống kê
            // ...
            double giatien = 0.0;

            Ketnoi kn = new Ketnoi();
            int thang = month - 1;
            int year = nam;
            int thangtk = 0;
            int namtk = 0;
            string query = "";
            string selectphieu = "";

            if (thang == 1)
            {
                namtk = year - 1;
                thangtk = 12;
                query = string.Format("SELECT SUM(ThanhTien) AS TongDoanhThu, count(MaPhieu) as TongSoPhieu FROM TaoPhieuDangKy WHERE DATEPART(yyyy, NgayTaoPhieu) = {0} AND DATEPART(mm, NgayTaoPhieu) = {1}", year - 1, 12);
                selectphieu = string.Format("SELECT SUM(sovedat) AS Tongsovedate FROM TaoPhieuDangKy WHERE DATEPART(yyyy, NgayTaoPhieu) ={0} AND DATEPART(mm, NgayTaoPhieu) = {1}", year - 1, 12);
            }
            else
            {
                selectphieu = string.Format("SELECT SUM(sovedat) AS Tongsovedate FROM TaoPhieuDangKy WHERE DATEPART(yyyy, NgayTaoPhieu) ={0} AND DATEPART(mm, NgayTaoPhieu) ={1}", nam, thang);
                namtk = nam;
                thangtk = thang;

                query = string.Format("SELECT SUM(ThanhTien) AS TongDoanhThu, count(MaPhieu) as TongSoPhieu FROM TaoPhieuDangKy WHERE DATEPART(yyyy, NgayTaoPhieu) = {0} AND DATEPART(mm, NgayTaoPhieu)", nam, thang);
            }

            DataSet sophieutao = kn.selectData(selectphieu);
            string tongsove = sophieutao.Tables[0].Rows[0]["Tongsovedate"].ToString();
            if (tongsove == "")
            {
                return;
            }
            int TongSove = Convert.ToInt32(tongsove);
            DataSet ds = kn.selectData(query);
            string value = ds.Tables[0].Rows[0]["TongDoanhThu"].ToString();
            giatien = Double.Parse(value);
            DateTime now = DateTime.Now;

            int ngay = now.Day;     // Lấy ngày hiện tại
            int Thang = now.Month;  // Lấy tháng hiện tại
            int Nam = now.Year;
            string ngaythongke = "" + Nam + "-" + Thang + "-" + ngay;
            if (value != null)
            {
                string sql = string.Format("IF NOT EXISTS (SELECT * FROM Thongke  WHERE DATEPART(yyyy, NgayThongKe) = {0} AND DATEPART(mm, NgayThongKe) ={1}) BEGIN insert into ThongKe(NgayThongKe, SoPhieuDangKy, TongSoTienDatTour, thangthongke)values('{2}', {3}, {4},'{5}')END", Nam, Thang, ngaythongke, TongSove, giatien, namtk + " /" + thangtk);

                bool kt = kn.Thucthi(sql);
                if (kt)
                {
                    MessageBox.Show("Them thanh cong!");

                    getdata();
                }
                else
                    MessageBox.Show("Bạn đã thống kê tháng này rồi" + Nam + "/" + Thang);
            }
        }

        private void QuanlyThongKe_Load(object sender, EventArgs e)
        {

        }
        private void btnSeach_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from Thongke  WHERE DATEPART(yyyy, NgayThongKe) = {0} OR DATEPART(mm, NgayThongKe) ={0}", txttimkiemtheothang.Text);
            DataSet ds = kn.selectData(query);
            dgvThongke.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.ql.Show();
            //this.Hide();
        }
    }
}
