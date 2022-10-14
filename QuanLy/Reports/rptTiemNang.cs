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
    public partial class rptTiemNang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTiemNang()
        {
            InitializeComponent();
        }
        List<KHTN> _listTN;
        public rptTiemNang(List<KHTN> listTN)
        {
            InitializeComponent();
            this._listTN = listTN;
            this.DataSource = _listTN;
            LoadData();
        }
        void LoadData()
        {
            lblMaKH.DataBindings.Add("Text", _listTN, "MaTN");
            lblHoTen.DataBindings.Add("Text", _listTN, "HoTenTN");
            lblSDT.DataBindings.Add("Text", _listTN, "SDT");
            lblEmail.DataBindings.Add("Text", _listTN, "Email");
            lblDiaChi.DataBindings.Add("Text", _listTN, "DiaChi");
        }
    }
}
