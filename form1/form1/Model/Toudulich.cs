using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1
{
    public class Toudulich
    {
        private int MaTour;
        private String TenTour;
        private string anh;
        private string Thoigian;
        private String Mota;
        private float giaTien;
        private string diachi;
        private string maDiadiem;

        public Toudulich(int maTour, string tenTour, string anh, string thoigian, string mota, float giaTien, string diachi, string maDiadiem)
        {
            MaTour = maTour;
            TenTour = tenTour;
            this.anh = anh;
            Thoigian = thoigian;
            Mota = mota;
            this.giaTien = giaTien;
            this.diachi = diachi;
            this.maDiadiem = maDiadiem;
        }

        public int MaTour1 { get => MaTour; set => MaTour = value; }
        public string TenTour1 { get => TenTour; set => TenTour = value; }
        public string Anh { get => anh; set => anh = value; }
        public string Thoigian1 { get => Thoigian; set => Thoigian = value; }
        public string Mota1 { get => Mota; set => Mota = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string MaDiadiem { get => maDiadiem; set => maDiadiem = value; }
    }

}
