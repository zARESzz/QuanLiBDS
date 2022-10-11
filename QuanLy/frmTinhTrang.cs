using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;
using Data;
using System.Data.Entity;

namespace QuanLy
{
    public partial class frmTinhTrang : DevExpress.XtraEditors.XtraForm
    {
        public frmTinhTrang()
        {
            InitializeComponent();
        }

        cls_TinhTrang _ttr;
        bool _tt;
        string id;
        private void frmTinhTrang_Load(object sender, EventArgs e)
        {
            _tt = false;
            _ttr = new cls_TinhTrang();
            ShowHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }

        void ShowHide(bool kt)
        {
            txtTen.Enabled = !kt;
            btnThem.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDele.Enabled = kt;
            btnDong.Enabled = kt;
            btnSave.Enabled = !kt;
            btnHuy.Enabled = !kt;
        }

        void loadData()
        {
            gcTinhTrang.DataSource = _ttr.getList();
            gvTinhTrang.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTen.Text = "";
            ShowHide(false);
            _tt = true;
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _tt = false;
            ShowHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnDele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ttr.Delete(id);
                txtTen.Text = "";
                loadData();

            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _tt = false;
            ShowHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _tt = false;
            ShowHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            try
            {
                if (txtTen.Text == "")
                    throw new Exception("VUI lÒNG NHẬP ĐẦY ĐỦ");
                if (_tt)
                {
                    TINHTRANG tt = new TINHTRANG();
                    data_BDSEntities db = new data_BDSEntities();
                    var list = db.P_MaTT().ToList();
                    foreach (var item in list)
                    {
                        tt.MaTT = item;
                    }
                    tt.TenTT = txtTen.Text;
                    _ttr.Add(tt);
                }
                else
                {
                    var tt = _ttr.getItem(id);
                    tt.TenTT = txtTen.Text;
                    _ttr.Updata(tt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gvTinhTrang_Click(object sender, EventArgs e)
        {
            id = gvTinhTrang.GetFocusedRowCellValue("MaTT").ToString();
            txtTen.Text = gvTinhTrang.GetFocusedRowCellValue("TenTT").ToString();
        }
    }
}