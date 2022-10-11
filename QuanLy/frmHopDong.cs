using System;
using System.Linq;
using System.Windows.Forms;
using Main;
using Data;

namespace QuanLy
{
    public partial class frmHopDong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopDong()
        {
            InitializeComponent();
        }
        data_BDSEntities db = new data_BDSEntities();
        cls_KhachHang _kh;
        cls_BDS _bds;
        cls_NhuCau _nc;
        cls_CTNC _ct;
        cls_HopDong _hd;
        cls_NhanVien _nv;
        bool _tt;
        string id;
        private void frmHopDong_Load(object sender, EventArgs e)
        {
            _tt = false;
            _bds = new cls_BDS();
            _kh = new cls_KhachHang();
            _nc = new cls_NhuCau();
            _ct = new cls_CTNC();
            _hd = new cls_HopDong();
            _nv = new cls_NhanVien();
            ShowHide(true);
            loadData();
            loadComboBox();
            splitContainer1.Panel1Collapsed = true;
            txtLoai.Enabled = false;
            txtTinhTrang.Enabled = false;
            txtDienTich.Enabled = false;
            txtGia.Enabled = false;
            txtDiaChi.Enabled = false;
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
            gcHopDong.DataSource = _hd.getListFull();
            gvHopDong.OptionsBehavior.Editable = false;
        }
        void loadComboBox()
        {
            cbxKhachHang.DataSource = _kh.getList();
            cbxKhachHang.DisplayMember = "HoTenKH";
            cbxKhachHang.ValueMember = "MaKH";

            cbxBDS.DataSource = _bds.getList();
            cbxBDS.DisplayMember = "TenBDS";
            cbxBDS.ValueMember = "MaBDS";

            cbxNhuCau.DataSource = _nc.getList();
            cbxNhuCau.DisplayMember = "TenNC";
            cbxNhuCau.ValueMember = "MaNC";

            cbxNhanVien.DataSource = _nv.getList();
            cbxNhanVien.DisplayMember = "HoTenNV";
            cbxNhanVien.ValueMember = "MaTK";
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
                _ct.Delete(id);
                var ktra = db.CHITIETNHUCAUs.FirstOrDefault(p => p.MaBDS == id);
                if (ktra == null)
                    _bds.Delete(id);
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
        string maNC;
        private void cbxNhuCau_SelectedValueChanged(object sender, EventArgs e)
        {
            maNC = cbxNhuCau.SelectedValue.ToString();
            GoiY();
            
        }
        string maBDS;
        private void cbxBDS_SelectedValueChanged(object sender, EventArgs e)
        {
            maBDS = cbxBDS.SelectedValue.ToString();
            GoiY();

        }
       void GoiY()
       {
            var ct = db.CHITIETNHUCAUs.FirstOrDefault(p => p.MaBDS == maBDS && p.MaNC == maNC);
            if (ct != null)
            {
                var bds = db.BATDONGSANs.FirstOrDefault(p => p.MaBDS == maBDS);
                if (bds != null)
                {
                    txtDiaChi.Text = bds.DiaChi.ToString();
                    txtDienTich.Text = bds.DienTich.ToString();
                    var loai = db.LOAIBDS.FirstOrDefault(p => p.MaLoai == bds.MaLoai);
                    txtLoai.Text = loai.TenLoai.ToString();
                    //var kh = db.KHACHHANGs.FirstOrDefault(p => p.MaKH == bds.MaKH);
                    cbxKhachHang.SelectedValue = bds.MaKH;
                    cbxKhachHang.Enabled = false;
                    var tt = db.TINHTRANGs.FirstOrDefault(p => p.MaTT == bds.MaTT);
                    txtTinhTrang.Text = tt.TenTT;

                }
                txtGia.Text = ct.DinhGia.ToString();
            }
            else
            {
                txtGia.Text = "";
                txtDiaChi.Text = "";
                txtDienTich.Text = "";
                txtLoai.Text = "";
                txtTinhTrang.Text = "";
                cbxKhachHang.Enabled = true;
            }
       }

        void SaveData()
        {
            try
            {
                if (txtChiTiet.Text == null || txtDiaChi.Text == "" || txtDienTich.Text == "" || txtGia.Text == "" || txtLoai.Text == "" || txtPhi.Text == "" || txtTinhTrang.Text == "")
                    throw new Exception("VUI lÒNG NHẬP ĐẦY ĐỦ");
                if (_tt)
                {
                    HOPDONG hd = new HOPDONG();
                    CHITIETNHUCAU ct = new CHITIETNHUCAU();
                    var list = db.P_MaHD().ToList();
                    foreach (var item in list)
                    {
                        hd.MaHD = item;
                    }
                    hd.MaNC = cbxNhuCau.SelectedValue.ToString();
                    hd.MaBDS = cbxBDS.SelectedValue.ToString();
                    hd.MaKH = cbxKhachHang.SelectedValue.ToString();
                    hd.MaTK = cbxNhanVien.SelectedValue.ToString();
                    hd.Phi = long.Parse(txtPhi.Text);
                    hd.ChiTiet = txtChiTiet.Text;
                    hd.NgayLap = dtNgayLap.Value;
                    hd.NgayBD = dtNgayBD.Value;
                    hd.NgayKT = dtNgayKT.Value;
                    _hd.Add(hd);
                }
                else
                {
                    var hd = _hd.getItem(id);
                    hd.MaNC = cbxNhuCau.SelectedValue.ToString();
                    hd.MaBDS = cbxBDS.SelectedValue.ToString();
                    hd.MaKH = cbxKhachHang.SelectedValue.ToString();
                    hd.MaTK = cbxNhanVien.SelectedValue.ToString();
                    hd.Phi = long.Parse(txtPhi.Text);
                    hd.ChiTiet = txtChiTiet.Text;
                    hd.NgayLap = dtNgayLap.Value;
                    hd.NgayBD = dtNgayBD.Value;
                    hd.NgayKT = dtNgayKT.Value;
                    _hd.Updata(hd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gcHopDong_Click(object sender, EventArgs e)
        {
            id = gvHopDong.GetFocusedRowCellValue("MaHD").ToString();
            var tg = _hd.getItem(id);
            cbxNhuCau.SelectedValue = tg.MaNC;
            cbxBDS.SelectedValue = tg.MaBDS;
            var bds = db.BATDONGSANs.FirstOrDefault(p => p.MaBDS == tg.MaBDS);
            var loai = db.LOAIBDS.FirstOrDefault(p => p.MaLoai == bds.MaLoai);
            txtLoai.Text = loai.TenLoai;
            var ttr = db.TINHTRANGs.FirstOrDefault(p => p.MaTT == bds.MaTT);
            txtTinhTrang.Text = ttr.TenTT;
            txtDienTich.Text = bds.DienTich.ToString();
            var ct = db.CHITIETNHUCAUs.FirstOrDefault(p => p.MaBDS == tg.MaBDS && p.MaNC == tg.MaNC);
            txtGia.Text = ct.DinhGia.ToString();
            txtDiaChi.Text = bds.DiaChi.ToString();
            cbxNhanVien.SelectedValue = tg.MaTK;
            cbxKhachHang.SelectedValue = tg.MaKH;
            txtPhi.Text = tg.Phi.ToString();
            txtChiTiet.Text = tg.ChiTiet;
            dtNgayLap.Value = (DateTime)tg.NgayLap;
            dtNgayBD.Value = (DateTime)tg.NgayBD;
            dtNgayKT.Value = (DateTime)tg.NgayKT;
        }
    }
}