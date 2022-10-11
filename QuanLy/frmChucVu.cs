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
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmChucVu()
        {
            InitializeComponent();
        }

        cls_ChucVu _cv;
        bool _tt;
        string  id = null;
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            _tt = false;
            _cv = new cls_ChucVu();
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
            gcChucVu.DataSource = _cv.getList();
            gvChucVu.OptionsBehavior.Editable = false;
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
            if (id == null)
            {
                MessageBox.Show("Vui Lòng Chọn Dòng");
                return;
            } 
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                _cv.Delete(id);
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
            try {
                if (txtTen.Text == "")
                    if (_tt)
                    {
                        CHUCVU cv = new CHUCVU();
                        data_BDSEntities db = new data_BDSEntities();
                        var list = db.P_MACV().ToList();
                        foreach (var item in list)
                        {
                            cv.MaCV = item;
                        }
                        cv.TenCV = txtTen.Text;
                        _cv.Add(cv);
                    }
                    else
                    {
                        var cv = _cv.getItem(id);
                        cv.TenCV = txtTen.Text;
                        _cv.Updata(cv);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gvChucVu_Click(object sender, EventArgs e)
        {
            id = gvChucVu.GetFocusedRowCellValue("MaCV").ToString();
            txtTen.Text = gvChucVu.GetFocusedRowCellValue("TenCV").ToString();
        }
    }
}