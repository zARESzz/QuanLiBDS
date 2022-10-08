using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
