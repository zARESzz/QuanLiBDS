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
    public partial class frmLoaiBD : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiBD()
        {
            InitializeComponent();
        }

        cls_LoaiBD _lbd;
        bool _tt;
        string id;
        private void frmTinhTrang_Load(object sender, EventArgs e)
        {
            _tt = false;
            _lbd = new cls_LoaiBD();
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
            gcLoaiBD.DataSource = _lbd.getList();
            gvLoaiBD.OptionsBehavior.Editable = false;
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
                _lbd.Delete(id);
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
            if (_tt)
            {
                LOAIBD lbd = new LOAIBD();
                data_BDSEntities db = new data_BDSEntities();
                var list = db.P_MaLoai().ToList();
                foreach (var item in list)
                {
                    lbd.MaLoai = item;
                }
                lbd.TenLoai = txtTen.Text;
                _lbd.Add(lbd);
            }
            else
            {
                var lbd = _lbd.getItem(id);
                lbd.TenLoai = txtTen.Text;
                _lbd.Updata(lbd);
            }
        }
        private void gvLoaiBD_Click(object sender, EventArgs e)
        {
            id = gvLoaiBD.GetFocusedRowCellValue("MaLoai").ToString();
            txtTen.Text = gvLoaiBD.GetFocusedRowCellValue("TenLoai").ToString();
        }
    }
}