using Data;
using System.Collections.Generic;

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
