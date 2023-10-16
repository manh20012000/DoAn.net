using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using form1.Model;
namespace form1
{
    class Ketnoi
    {
        string constr = @"Data Source=LEMANH;Initial Catalog=QLDatTour;Integrated Security=True";
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
        public List<Toudulich> SelectAll()
        {
            List<Toudulich> danhsach = new List<Toudulich>();

            try
            {

                {
                    conn.Open();
                    string SelectTour = "SELECT * FROM TourDL,Diadiem where Diadiem.MaDiaDiem = TourDL.MaDiaDiem";
                           

                    SqlCommand command = new SqlCommand(SelectTour, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    {
                        while (reader.Read())
                        {

                            int MaTour = Convert.ToInt32(reader["MaTour"]);
                            string anh = reader["Anh"].ToString();
                            string TenTour = reader["TenTour"].ToString();
                            string Thoigian = reader["ThoiGian"].ToString();
                            string  MaDiaDiem = reader["DiaChi"].ToString();
                            string Ghichu = reader["Mota"].ToString();
                            float GiaTien = Convert.ToSingle(reader["GiaTien"]);
                            string Diachi= reader["TenDiaDiem"].ToString();
                            danhsach.Add( new Toudulich(MaTour, TenTour,anh, Thoigian,  Ghichu, GiaTien, Diachi, MaDiaDiem));
                        }
                    } 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return danhsach;
        }
    }
}
