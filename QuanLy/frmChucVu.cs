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
        string id;
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            _tt = false;
            _cv = new cls_ChucVu();
            ShowHide(true);
            loadData();
        }

        void ShowHide(bool kt)
        {
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
            ShowHide(false);
            _tt = true;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _tt = false;
            ShowHide(false);
        }

        private void btnDele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                _cv.Delete(id);
                loadData();

            }    
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _tt = false;
            ShowHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _tt = false;
            ShowHide(true);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        int i = 4;
        void SaveData()
        {
            if(_tt)
            {
                CHUCVU cv = new CHUCVU();
                cv.MaCV = "CV" + i;
                cv.TenCV = txtTen.Text;
                _cv.Add(cv);
                i++;
            }
            else
            {
                var cv = _cv.getItem(id);
                cv.TenCV = txtTen.Text;
                _cv.Updata(cv);
            }    
        }

        private void gvChucVu_Click(object sender, EventArgs e)
        {
            id = gvChucVu.GetFocusedRowCellValue("MaCV").ToString();
            txtTen.Text = gvChucVu.GetFocusedRowCellValue("TenCV").ToString();
        }
    }
}