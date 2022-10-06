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
using Main.Full;
using System.IO;

namespace QuanLy
{
    public partial class frmBDS : DevExpress.XtraEditors.XtraForm
    {
        public frmBDS()
        {
            InitializeComponent();
        }
        cls_TinhTrang _ttr;
        cls_KhachHang _kh;
        cls_BDS _bds;
        cls_LoaiBD _loai;
        bool _tt;
        string id;
        private void frmBDS_Load(object sender, EventArgs e)
        {
            _tt = false;
            _bds = new cls_BDS();
            _ttr = new cls_TinhTrang();
            _kh = new cls_KhachHang();
            _loai = new cls_LoaiBD();
            ShowHide(true);
            loadData();
            loadComboBox();
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
            gcBDS.DataSource = _bds.getListFull();
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
            if (_tt)
            {
                BATDONGSAN bds = new BATDONGSAN();
                data_BDSEntities db = new data_BDSEntities();
                var list = db.P_MaBDS().ToList();
                foreach (var item in list)
                {
                    bds.MaBDS = item;
                }
                bds.HinhAnh = ImageToBase64(picHinhAnh.Image,picHinhAnh.Image.RawFormat) ;
                bds.TenBDS = txtTen.Text;
                bds.DienTich = long.Parse(txtDienTich.Text);
                bds.DiaChi = txtDiaChi.Text;
                bds.GioiThieu = txtGioiThieu.Text;
                bds.MaTT = cbxTinhTrang.SelectedValue.ToString();
                bds.MaKH = cbxKhachHang.SelectedValue.ToString();
                bds.MaLoai = cbxLoai.SelectedValue.ToString();
                _bds.Add(bds);
            }
            else
            {
                var bds = _bds.getItem(id);
                bds.HinhAnh = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                bds.TenBDS = txtTen.Text;
                bds.DienTich = long.Parse(txtDienTich.Text);
                bds.DiaChi = txtDiaChi.Text;
                bds.GioiThieu = txtGioiThieu.Text;
                bds.MaTT = cbxTinhTrang.SelectedValue.ToString();
                bds.MaKH = cbxKhachHang.SelectedValue.ToString();
                bds.MaLoai = cbxLoai.SelectedValue.ToString();
                _bds.Updata(bds);
            }
        }

        private void gvBDS_Click(object sender, EventArgs e)
        {
            id = gvBDS.GetFocusedRowCellValue("MaBDS").ToString();
            var tg = _bds.getItem(id);
            picHinhAnh.Image =Base64ToImage(tg.HinhAnh);
            txtTen.Text = tg.TenBDS;
            txtDienTich.Text = tg.DienTich.ToString();
            txtDiaChi.Text = tg.DiaChi;
            txtGioiThieu.Text = tg.GioiThieu;
            cbxTinhTrang.SelectedValue = tg.MaTT;
            cbxKhachHang.SelectedValue = tg.MaKH;
            cbxLoai.SelectedValue = tg.MaLoai;
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