using Data;
using DevExpress.XtraEditors;
using Main;
using Main.Full;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QuanLy.Reports;
using System.Text.RegularExpressions;
using DevExpress.Charts.Native;
using DevExpress.XtraGauges.Core.Model;

namespace QuanLy
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        List<cls_NhanVien_Full> _listNV;
        cls_NhanVien _nv;
        cls_ChucVu _cv;
        cls_MatKhau _mk = new cls_MatKhau();
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
            gcNHANVIEN.DataSource = _nv.getListFull();
            gvNHANVIEN.OptionsBehavior.Editable = false;
            _listNV = _nv.getListFull();
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
        {  try
            {
                if (txtHoTen.Text == ""||txtMatKhau.Text==""||txtSDT.Text==""||txtDiaChi.Text==""||txtEmail.Text=="")
                    throw new Exception("VUI lÒNG NHẬP ĐẦY ĐỦ");
                if (isEmail(txtEmail.Text))
                    throw new Exception("Sai Định Dạng Email");
                if (ktrphone(txtSDT.Text)==false)
                    throw new Exception("Sai Định Dạng SDT");
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
                    kh.GioiTinh = chkGioiTinh.Checked ? "Nam" : "Nữ";
                    kh.NgaySinh = dtNgaySinh.Value;
                    kh.MK = _mk.MaHoa(txtMatKhau.Text);
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
                    kh.MK = _mk.MaHoa(txtMatKhau.Text);
                    kh.MaCV = cbxChucVu.SelectedValue.ToString();
                    kh.SDT = txtSDT.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.Email = txtEmail.Text;
                    _nv.Updata(kh);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (false);
            else
                return (true);
        }

        private bool ktrphone(string check)
        {      
            Regex regex = new Regex(@"^(0|84)([0-9]{9})$");
            return regex.IsMatch(check);
        }
        private void gvNHANVIEN_Click(object sender, EventArgs e)
        {
            id = gvNHANVIEN.GetFocusedRowCellValue("MaTK").ToString();
            var nv = _nv.getItem(id);
            txtHoTen.Text = nv.HoTenNV;
            txtMatKhau.Text =_mk.GiaiMa(nv.MK);
            txtDiaChi.Text = nv.DiaChi;
            txtEmail.Text = nv.Email;
            txtSDT.Text = nv.SDT;
            if (nv.GioiTinh == "Nam")
                chkGioiTinh.Checked = true;
            else
                chkGioiTinh.Checked = false;
            cbxChucVu.SelectedValue = nv.MaCV;
        }

        private void txtMatKhau_MouseMove(object sender, MouseEventArgs e)
        {
            txtMatKhau.Properties.UseSystemPasswordChar = false;
        }

        private void txtMatKhau_MouseLeave(object sender, EventArgs e)
        {
            txtMatKhau.Properties.UseSystemPasswordChar = true;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptNhanVien rpt = new rptNhanVien(_listNV);
            rpt.ShowPreview();
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }
    }
}