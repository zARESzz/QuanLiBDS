using Main;
using System;

namespace QuanLy
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        cls_CTNC _ct;

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            _ct = new cls_CTNC();
            gcBDS.DataSource = _ct.getListFull();
            lvBDS.OptionsBehavior.Editable = false;
            
        }
    }
}