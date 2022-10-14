using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraCharts;
using Main;
using System;

namespace QuanLy
{
    public partial class frmThongKe : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        cls_ThongKe _tk;
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            _tk = new cls_ThongKe();
            Series _seri = new Series("Thống kê", DevExpress.XtraCharts.ViewType.Pie);
            var lst = _tk.DoanhThuTheoNhomBDS();
            foreach(var item in lst)
            {
                _seri.Points.Add(new SeriesPoint(item.TenLoai,item.ThanhTien));
            }    
          
            charDoanhThuThang.Series.Add(_seri);
            _seri.Label.TextPattern = "{A}: {VP: p0}";
        }
    }
}