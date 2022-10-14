using Main;
using System;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class frmQuanLy : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }
        void OpenForm(Type typeForm)
        {
            foreach(Form frm in MdiChildren)
            {
                 if(frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }    
            }
            Form f =(Form) Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        cls_PhieuHen _ph;
        cls_NhanVien _nv;
        cls_HopDong _hd;
        void loadList()
        {
            listSinhNhat.DataSource = _nv.getSinhNhat();
            listSinhNhat.DisplayMember = "HoTenNV";
            listSinhNhat.ValueMember = "MaTK";

            listLichHen.DataSource = _ph.getLichHen();
            listLichHen.DisplayMember = "MaTN";
            listLichHen.ValueMember = "MaLH";

            listHopDong.DataSource = _hd.getHopDong();
            listHopDong.DisplayMember = "MaBDS";
            listHopDong.ValueMember = "MaHD";            
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            _nv = new cls_NhanVien();
            _ph = new cls_PhieuHen();
            _hd = new cls_HopDong();
            loadList();
        }
        private void btnChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmChucVu));
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmNhanVien));
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmKhachHang));
        }

        private void btnTinhTrang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmTinhTrang));
        }

        private void btnLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmLoaiBD));
        }

        private void btnNhuCau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmNhuCau));
        }

        private void btnBatDongSan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmBDS));
        }
        private void btnHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmHopDong));
        }

        private void btnThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmThanhToan));
        }

        private void btnSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmSanPham));
        }

        private void btnKHTN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmKHTN));
        }
        private void btnCot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmThongKeCot));
        }

        private void btnTron_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmThongKeTron));
        }

        private void btnHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmThongKeHang));
        }

        private void btnPhieuHen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPhieuHen));
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPhanQuyen));
        }
    }
}
