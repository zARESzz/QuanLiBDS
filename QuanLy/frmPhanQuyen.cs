using CustomMessageBox;
using Data;
using Main;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }
        cls_NhanVien _nv;
        cls_ChucVu _cv;
        string id;
        private void frmNHANVIEN_Load(object sender, EventArgs e)
        {
            _nv = new cls_NhanVien();
            _cv = new cls_ChucVu();
            loadData();
            loadComboBox();
        }
        void loadComboBox()
        {
            cbxChucVu.DataSource = _cv.getList();
            cbxChucVu.DisplayMember = "TenCV";
            cbxChucVu.ValueMember = "MaCV";
        }
        void loadData()
        {
            gcNHANVIEN.DataSource = _nv.getListFull();
            gvNHANVIEN.OptionsBehavior.Editable = false;
        }
        private void gvNHANVIEN_Click(object sender, EventArgs e)
        {
            id = gvNHANVIEN.GetFocusedRowCellValue("MaTK").ToString();
            var nv = _nv.getItem(id);
            cbxChucVu.SelectedValue = nv.MaCV;
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            data_BDSEntities db = new data_BDSEntities();
            try
            {
                var check = db.NHANVIENs.SingleOrDefault(p=>p.MaTK==id);
                if (check != null)
                {
                    check.MaCV = cbxChucVu.SelectedValue.ToString();
                    db.SaveChanges();
                    RJMessageBox.Show("Thay đổi thành công", "Thông báo");
                    _nv = new cls_NhanVien();
                    loadData();
                }    
                else
                {
                    RJMessageBox.Show("Không tìm thấy nhân viên", "Thông báo");
                }    
            }catch(Exception ex)
            {
                RJMessageBox.Show("Thất bại" + ex.Message, "Thông báo");
            }
        }
    }
}