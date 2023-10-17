﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using form1.Model;

namespace form1
{
    public partial class UseControlBaiViet : UserControl
    {
        Toudulich tour;
        public UseControlBaiViet(Toudulich tour)
        {
            InitializeComponent();
            this.tour = tour;
            Console.WriteLine(this.tour+"gái trị của tour");
        }
        private void UseControlBaiViet_Load(object sender, EventArgs e)
        {
            txtmatour.Text = tour.MaTour1.ToString();
            txtTentour.Text = tour.TenTour1.ToString();
            txtGhicu.Text = tour.Mota1.ToString();
            txttenks.Text = tour.Tenks.ToString();
            txtGia.Text = tour.GiaTien.ToString()+".000";
            txtdiadiem.Text = tour.Diachi.ToString();
            txtdiemdon.Text = tour.Diemdon.ToString();
            txtnbd.Text=tour.Ngaykh.ToString();
            txtnkt.Text=tour.Ngaykt.ToString();
            txtptien.Text=tour.Tenphuongtien.ToString();
            txtve.Text=tour.Sove.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
