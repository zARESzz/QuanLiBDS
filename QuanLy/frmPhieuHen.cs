using System;
using System.Linq;
using System.Windows.Forms;
using Main;
using Data;
namespace QuanLy
{
    public partial class frmPhieuHen : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuHen()
        {
            InitializeComponent();
        }
        data_BDSEntities db = new data_BDSEntities();
        cls_PhieuHen _ph;
        cls_NhanVien _nv;
        cls_KHTN _tn;
        bool _tt;
        string id;
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            _tt = false;
            _ph = new cls_PhieuHen();
            _nv = new cls_NhanVien();
            _tn = new cls_KHTN();
            ShowHide(true);
            loadComboBox();
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }
        void loadComboBox()
        {
            cbxKHTN.DataSource = _tn.getList();
            cbxKHTN.DisplayMember = "HoTenTN";
            cbxKHTN.ValueMember = "MaTN";

            cbxNV.DataSource = _nv.getList();
            cbxNV.DisplayMember = "HoTenNV";
            cbxNV.ValueMember = "MaTK";
        }
        void ShowHide(bool kt)
        {
            txtDiaDiem.Enabled = !kt;
            btnThem.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDele.Enabled = kt;
            btnDong.Enabled = kt;
            btnSave.Enabled = !kt;
            btnHuy.Enabled = !kt;
        }

        void loadData()
        {
            gcPhieuHen.DataSource = _ph.getListFull();
            gvPhieuHen.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtDiaDiem.Text = "";
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
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Thông báo");
                return;
            }
            var check = db.NHANVIENs.FirstOrDefault(p => p.MaCV == id);
            if (check != null)
            {
                MessageBox.Show("Có nhân viên có chức vụ: " + id + "\nKhông Thể xóa", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ph.Delete(id);
                txtDiaDiem.Text = "";
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
                PHIEUHEN ph = new PHIEUHEN();
                data_BDSEntities db = new data_BDSEntities();
                var list = db.P_MAPH().ToList();
                foreach (var item in list)
                {
                    ph.MaPH = item;
                }
                ph.MaTN = int.Parse(cbxKHTN.SelectedValue.ToString());
                ph.MaTK = cbxNV.SelectedValue.ToString();
                ph.DIADIEM = txtDiaDiem.Text;
                ph.NGAYGIO = dtNgayGio.Value;
                _ph.Add(ph);
            }
            else
            {
                var ph = _ph.getItem(id);
                ph.DIADIEM = txtDiaDiem.Text;
                ph.NGAYGIO = dtNgayGio.Value;
                _ph.Updata(ph);
            }
        }

        private void gvPhieuHen_Click(object sender, EventArgs e)
        {
            id = gvPhieuHen.GetFocusedRowCellValue("MaPH").ToString();
            var tg = _ph.getItem(id);
            txtDiaDiem.Text = tg.DIADIEM;
            dtNgayGio.Value =(DateTime)tg.NGAYGIO;
            cbxKHTN.SelectedValue = tg.MaTN;
            cbxNV.SelectedValue = tg.MaTK;
        }
    }
}