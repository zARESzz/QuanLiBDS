using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Main;
using Data;
using System.IO;
using CustomMessageBox;

namespace QuanLy
{
    public partial class frmBDS : DevExpress.XtraEditors.XtraForm
    {
        public frmBDS()
        {
            InitializeComponent();
        }
        data_BDSEntities db = new data_BDSEntities();
        cls_TinhTrang _ttr;
        cls_KhachHang _kh;
        cls_BDS _bds;
        cls_LoaiBD _loai;
        cls_NhuCau _nc;
        cls_CTNC _ct;
        bool _tt;
        string id;
        string _id;
        private void frmBDS_Load(object sender, EventArgs e)
        {
            _tt = false;
            _bds = new cls_BDS();
            _ttr = new cls_TinhTrang();
            _kh = new cls_KhachHang();
            _loai = new cls_LoaiBD();
            _nc = new cls_NhuCau();
            _ct = new cls_CTNC();
            ShowHide(true);
            loadData();
            loadComboBox();
            splitContainer1.Panel1Collapsed = true;
        }
        private void rong()
        {
            txtDiaChi.Text = "";
            txtDienTich.Text = "";
            txtGia.Text = "";
            txtGioiThieu.Text = "";
            txtTen.Text = "";
            loadComboBox();
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
            gcBDS.DataSource = _ct.getListFull();
            gvBDS.OptionsBehavior.Editable = false;
        }
        void loadComboBox()
        {
            cbxKhachHang.DataSource = _kh.getList();
            cbxKhachHang.DisplayMember = "HoTenKH";
            cbxKhachHang.ValueMember = "MaKH";

            cbxLoai.DataSource = _loai.getList();
            cbxLoai.DisplayMember = "TenLoai";
            cbxLoai.ValueMember = "MaLoai";

            cbxTinhTrang.DataSource = _ttr.getList();
            cbxTinhTrang.DisplayMember = "TenTT";
            cbxTinhTrang.ValueMember = "MaTT";

            cbxNhuCau.DataSource = _nc.getList();
            cbxNhuCau.DisplayMember = "TenNC";
            cbxNhuCau.ValueMember = "MaNC";
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
                _ct.Delete(id);
                var ktra = db.CHITIETNHUCAUs.FirstOrDefault(p => p.MaBDS == id);
                if(ktra==null)
                    _bds.Delete(id);
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
                if (txtTen.Text == "" || txtDiaChi.Text == "" || txtDienTich.Text == "" || txtGia.Text == "" || txtGioiThieu.Text == "")
                    throw new Exception("VUI lÒNG NHẬP ĐẦY ĐỦ");
                if (_tt)
                {
                    BATDONGSAN bds = new BATDONGSAN();
                    CHITIETNHUCAU ct = new CHITIETNHUCAU();
                    var ktra = db.BATDONGSANs.FirstOrDefault(p =>
                    p.TenBDS == txtTen.Text &&
                    p.DiaChi == txtDiaChi.Text &&
                    p.MaKH == cbxKhachHang.SelectedValue.ToString() &&
                    p.MaLoai == cbxLoai.SelectedValue.ToString());
                    if (ktra == null)
                    {
                        var list = db.P_MaBDS().ToList();
                        foreach (var item in list)
                        {
                            bds.MaBDS = item;
                        }
                        bds.HinhAnh = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                        bds.TenBDS = txtTen.Text;
                        bds.DienTich = long.Parse(txtDienTich.Text);
                        bds.DiaChi = txtDiaChi.Text;
                        bds.GioiThieu = txtGioiThieu.Text;
                        bds.MaTT = cbxTinhTrang.SelectedValue.ToString();
                        bds.MaKH = cbxKhachHang.SelectedValue.ToString();
                        bds.MaLoai = cbxLoai.SelectedValue.ToString();
                        _bds.Add(bds);
                        ct.MaBDS = bds.MaBDS;
                        ct.MaNC = cbxNhuCau.SelectedValue.ToString();
                        ct.DinhGia = long.Parse(txtGia.Text);
                        _ct.Add(ct);
                    }
                    else
                    {
                        var ktT = db.CHITIETNHUCAUs.SingleOrDefault(p => p.MaNC == cbxNhuCau.SelectedValue.ToString() && p.MaBDS == ktra.MaBDS);
                        if (ktT != null)
                        {
                            RJMessageBox.Show("Đã tồn tại", "Thông báo");
                            return;
                        }
                        ct.MaBDS = ktra.MaBDS;
                        ct.MaNC = cbxNhuCau.SelectedValue.ToString();
                        ct.DinhGia = long.Parse(txtGia.Text);
                        _ct.Add(ct);
                    }
                }
                else
                {
                    var ct = _ct.getItem(id);
                    var bds = db.BATDONGSANs.FirstOrDefault(p => p.MaBDS == ct.MaBDS);
                    bds.HinhAnh = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                    bds.TenBDS = txtTen.Text;
                    bds.DienTich = long.Parse(txtDienTich.Text);
                    bds.DiaChi = txtDiaChi.Text;
                    bds.GioiThieu = txtGioiThieu.Text;
                    bds.MaTT = cbxTinhTrang.SelectedValue.ToString();
                    bds.MaKH = cbxKhachHang.SelectedValue.ToString();
                    bds.MaLoai = cbxLoai.SelectedValue.ToString();
                    _bds.Updata(bds);
                    _ct.Delete(id);
                    ct.MaBDS = bds.MaBDS;
                    ct.MaNC = cbxNhuCau.SelectedValue.ToString();
                    ct.DinhGia = long.Parse(txtGia.Text);
                    _ct.Add(ct);
                    _ct = new cls_CTNC();
                    loadData();
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message);
            }

        }

        private void gvBDS_Click(object sender, EventArgs e)
        {
            id = gvBDS.GetFocusedRowCellValue("MaBDS").ToString();
            _id = gvBDS.GetFocusedRowCellValue("MaNC").ToString();
            var tg = _bds.getItem(id);
            if(tg.HinhAnh != null)
            picHinhAnh.Image =Base64ToImage(tg.HinhAnh);
            txtTen.Text = tg.TenBDS;
            txtDienTich.Text = tg.DienTich.ToString();
            txtDiaChi.Text = tg.DiaChi;
            txtGioiThieu.Text = tg.GioiThieu;
            cbxTinhTrang.SelectedValue = tg.MaTT;
            cbxKhachHang.SelectedValue = tg.MaKH;
            cbxLoai.SelectedValue = tg.MaLoai;
            var ct = _ct.getItemNC(_id);
            txtGia.Text = ct.DinhGia.ToString();
            cbxNhuCau.SelectedValue = ct.MaNC;
        }
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }    
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes,0,imageBytes.Length);
            ms.Write(imageBytes,0,imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture(.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFile.FileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }    
        }

    }
}