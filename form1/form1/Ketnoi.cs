using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace form1
{
    public class Ketnoi
    {
        public static string constr = @"Data Source=DESKTOP-UCK7P15\SQLEXPRESS;Initial Catalog=QLDatTour;Integrated Security=True";
        SqlConnection conn;
        public Ketnoi()
        {
            conn = new SqlConnection(constr);
        }
        public DataSet selectData(string truyvan)
        {
            
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
            da.Fill(ds);
            return ds;
        }
        public bool Thucthi(string truyvan)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
    }
}
