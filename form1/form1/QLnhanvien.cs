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
    public partial class QLnhanvien : Form
    {
       
        public QLnhanvien()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        public void getdata()
        {
            string query = "select * from NhanVien  ";
            DataSet ds = kn.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void QLnhanvien_Load(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
