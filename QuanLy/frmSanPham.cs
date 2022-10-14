using Data;
using DevExpress.XtraEditors;
using Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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