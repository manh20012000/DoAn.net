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
           
            InitializeComponent(); 
            this.tour=tour;
            txtmatour.Text = tour.MaTour1.ToString();
            txttentour.Text = tour.TenTour1.ToString();
            txtdongia.Text = tour.GiaTien.ToString();
            txtsove.Text = tour.Sove.ToString();
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
           

                if (txtten.Text == "" || txtthanhtien.Text == "")
            {
                MessageBox.Show("vui lòng nhập lại thông tin");
            }
            else
            {
                try { 
                 Console.WriteLine(":gdhsgdhsgdhgb->>>>" + this.txtten.Text,this.txtquequan.Text, this.cbxgioitinh.SelectedValue, this.txtsdt.Text,  this.dateTimeNgay.Value);
                string query = string.Format("insert into KhachHang(HoTen, GioiTinh, SDT, QueQuan, NgaySinh) values (N'{0}', N'{1}', '{2}' , N'{3}', '{4}')"
                ,txtten.Text, cbxgioitinh.Text, txtsdt.Text, txtquequan.Text, dateTimeNgay.Value);
                    bool kt= ketnoi.Thucthi(query); 
                    soveconlai = int.Parse(txtsove.Text) - int.Parse(txtsovedat.Text);
                    if (kt)
                    {
                        Console.WriteLine(kt);
                      /*  string updatve = string.Format("update TourDL set sove = '{0}' where Matour={1} ", tour.MaTour1.ToString(), soveconlai);
                        bool update = ketnoi.Thucthi(updatve);
                        if (update) {
                            MessageBox.Show("Them thanh cong!");
                        }
                        else
                        {
                            MessageBox.Show("Them thât bại" +
                                "!");
                        }
                        */

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

       
    }
}
