using Data;
using DevExpress.XtraReports.UI;
using Main.Full;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QuanLy.Reports
{
    public partial class rptKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptKhachHang()
        {
            InitializeComponent();
        }
        List<KHACHHANG> _listKH;
        public rptKhachHang(List<KHACHHANG> listKH)
        {
            InitializeComponent();
            this._listKH = listKH;
            this.DataSource = _listKH;
            LoadData();
        }
        void LoadData()
        {
            lblMaKH.DataBindings.Add("Text", _listKH, "MaKH");
            lblHoTen.DataBindings.Add("Text", _listKH, "HoTenKH");
            lblSDT.DataBindings.Add("Text", _listKH, "SDT");
            lblEmail.DataBindings.Add("Text", _listKH, "Emaill");
            lblDiaChi.DataBindings.Add("Text", _listKH, "DiaChi");
        }
    }
}
