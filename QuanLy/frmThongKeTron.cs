using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraCharts;
using Main;
using System;

namespace QuanLy
{
    public partial class frmThongKeTron : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeTron()
        {
            InitializeComponent();
        }
        cls_ThongKe _tk;
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            _tk = new cls_ThongKe();
            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtNgayD.Value = dt;
            DateTime ht = DateTime.Now;
            dtNgayC.Value = ht;
            loadTK();
           
        }
        void loadTK()
        {
            Series _seri = new Series("Thống kê", DevExpress.XtraCharts.ViewType.Pie);
            charDoanhThuThang.Series.Clear();
            var lst = _tk.DoanhThuTheoNhomBDS(dtNgayD.Value, dtNgayC.Value);
            foreach (var item in lst)
            {
                _seri.Points.Add(new SeriesPoint(item.TenLoai, item.ThanhTien));
            }

            charDoanhThuThang.Series.Add(_seri);
            _seri.Label.TextPattern = "{A}: {VP: p0}";
        }

        private void dtNgayD_ValueChanged(object sender, EventArgs e)
        {
            loadTK();
        }

        private void dtNgayC_ValueChanged(object sender, EventArgs e)
        {
            loadTK();
        }
    }
}