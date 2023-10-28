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
    public partial class formDangkytour : Form
    {
      
        Ketnoi ketnoi=new Ketnoi();
        Toudulich tour;
        public double thanhtien = 0;
        public int soveconlai = 0;
        public formDangkytour(Toudulich tour)
        {
            Ketnoi kn = new Ketnoi();
            InitializeComponent(); 
            this.tour=tour;
            txtmatour.Text = tour.MaTour1.ToString();
            txttentour.Text = tour.TenTour1.ToString();
            txtdongia.Text = tour.GiaTien.ToString();
            txtsove.Text = tour.Sove.ToString();
            string query = "select MaNhanVien from NhanVien";
            DataSet ds = kn.selectData(query);
            cbxNhanvien.DataSource = ds.Tables[0];
            cbxNhanvien.DisplayMember = "MaNhanVien";
            cbxNhanvien.ValueMember = "MaNhanVien";
        }

      
        private void button1_Click(object sender, EventArgs e)
        {    
            double dongia;
            if (double.TryParse(txtdongia.Text, out dongia))
            { int sovedat ;
               
                Console.WriteLine(txtsovechon.Text);
                if (int.TryParse(txtsovechon.Text, out sovedat))
                {  
                    Console.WriteLine(dongia);
                    double thanhtien = dongia * sovedat;
                    txtthanhtien.Text = thanhtien.ToString()+".000";
                }
                else
                {
                }
            }
            else
            {
                
            }
        }

        private void txtthanhtien_TextChanged(object sender, EventArgs e)
        {
               
        }
        private void btndnagkys_Click(object sender, EventArgs e)
        {
            Console.WriteLine("giá trị dược log ra =>>"+txtsdt.Text+" | "+ txtquequan.Text+ " | " + dateTimeNgay.Value.ToString("yyyy-MM-dd")+"|"+cbxgioitinh.SelectedItem );
            if (txtten.Text == "" || txtthanhtien.Text == "")
            {
                MessageBox.Show("vui lòng nhập lại thông tin");
            }
            else
            {
               
                try
                {

                    string query = string.Format("insert into khachHang(HoTen, GioiTinh, SDT, QueQuan, NgaySinh)values(n'{0}',n'{1}','{2}',n'{3}','{4}')", txtten.Text, cbxgioitinh.SelectedItem, txtsdt.Text, txtquequan.Text, dateTimeNgay.Value.ToString("yyyy-MM-dd"));
                    bool kt = ketnoi.Thucthi(query);
                    soveconlai = int.Parse(txtsove.Text) - int.Parse(txtsovedat.Text);
                    if (kt)
                    {

                        Console.WriteLine(kt);
                        string updatve = string.Format("update TourDL set sove = '{0}' where Matour={1} ", tour.MaTour1.ToString(), soveconlai);
                        bool update = ketnoi.Thucthi(updatve);
                        if (update)
                        {
                            MessageBox.Show("Them thanh cong!");
                        }
                        else
                        {
                            MessageBox.Show("Them thât bại" +
                                "!");
                        }


                    }
                    else
                        MessageBox.Show("Them that bai");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi ket noi :" + ex.Message);
                }
                }
            }

        private void formDangkytour_Load(object sender, EventArgs e)
        {

        }
    }
}
