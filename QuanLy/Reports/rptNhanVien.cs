using Main.Full;
using System.Collections.Generic;

namespace QuanLy.Reports
{
    public partial class rptNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptNhanVien()
        {
            InitializeComponent();
        }
        List<cls_NhanVien_Full> _listNV;
        public rptNhanVien(List<cls_NhanVien_Full> listNV)
        {
            InitializeComponent();
            this._listNV = listNV;
            this.DataSource = _listNV;
            LoadData();
        }
        void LoadData()
        {
            lblMaNV.DataBindings.Add("Text", _listNV, "MaTK");
            lblHoTen.DataBindings.Add("Text", _listNV, "HoTenNV");
            lblCV.DataBindings.Add("Text", _listNV, "TenCV");
            lblGT.DataBindings.Add("Text", _listNV, "GioiTinh");
            lblNS.DataBindings.Add("Text", _listNV, "NgaySinh");
            lblSDT.DataBindings.Add("Text", _listNV, "SDT");
            lblEmail.DataBindings.Add("Text", _listNV, "Email");
            lblDiaChi.DataBindings.Add("Text", _listNV, "DiaChi");
        }
    }
}
