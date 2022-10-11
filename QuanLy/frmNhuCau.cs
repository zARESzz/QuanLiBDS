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
    public partial class frmNhuCau : DevExpress.XtraEditors.XtraForm
    {
        public frmNhuCau()
        {
            InitializeComponent();
        }

        cls_NhuCau _nc;
        bool _tt;
        string id;
        private void frmNhuCau_Load(object sender, EventArgs e)
        {
            _tt = false;
            _nc = new cls_NhuCau();
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
            gcNhuCau.DataSource = _nc.getList();
            gvNhuCau.OptionsBehavior.Editable = false;
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
                _nc.Delete(id);
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
                    throw new Exception("Vui Long Nhap Day Du Thong Tin");
                if (_tt)
                {
                    NHUCAU cv = new NHUCAU();
                    data_BDSEntities db = new data_BDSEntities();
                    var list = db.P_MaNC().ToList();
                    foreach (var item in list)
                    {
                        cv.MaNC = item;
                    }
                    cv.TenNC = txtTen.Text;
                    _nc.Add(cv);
                }
                else
                {
                    var cv = _nc.getItem(id);
                    cv.TenNC = txtTen.Text;
                    _nc.Updata(cv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gvChucVu_Click(object sender, EventArgs e)
        {
            id = gvNhuCau.GetFocusedRowCellValue("MaNC").ToString();
            txtTen.Text = gvNhuCau.GetFocusedRowCellValue("TenNC").ToString();
        }

        private void txtTen_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}