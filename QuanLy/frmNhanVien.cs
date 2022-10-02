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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        cls_NhanVien _nv;
        cls_ChucVu _cv;
        bool _tt;
        string id;
        private void frmNHANVIEN_Load(object sender, EventArgs e)
        {
            _tt = false;
            _nv = new cls_NhanVien();
            _cv = new cls_ChucVu();
            ShowHide(true);
            loadData();
            loadComboBox();
            splitContainer1.Panel1Collapsed = true;
        }
        void loadComboBox()
        {
            cbxChucVu.DataSource = _cv.getList();
            cbxChucVu.DisplayMember = "TenCV";
            cbxChucVu.ValueMember = "MaCV";
        }
        void ShowHide(bool kt)
        {
            txtHoTen.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtMatKhau.Enabled = !kt;
            btnThem.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDele.Enabled = kt;
            btnDong.Enabled = kt;
            btnSave.Enabled = !kt;
            btnHuy.Enabled = !kt;
        }

        void loadData()
        {
            gcNHANVIEN.DataSource = _nv.getList();
            gvNHANVIEN.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtHoTen.Text = "";
            txtMatKhau.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
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
                _nv.Delete(id);
                txtHoTen.Text = "";
                txtMatKhau.Text = "";
                txtEmail.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
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
                NHANVIEN kh = new NHANVIEN();
                data_BDSEntities db = new data_BDSEntities();
                var list = db.P_MATK().ToList();
                foreach (var item in list)
                {
                    kh.MaTK = item;
                }
                kh.HoTenNV = txtHoTen.Text;
                kh.GioiTinh = chkGioiTinh.Checked?"Nam":"Nữ";
                kh.NgaySinh = dtNgaySinh.Value;
                kh.MK = txtMatKhau.Text;
                kh.MaCV = cbxChucVu.SelectedValue.ToString(); 
                kh.SDT = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.Email = txtEmail.Text;
                _nv.Add(kh);
            }
            else
            {
                var kh = _nv.getItem(id);
                kh.HoTenNV = txtHoTen.Text;
                kh.GioiTinh = chkGioiTinh.Checked ? "Nam" : "Nữ";
                kh.NgaySinh = dtNgaySinh.Value;
                kh.MK = txtMatKhau.Text;
                kh.MaCV = cbxChucVu.SelectedValue.ToString();
                kh.SDT = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.Email = txtEmail.Text;
                _nv.Updata(kh);
            }
        }

        private void gvNHANVIEN_Click(object sender, EventArgs e)
        {
            id = gvNHANVIEN.GetFocusedRowCellValue("MaTK").ToString();
            var nv = _nv.getItem(id);
            txtHoTen.Text = nv.HoTenNV;
            txtMatKhau.Text = nv.MK;
            txtDiaChi.Text = nv.DiaChi;
            txtEmail.Text = nv.Email;
            txtSDT.Text = nv.SDT;
            if (nv.GioiTinh == "Nam")
                chkGioiTinh.Checked = true;
            else
                chkGioiTinh.Checked = false;
            cbxChucVu.SelectedValue = nv.MaCV;
        }
    }
}