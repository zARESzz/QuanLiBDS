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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        cls_KhachHang _kh;
        bool _tt;
        string id;
        private void frmKHACHHANG_Load(object sender, EventArgs e)
        {
            _tt = false;
            _kh = new cls_KhachHang();
            ShowHide(true);
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }

        void ShowHide(bool kt)
        {
            txtHoTen.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtSDT.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            btnThem.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDele.Enabled = kt;
            btnDong.Enabled = kt;
            btnSave.Enabled = !kt;
            btnHuy.Enabled = !kt;
        }

        void loadData()
        {
            gcKHACHHANG.DataSource = _kh.getList();
            gvKHACHHANG.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
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
                _kh.Delete(id);
                txtHoTen.Text = "";
                txtDiaChi.Text = "";
                txtEmail.Text = "";
                txtSDT.Text = "";
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
                KHACHHANG kh = new KHACHHANG();
                data_BDSEntities db = new data_BDSEntities();
                var list = db.P_MAKH().ToList();
                foreach (var item in list)
                {
                    kh.MaKH = item;
                }
                kh.HoTenKH = txtHoTen.Text;
                kh.SDT = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.Emaill = txtEmail.Text;
                _kh.Add(kh);
            }
            else
            {
                var kh = _kh.getItem(id);
                kh.HoTenKH = txtHoTen.Text;
                kh.SDT = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.Emaill = txtEmail.Text;
                _kh.Updata(kh);
            }
        }

        private void gvKHACHHANG_Click(object sender, EventArgs e)
        {
            id = gvKHACHHANG.GetFocusedRowCellValue("MaKH").ToString();
            txtHoTen.Text = gvKHACHHANG.GetFocusedRowCellValue("HoTenKH").ToString();
            txtDiaChi.Text = gvKHACHHANG.GetFocusedRowCellValue("DiaChi").ToString();
            txtEmail.Text = gvKHACHHANG.GetFocusedRowCellValue("Emaill").ToString();
            txtSDT.Text = gvKHACHHANG.GetFocusedRowCellValue("SDT").ToString();
        }
    }
}