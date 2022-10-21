using System;
using System.Linq;
using System.Windows.Forms;
using Main;
using CustomMessageBox;
using Data;

namespace QuanLy
{
    public partial class frmThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }
        data_BDSEntities db = new data_BDSEntities();
        cls_HopDong _hd;
        cls_ThanhToan _ttn;
        bool _tt;
        string id;

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            _tt = false;
            _hd = new cls_HopDong();
            _ttn = new cls_ThanhToan();
            ShowHide(true);
            loadData();
            loadComboBox();
            splitContainer1.Panel1Collapsed = true;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtKhachHang.Enabled = false;
            txtNhanVien.Enabled = false;
            
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
            gcThanhToan.DataSource = _ttn.getListFull();
            gvThanhToan.OptionsBehavior.Editable = false;
        }
        void loadComboBox()
        {
            cbxHD.DataSource = _hd.getList();
            cbxHD.DisplayMember = "TenBDS";
            cbxHD.ValueMember = "MaHD";
        }
        private void rong()
        {
            txtTen.Text = "";
            txtNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtKhachHang.Text = "";
            txtNhanVien.Text = "";
            txtNoiDung.Text = "";
            txtSoTien.Text = "";
            loadComboBox();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowHide(false);
            _tt = true;
            splitContainer1.Panel1Collapsed = false;
            rong();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _tt = false;
            ShowHide(false);
            splitContainer1.Panel1Collapsed = false;
           
        }

        private void btnDele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (RJMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ttn.Delete(id);
                var ktra = db.CHITIETNHUCAUs.FirstOrDefault(p => p.MaBDS == id);
                if (ktra == null)
                loadData();
                

            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (dtNgayLap.Value < DateTime.Now)
                {
                    throw new Exception("Ngày lập phải lớn hơn hoặc bằng ngày hiện tại!");
                }
                SaveData();
                loadData();
                _tt = false;
                ShowHide(true);
                splitContainer1.Panel1Collapsed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                if (txtDiaChi.Text == "" || txtKhachHang.Text == "" || txtNhanVien.Text == "" || txtNoiDung.Text == null || txtSoTien.Text == "")
                    throw new Exception("VUI lÒNG NHẬP ĐẦY ĐỦ");
                string ma = cbxHD.SelectedValue.ToString();
                var hd = db.HOPDONGs.FirstOrDefault(p => p.MaHD == ma);
                var tt = db.THANHTOANs.Where(p => p.MaHD == ma).ToList();
                if (tt != null)
                {
                    long tong = (long)tt.Sum(p => p.TongTien);
                    if (tong + long.Parse(txtSoTien.Text) > hd.Phi)
                        throw new Exception("Số tiền thanh toán lớn hơn phí hợp đồng");
                }
                if (_tt)
                {
                    THANHTOAN ttn = new THANHTOAN();
                    var list = db.P_MATToan().ToList();
                    foreach (var item in list)
                    {
                        ttn.MATT = item;
                    }
                    ttn.MaHD = cbxHD.SelectedValue.ToString();
                    ttn.NgayTT = dtNgayLap.Value;
                    ttn.NoiDung = txtNoiDung.Text;
                    ttn.TongTien = long.Parse(txtSoTien.Text);
                    _ttn.Add(ttn);
                }
                else
                {
                    var ttn = _ttn.getItem(id);
                    ttn.MaHD = cbxHD.SelectedValue.ToString();
                    ttn.NgayTT = dtNgayLap.Value;
                    ttn.NoiDung = txtNoiDung.Text;
                    ttn.TongTien = long.Parse(txtSoTien.Text);
                    _ttn.Updata(ttn);
                }
            }catch(Exception ex)
            {
                RJMessageBox.Show(ex.Message);
            }
        }

        private void gcHopDong_Click(object sender, EventArgs e)
        {
            try
            {
                id = gvThanhToan.GetFocusedRowCellValue("MATT").ToString();             
                var tg = _ttn.getItem(id);
                var hd = db.HOPDONGs.FirstOrDefault(p => p.MaHD == tg.MaHD);
                var bds = db.BATDONGSANs.FirstOrDefault(p => p.MaBDS == hd.MaBDS);
                txtTen.Text = bds.TenBDS;
                txtDiaChi.Text = bds.DiaChi;
                var kh = db.KHACHHANGs.FirstOrDefault(p => p.MaKH == hd.MaKH);
                txtKhachHang.Text = kh.HoTenKH;
                var nv = db.NHANVIENs.FirstOrDefault(p => p.MaTK == hd.MaTK);
                txtNhanVien.Text = nv.HoTenNV;
                txtSoTien.Text = tg.TongTien.ToString();
                txtNoiDung.Text = tg.NoiDung;
                dtNgayLap.Value = (DateTime)tg.NgayTT;
            }
            catch(Exception ex)
            {
                RJMessageBox.Show(ex.Message);
            }
        }

        private void cbxHD_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxHD.SelectedValue == null)
                return;
            string ma = cbxHD.SelectedValue.ToString();
            var hd = db.HOPDONGs.FirstOrDefault(p => p.MaHD == ma);
            if(hd!=null)
            {
                var bds = db.BATDONGSANs.FirstOrDefault(p => p.MaBDS == hd.MaBDS);
                txtTen.Text = bds.TenBDS;
                txtDiaChi.Text = bds.DiaChi;
                var kh = db.KHACHHANGs.FirstOrDefault(p => p.MaKH == hd.MaKH);
                txtKhachHang.Text = kh.HoTenKH;
                var nv = db.NHANVIENs.FirstOrDefault(p => p.MaTK == hd.MaTK);
                txtNhanVien.Text = nv.HoTenNV;
            }    
        }
    }
}